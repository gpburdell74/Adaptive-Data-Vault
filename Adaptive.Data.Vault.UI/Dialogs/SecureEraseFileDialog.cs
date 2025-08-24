using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

public partial class SecureEraseFileDialog : AdaptiveDialogBase
{
    public SecureEraseFileDialog()
    {
        InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
        if (!base.IsDisposed && disposing)
        {
            components?.Dispose();
        }
        components = null;
        base.Dispose(disposing);
    }

    protected override void AssignEventHandlers()
    {
        base.AssignEventHandlers();
        CloseButton.Click += HandleCloseClicked;
        BrowseButton.Click += HandleFileClicked;
        DeleteButton.Click += HandleDeleteClicked;
        FileText.TextChanged += HandleGenericControlChange;
    }

    protected override void RemoveEventHandlers()
    {
        base.RemoveEventHandlers();
        CloseButton.Click -= HandleCloseClicked;
        BrowseButton.Click -= HandleFileClicked;
        DeleteButton.Click -= HandleDeleteClicked;
        FileText.TextChanged -= HandleGenericControlChange;
    }

    protected override void SetPreLoadState()
    {
        base.SetPreLoadState();
        FileText.Enabled = false;
        BrowseButton.Enabled = false;
        CloseButton.Enabled = false;
        DeleteButton.Enabled = false;
        Application.DoEvents();
    }

    protected override void SetPostLoadState()
    {
        FileText.Enabled = true;
        BrowseButton.Enabled = true;
        CloseButton.Enabled = true;
        DeleteButton.Enabled = true;
        ResumeLayout();
        base.SetPostLoadState();
    }

    protected override void SetDisplayState()
    {
        DeleteButton.Enabled = File.Exists(FileText.Text);
        StatusLabel.Visible = false;
        StatusPrg.Visible = false;
    }

    private void HandleCloseClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        base.DialogResult = DialogResult.Cancel;
        Close();
    }

    private void HandleFileClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        OpenFileDialog dialog = DialogProvider.CreateOpenFileDialog();
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

    private void HandleDeleteClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        StatusLabel.Text = "Preparing...";
        StatusPrg.Value = 0;
        StatusPrg.Visible = true;
        StatusLabel.Visible = true;
        PerformSecureDeleteAsync(FileText.Text);
    }

    private void HandleDeleteStatusUpdate(object? sender, ProgressUpdateEventArgs e)
    {
        ContinueInMainThread(delegate
        {
            StatusLabel.Text = e.Status;
            StatusPrg.Value = e.PercentDone;
        });
    }

    private void UpdateStatus(string status, int percentDone)
    {
        ContinueInMainThread(delegate
        {
            StatusLabel.Text = status;
            StatusPrg.Value = percentDone;
        });
    }

    private async Task PerformSecureDeleteAsync(string fileName)
    {
        SecureDeleteClient client = new SecureDeleteClient();
        client.StatusUpdate += HandleDeleteStatusUpdate;
        await client.SecureDeleteFileAsync(fileName);
        client.StatusUpdate -= HandleDeleteStatusUpdate;
        client.Dispose();
        ContinueInMainThread(delegate
        {
            SetPostLoadState();
            SetState();
        });
    }
}
