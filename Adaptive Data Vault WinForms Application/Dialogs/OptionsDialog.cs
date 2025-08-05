using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

public partial class OptionsDialog : AdaptiveDialogBase
{
    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="OptionsDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public OptionsDialog()
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
    protected override void AssignEventHandlers()
    {
        base.AssignEventHandlers();
        ButtonBar.CancelClicked += HandleCancelClicked;
    }
    protected override void RemoveEventHandlers()
    {
        base.RemoveEventHandlers();
        ButtonBar.CancelClicked -= HandleCancelClicked;
    }
    #endregion

    #region Private Event Handlers    
    /// <summary>
    /// Handles the event when the Cancel button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleCancelClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        DialogResult = DialogResult.Cancel;
        Close();
    }
    #endregion

}
