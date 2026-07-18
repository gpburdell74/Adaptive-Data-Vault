using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.IO;
using Adaptive.Intelligence.Shared.Logging;
using Adaptive.Intelligence.Shared.Security;
using Adaptive.Intelligence.Shared.UI;
using System.Text;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a dialog for decoding secure messages. This dialog allows users to input encrypted text, authenticate using credentials, and view the decrypted message 
/// if the authentication is successful. It is designed to facilitate the secure handling of sensitive information within the application.
/// </summary>
public partial class DecodeSecureMessageDialog : AdaptiveDialogBase
{
    #region Private Member Declarations
    private string? _original;
    private string? _decrypted;
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
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources;
    /// <c>false</c> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        if (!base.IsDisposed && disposing)
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
    /// Attaches event handlers to UI controls to handle user interactions.
    /// </summary>
    /// <remarks>Overrides the base implementation to connect specific event handlers for file selection,
    /// preparation, and cancellation actions. This method is typically called during initialization to ensure the UI
    /// responds to user input appropriately.</remarks>
    protected override void AssignEventHandlers()
    {
        base.AssignEventHandlers();
        FileButton.Click += HandleFileButtonClicked;
        PrepareButton.Click += HandlePrepareClicked;
        ButtonBar.CancelClicked += HandleCancelClicked;
    }

    /// <summary>
    /// Removes event handlers attached by this instance to UI controls. Overrides the base implementation to detach
    /// handlers specific to this class.
    /// </summary>
    /// <remarks>Call this method to ensure that event handlers are properly detached and resources are
    /// released when the control is disposed or no longer in use. This helps prevent memory leaks and unintended
    /// behavior caused by lingering event subscriptions.</remarks>
    protected override void RemoveEventHandlers()
    {
        base.RemoveEventHandlers();
        FileButton.Click -= HandleFileButtonClicked;
        PrepareButton.Click -= HandlePrepareClicked;
        ButtonBar.CancelClicked -= HandleCancelClicked;
    }

    /// <summary>
    /// Prepares the control for loading by disabling interactive UI elements and suspending layout updates.
    /// </summary>
    /// <remarks>Call this method before initiating a load operation to prevent user interaction and improve
    /// performance during the loading process. This method overrides the base implementation to ensure all relevant
    /// controls are disabled and layout changes are suspended.</remarks>
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
    /// Sets the enabled state of UI controls after the form has loaded, based on the current decryption state.
    /// </summary>
    /// <remarks>This method is typically called after loading data to update the UI. Controls related to file
    /// selection and preparation are enabled or disabled depending on whether decryption has already
    /// occurred.</remarks>
    protected override void SetPostLoadState()
    {
        bool decryptionDone = _decrypted != null;
        FileButton.Enabled = true;
        PrepareButton.Enabled = !decryptionDone;
        ButtonBar.Enabled = true;
        MessageText.Enabled = !decryptionDone;
        ResumeLayout();
        base.SetPostLoadState();
    }

    /// <summary>
    /// Updates the enabled state of UI controls based on the current decryption status.
    /// </summary>
    /// <remarks>This method enables or disables related UI elements to reflect whether decryption has been
    /// completed. It is typically called after operations that may change the decryption state to ensure the interface
    /// remains consistent with the application's workflow.</remarks>
    protected override void SetDisplayState()
    {
        bool decryptionDone = _decrypted != null;
        FileButton.Enabled = true;
        PrepareButton.Enabled = !decryptionDone;
        ButtonBar.Enabled = true;
        MessageText.Enabled = !decryptionDone;
    }
    #endregion

    #region Private Event Handlers

    /// <summary>
    /// Handles the event when the Cancel button is clicked, closing the dialog with a Cancel result.
    /// </summary>
    /// <param name="sender">The source of the event, typically the Cancel button.</param>
    /// <param name="e">An object that contains the event data.</param>
    private void HandleCancelClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        base.DialogResult = DialogResult.Cancel;
        Close();
    }

    /// <summary>
    /// Handles the click event for the file selection button, allowing the user to open a file and process its contents
    /// based on the current credentials.
    /// </summary>
    /// <remarks>If valid credentials are present, this method displays a file open dialog, reads the selected
    /// file, and prompts the user for authentication. The file contents are decrypted and displayed if authentication
    /// succeeds; otherwise, the original state is restored. The method updates the UI state before and after file
    /// processing.</remarks>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An EventArgs object that contains the event data.</param>
    private void HandleFileButtonClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        if (_credentials != null)
        {
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
                    _credentials?.Dispose();
                    _credentials = loginDialog.Credentials?.Clone();
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
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles th eevent when the Prepare button is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandlePrepareClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        DecryptMessage();
        SetPostLoadState();
        SetState();
    }
    #endregion


    #region Private Methods / Functions
    private void DecryptMessage()
    {
        _original = MessageText.Text;
        _credentials ??= new InMemoryCredentials();
        MessageLoginDialog dialog = new MessageLoginDialog(_credentials);
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            _credentials?.Dispose();
            _credentials = dialog.Credentials?.Clone();
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

    private string? DecryptText()
    {
        string? newText = null;
        if (_credentials != null)
        {
            byte[]? encryptedData;
            try
            {
                encryptedData = Convert.FromBase64String(MessageText.Text);
            }
            catch (Exception ex)
            {
                ShowError("Invalid Text Data", "This text content is not in the form of a Base-64 string.  The data cannot be processed.");
                ExceptionLog.LogException(ex);
                encryptedData = null;
            }
            if (encryptedData != null && _credentials != null && _credentials.UserId != null && _credentials.Password != null && _credentials.PIN != null)
            {
                SuperCrypt crypt = new SuperCrypt(_credentials.UserId, _credentials.Password, _credentials.PIN.Value);
                if (crypt != null)
                {
                    byte[]? decryptedData = crypt.Decrypt(encryptedData);
                    if (decryptedData != null)
                    {
                        Array.Clear(encryptedData, 0, encryptedData.Length);
                        crypt.Dispose();
                        if (decryptedData != null)
                        {
                            newText = Encoding.GetEncoding("UTF-8").GetString(decryptedData);
                            Array.Clear(decryptedData, 0, decryptedData.Length);
                        }
                    }
                }
            }
        }
        return newText;
    }

    /// <summary>
    /// Reads the content of the specified file as a text file.
    /// </summary>
    /// <param name="fileName">
    /// A string containing the fully-qualified path and name of the file.
    /// </param>
    /// <returns>
    /// A string containing the entire content of the file. If the file cannot be read, an empty string is returned.
    /// </returns>
    private static string ReadTextFile(string fileName)
    {
        string? text = SafeIO.ReadTextFromFile(fileName, isUnicode: false);
        if (text == null)
        {
            return string.Empty;
        }
        return text;
    }

    #endregion

}
