using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a dialog for providing the credentials needed to encrypt or decrypt a 
/// secure message.
/// </summary>
/// <seealso cref="Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase" />
public partial class MessageLoginDialog : AdaptiveDialogBase
{
    #region Private Member Declarations
    /// <summary>
    /// The credentials instance.
    /// </summary>
    private InMemoryCredentials? _credentials;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="LoginDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public MessageLoginDialog()
    {
        InitializeComponent();
        _credentials = new InMemoryCredentials();
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="LoginDialog"/> class.
    /// </summary>
    /// <param name="credentials">
    /// The <see cref="InMemoryCredentials"/> instance to use.
    /// </param>
    public MessageLoginDialog(InMemoryCredentials credentials)
    {
        InitializeComponent();
        if (credentials != null)
            _credentials = credentials.Clone();
    }
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            _credentials?.Dispose();
            components.Dispose();
        }

        _credentials = null;
        components = null;
        base.Dispose(disposing);
    }
    #endregion


    #region Public Properties
    /// <summary>
    /// Gets the reference to the credentials in memory.
    /// </summary>
    /// <value>
    /// An <see cref="InMemoryCredentials"/> instance containing the login parameters.
    /// </value>
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public InMemoryCredentials? Credentials
    {
        get => _credentials;
    }
    #endregion

    #region Protected Method Overrides		
    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        ButtonBar.SaveClicked += HandleOkClicked;
        ButtonBar.CancelClicked += HandleCloseClicked;

        NameText.TextChanged += HandleGenericControlChange;
        PasswordText.TextChanged += HandleGenericControlChange;
    }
    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        ButtonBar.SaveClicked -= HandleOkClicked;
        ButtonBar.CancelClicked -= HandleCloseClicked;

        NameText.TextChanged -= HandleGenericControlChange;
        PasswordText.TextChanged -= HandleGenericControlChange;
    }

    /// <summary>
    /// Initializes the control and dialog state according to the form data.
    /// </summary>
    protected override void InitializeDataContent()
    {
        if (_credentials == null)
            _credentials = new InMemoryCredentials();
        
        if (_credentials != null)
        {
            NameText.Text = _credentials.UserId;
            PasswordText.Text = _credentials.Password;
            PinText.Text = _credentials.PIN.ToString();
        }
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
        ErrorProvider.Clear();

        ButtonBar.SaveEnabled = false; 

        if (NameText.Text.Length == 0)
            ErrorProvider.SetError(NameText, "You must enter a name value here.");
        else if (PasswordText.Text.Length == 0)
            ErrorProvider.SetError(PasswordText, "You must enter the password for the file here.");
        else
            ButtonBar.SaveEnabled = true;
    }
    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    protected override void SetPreLoadState()
    {
        Cursor = Cursors.WaitCursor;
        ButtonBar.SaveEnabled = false;
        ButtonBar.CancelEnabled = false;
        NameText.Enabled = false;
        PasswordText.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }
    /// <summary>
    /// Sets the state of the UI controls after the data content is loaded.
    /// </summary>
    protected override void SetPostLoadState()
    {
        Cursor = Cursors.Default;
        ButtonBar.SaveEnabled = true;
        ButtonBar.CancelEnabled = true;
        NameText.Enabled = true;
        PasswordText.Enabled = true;
        ResumeLayout();
    }
    #endregion

    #region Private Event Handlers		
    /// <summary>
    /// Handles the event when the OK button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleOkClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_credentials != null)
        {
            DialogResult = DialogResult.OK;
            _credentials.UserId = NameText.Text;
            _credentials.Password = PasswordText.Text;
            _credentials.PIN = Convert.ToInt32(PinText.Text);
        }
        else
        {
            DialogResult = DialogResult.Cancel;
        }
        Close();
    }
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
    #endregion
}
