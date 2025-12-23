using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides the dialog for performing a secure file erase and delete function.
/// </summary>
/// <seealso cref="Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase" />
public partial class SecureEraseFileDialog : AdaptiveDialogBase
{
    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="SecureEraseFileDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public SecureEraseFileDialog()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            components?.Dispose();
        }

        components = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Protected Method Overrides    
    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        base.AssignEventHandlers();

        CloseButton.Click += HandleCloseClicked;
        BrowseButton.Click += HandleFileClicked;
        DeleteButton.Click += HandleDeleteClicked;

        FileText.TextChanged += HandleGenericControlChange;

    }
    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        base.RemoveEventHandlers();

        CloseButton.Click -= HandleCloseClicked;
        BrowseButton.Click -= HandleFileClicked;
        DeleteButton.Click -= HandleDeleteClicked;

        FileText.TextChanged -= HandleGenericControlChange;
    }
    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    protected override void SetPreLoadState()
    {
        base.SetPreLoadState();
        FileText.Enabled = false;
        BrowseButton.Enabled = false;
        CloseButton.Enabled = false;
        DeleteButton.Enabled = false;
        Application.DoEvents();
    }

    /// <summary>
    /// Sets the state of the UI controls after the data content is loaded.
    /// </summary>
    protected override void SetPostLoadState()
    {
        FileText.Enabled = true;
        BrowseButton.Enabled = true;
        CloseButton.Enabled = true;
        DeleteButton.Enabled = true;
        ResumeLayout();
        base.SetPostLoadState();
    }

    /// <summary>
    /// When implemented in a derived class, sets the display state for the controls on the dialog based on
    /// current conditions.
    /// </summary>
    /// <remarks>
    /// This is called by <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase.SetState" /> after <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase.SetSecurityState" /> is called.
    /// </remarks>
    protected override void SetDisplayState()
    {
        DeleteButton.Enabled = File.Exists(FileText.Text);
        StatusLabel.Visible = false;
        StatusPrg.Visible = false;
    }
    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles the event when the Cancel button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleCloseClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        DialogResult = DialogResult.Cancel;
        Close();
    }

    /// <summary>
    /// Handles the event when the Browse button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleFileClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        OpenFileDialog dialog =         DialogProvider.CreateOpenFileDialog();
        dialog.Title = "Select File To Be Erased";
        dialog.Filter = "All Files (*.*)|*.*";
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            FileText.Text = dialog.FileName;
        }
        dialog.Dispose();

        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Secure Delete button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    /// <returns></returns>
    private void HandleDeleteClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        StatusLabel.Text = "Preparing...";
        StatusPrg.Value = 0;
        StatusPrg.Visible = true;
        StatusLabel.Visible = true;

        // Start the async process.  It will restore the UI state on its own.
        PerformSecureDeleteAsync(FileText.Text);

    }

    /// <summary>
    /// Handles the event when the deletion process updates its status.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
    /// <returns></returns>
    private void HandleDeleteStatusUpdate(object? sender, ProgressUpdateEventArgs e)
    {
        ContinueInMainThread(() =>
        {
            StatusLabel.Text = e.Status;
            StatusPrg.Value = e.PercentDone;
        });
    }
    #endregion

    #region Private Methods / Functions    
    /// <summary>
    /// Updates the status in the UI.
    /// </summary>
    /// <param name="status">
    /// A string containing the status value.
    /// </param>
    /// <param name="percentDone">
    /// An integer indicating the percentage of completion of the operation.
    /// </param>
    /// <returns></returns>
    private void UpdateStatus(string status, int percentDone)
    {
        // Execute in the main UI thread.
        ContinueInMainThread(() =>
        {
            StatusLabel.Text = status;
            StatusPrg.Value = percentDone;
        });
    }

    /// <summary>
    /// Executes the secure delete process.
    /// </summary>
    private async Task PerformSecureDeleteAsync(string fileName)
    {
        SecureDeleteClient client = new SecureDeleteClient();
        client.StatusUpdate += HandleDeleteStatusUpdate;

        await client.SecureDeleteFileAsync(fileName);

        client.StatusUpdate -= HandleDeleteStatusUpdate;
        client.Dispose();

        ContinueInMainThread(() =>
        {
            SetPostLoadState();
            SetState();
        });
    }
    #endregion
}
