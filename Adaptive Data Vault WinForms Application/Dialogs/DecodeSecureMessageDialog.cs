using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.IO;
using Adaptive.Intelligence.Shared.Logging;
using Adaptive.Intelligence.Shared.Security;
using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a dialog for decrypting and viewing an encrypted message.
/// </summary>
/// <seealso cref="AdaptiveDialogBase" />
public partial class DecodeSecureMessageDialog : AdaptiveDialogBase
{
    #region Private Member Declarations
    /// <summary>
    /// The original text.
    /// </summary>
    private string? _original;

    /// <summary>
    /// The decrypted text.
    /// </summary>
    private string? _decrypted;

    /// <summary>
    /// The credentials.
    /// </summary>
    private InMemoryCredentials? _credentials;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="DecodeSecureMessageDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public DecodeSecureMessageDialog()
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
        _decrypted = null;
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

        FileButton.Click += HandleFileButtonClicked;
        PrepareButton.Click += HandlePrepareClicked;
        ButtonBar.CancelClicked += HandleCancelClicked;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        base.RemoveEventHandlers();

        FileButton.Click -= HandleFileButtonClicked;
        PrepareButton.Click -= HandlePrepareClicked;
        ButtonBar.CancelClicked -= HandleCancelClicked;
    }

    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    protected override void SetPreLoadState()
    {
        base.SetPreLoadState();

        FileButton.Enabled = false;
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
        bool decryptionDone = (_decrypted != null);

        FileButton.Enabled = true;
        PrepareButton.Enabled = !decryptionDone;
        ButtonBar.Enabled = true;

        MessageText.Enabled = !decryptionDone;

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
        bool decryptionDone = (_decrypted != null);

        FileButton.Enabled = true;
        PrepareButton.Enabled = !decryptionDone;
        ButtonBar.Enabled = true;

        MessageText.Enabled = !decryptionDone;

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
    /// Handles the event when the Open File button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleFileButtonClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        OpenFileDialog dialog = DialogProvider.CreateOpenFileDialog();
        dialog.Filter = "All Files (*.*)|*.*";
        dialog.Title = "Open A File";
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            string fileName = dialog.FileName;
            MessageText.Text = ReadTextFile(fileName);

            MessageLoginDialog loginDialog = new MessageLoginDialog(_credentials);
            DialogResult loginResult = loginDialog.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                // Replace the credential.
                _credentials?.Dispose();
                _credentials = loginDialog.Credentials.Clone();

                _decrypted = DecryptText();
                MessageText.Text = _decrypted;
            }
            else
            {
                MessageText.Text = _original;
                _original = null;
                _decrypted = null;
                _credentials?.Dispose();
            }
            loginDialog.Dispose();

        }
        dialog.Dispose();

        SetPostLoadState();
        SetState();
    }
    /// <summary>
    /// Handles the Event when the Prepare or "Clear Text" button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandlePrepareClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        DecryptMessage();
        SetPostLoadState();
        SetState();
    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Displays the credentials dialog to the user and encrypts the message content.
    /// </summary>
    private void DecryptMessage()
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

            _decrypted = DecryptText();
            MessageText.Text = _decrypted;
        }
        else
        {
            MessageText.Text = _original;
            _original = null;
            _decrypted = null;
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
    private string? DecryptText()
    {
        string? newText = null;

        if (_credentials != null)
        {
            // Try to translate from base-64; if not valid, skip the rest.
            byte[]? encryptedData = null;
            try
            {
                encryptedData = Convert.FromBase64String(MessageText.Text);
            }
            catch(Exception ex)
            {
                ShowError("Invalid Text Data", "This text content is not in the form of a Base-64 string.  The data cannot be processed.");
                ExceptionLog.LogException(ex);
                encryptedData = null;
            }

            if (encryptedData != null)
            {
                // Encrypt the message and transform it into a base-64 string so it
                // is viewable and safe for e-mail transmission.
                SuperCrypt crypt = new SuperCrypt(
                    _credentials.UserId!,
                    _credentials.Password!,
                    _credentials.PIN!.Value);

                // Translate to a byte array.
                byte[]? decryptedData = crypt.Decrypt(encryptedData);
                Array.Clear(encryptedData, 0, encryptedData.Length);
                crypt.Dispose();

                if (decryptedData != null)
                {
                    newText = System.Text.ASCIIEncoding.GetEncoding("UTF-8").GetString(decryptedData);
                    Array.Clear(decryptedData, 0, decryptedData.Length);
                }
            }
        }

        return newText;
    }
    /// <summary>
    /// Reads the text file.
    /// </summary>
    /// <param name="fileName">Name of the file.</param>
    /// <returns></returns>
    private string ReadTextFile(string fileName)
    {
        string? text = SafeIO.ReadTextFromFile(fileName, false);
        if (text == null)
            return string.Empty;
        else
            return text;
    }
    #endregion

}