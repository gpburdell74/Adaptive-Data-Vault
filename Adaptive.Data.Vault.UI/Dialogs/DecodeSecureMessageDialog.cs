using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.IO;
using Adaptive.Intelligence.Shared.Logging;
using Adaptive.Intelligence.Shared.Security;
using Adaptive.Intelligence.Shared.UI;
using System.Text;

namespace Adaptive.Data.Vault.UI;


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
    protected override void AssignEventHandlers()
    {
        base.AssignEventHandlers();
        FileButton.Click += HandleFileButtonClicked;
        PrepareButton.Click += HandlePrepareClicked;
        ButtonBar.CancelClicked += HandleCancelClicked;
    }

    protected override void RemoveEventHandlers()
    {
        base.RemoveEventHandlers();
        FileButton.Click -= HandleFileButtonClicked;
        PrepareButton.Click -= HandlePrepareClicked;
        ButtonBar.CancelClicked -= HandleCancelClicked;
    }

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
    private void HandleCancelClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        base.DialogResult = DialogResult.Cancel;
        Close();
    }

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
        if (_credentials == null)
        {
            _credentials = new InMemoryCredentials();
        }
        MessageLoginDialog dialog = new MessageLoginDialog(_credentials);
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
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

    private string? DecryptText()
    {
        string newText = null;
        if (_credentials != null)
        {
            byte[] encryptedData = null;
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
            if (encryptedData != null)
            {
                SuperCrypt crypt = new SuperCrypt(_credentials.UserId, _credentials.Password, _credentials.PIN.Value);
                byte[] decryptedData = crypt.Decrypt(encryptedData);
                Array.Clear(encryptedData, 0, encryptedData.Length);
                crypt.Dispose();
                if (decryptedData != null)
                {
                    newText = Encoding.GetEncoding("UTF-8").GetString(decryptedData);
                    Array.Clear(decryptedData, 0, decryptedData.Length);
                }
            }
        }
        return newText;
    }

    private string ReadTextFile(string fileName)
    {
        string text = SafeIO.ReadTextFromFile(fileName, isUnicode: false);
        if (text == null)
        {
            return string.Empty;
        }
        return text;
    }

    #endregion

}
