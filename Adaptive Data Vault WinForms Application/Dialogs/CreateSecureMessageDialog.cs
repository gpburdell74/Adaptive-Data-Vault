using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.Security;
using Adaptive.Intelligence.Shared.UI;
using System.Net;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a dialog for creating an encrypted message.
/// </summary>
/// <seealso cref="AdaptiveDialogBase" />
public partial class CreateSecureMessageDialog : AdaptiveDialogBase
{
    #region Private Member Declarations
    /// <summary>
    /// The original text.
    /// </summary>
    private string? _original;

    /// <summary>
    /// The encrypted text.
    /// </summary>
    private string? _prepared;

    /// <summary>
    /// The credentials.
    /// </summary>
    private InMemoryCredentials? _credentials;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSecureMessageDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public CreateSecureMessageDialog()
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
            _credentials?.Dispose();
            components?.Dispose();
        }

        _credentials = null;
        _original = null;
        _prepared = null;
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

        PrepareButton.Click += HandlePrepareClicked;
        ButtonBar.SaveClicked += HandleSaveClicked;
        ButtonBar.CancelClicked += HandleCancelClicked;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        base.RemoveEventHandlers();

        PrepareButton.Click -= HandlePrepareClicked;
        ButtonBar.SaveClicked -= HandleSaveClicked;
        ButtonBar.CancelClicked -= HandleCancelClicked;
    }

    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    protected override void SetPreLoadState()
    {
        base.SetPreLoadState();

        PrepareButton.Enabled = false;
        ButtonBar.Enabled = false;
        MessageText.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    /// <summary>
    /// Sets the state of the UI controls after the data content is loaded.
    /// </summary>
    protected override void SetPostLoadState()
    {
        PrepareButton.Enabled = true;
        ButtonBar.Enabled = true;

        if (_prepared == null)
            MessageText.Enabled = true;

        ResumeLayout();
        base.SetPostLoadState();
    }

    /// <summary>
    /// When implemented in a derived class, sets the display state for the controls on the dialog based on
    /// current conditions.
    /// </summary>
    /// <remarks>
    /// This is called by <see cref="SetState" /> after <see cref="SetSecurityState" /> is called.
    /// </remarks>
    protected override void SetDisplayState()
    {
        ButtonBar.SaveEnabled = _prepared != null;
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

    /// <summary>
    /// Handles the Event when the Prepare or "Clear Text" button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandlePrepareClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        if (_prepared == null)
        {
            PrepareMessage();
            MessageText.Text = _prepared;
            MessageText.Enabled = false;
            PrepareButton.Text = "Show Clear Text";
        }
        else
        {
            MessageText.Text = _original;
            _original = null;
            _prepared = null;
            MessageText.Enabled = true;
            PrepareButton.Text = "Prepare Message";
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Copy button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleSaveClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        Clipboard.SetText(MessageText.Text);

        SetPostLoadState();
        SetState();
    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Displays the credentials dialog to the user and encrypts the message content.
    /// </summary>
    private void PrepareMessage()
    {
        _original = MessageText.Text;

        if (_credentials == null)
            _credentials = new InMemoryCredentials();

        MessageLoginDialog dialog = new MessageLoginDialog(_credentials);
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            // Replace the credential.
            _credentials?.Dispose();
            _credentials = dialog.Credentials.Clone();

            _prepared = EncryptAndPrepareText();
            MessageText.Text = _prepared;
        }
        else
        {
            MessageText.Text = _original;
            _original = null;
            _prepared = null;
            _credentials?.Dispose();
        }
        dialog.Dispose();
    }

    /// <summary>
    /// Encrypts text message with the user-specified credentials.
    /// </summary>
    /// <returns>
    /// A string containing the base-64 representation of the encrypted content.
    /// </returns>
    private string? EncryptAndPrepareText()
    {
        string? newText = null;

        if (_credentials != null)
        {
            // Encrypt the message and transform it into a base-64 string so it
            // is viewable and safe for e-mail transmission.
            SuperCrypt crypt = new SuperCrypt(
                _credentials.UserId,
                _credentials.Password,
                _credentials.PIN.Value);

            byte[]? encryptedData = crypt.Encrypt(_original);
            crypt.Dispose();

            if (encryptedData != null)
            {
                newText = Convert.ToBase64String(encryptedData!);
                Array.Clear(encryptedData, 0, encryptedData.Length);
            }
        }

        return newText;
    }
    #endregion

}