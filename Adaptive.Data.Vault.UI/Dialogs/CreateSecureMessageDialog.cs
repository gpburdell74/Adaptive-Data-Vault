using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.Security;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

public partial class CreateSecureMessageDialog : AdaptiveDialogBase
{
    #region Private Member Declarations

    private string? _original;
    private string? _prepared;
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

    protected override void Dispose(bool disposing)
    {
        if (!base.IsDisposed && disposing)
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

    protected override void AssignEventHandlers()
    {
        base.AssignEventHandlers();
        PrepareButton.Click += HandlePrepareClicked;
        ButtonBar.SaveClicked += HandleSaveClicked;
        ButtonBar.CancelClicked += HandleCancelClicked;
    }

    protected override void RemoveEventHandlers()
    {
        base.RemoveEventHandlers();
        PrepareButton.Click -= HandlePrepareClicked;
        ButtonBar.SaveClicked -= HandleSaveClicked;
        ButtonBar.CancelClicked -= HandleCancelClicked;
    }

    protected override void SetPreLoadState()
    {
        base.SetPreLoadState();
        PrepareButton.Enabled = false;
        ButtonBar.Enabled = false;
        MessageText.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    protected override void SetPostLoadState()
    {
        PrepareButton.Enabled = true;
        ButtonBar.Enabled = true;
        if (_prepared == null)
        {
            MessageText.Enabled = true;
        }
        ResumeLayout();
        base.SetPostLoadState();
    }

    protected override void SetDisplayState()
    {
        ButtonBar.SaveEnabled = _prepared != null;
    }

    private void HandleCancelClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        base.DialogResult = DialogResult.Cancel;
        Close();
    }

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

    private void HandleSaveClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        Clipboard.SetText(MessageText.Text);
        SetPostLoadState();
        SetState();
    }

    private void PrepareMessage()
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

    private string? EncryptAndPrepareText()
    {
        string newText = null;
        if (_credentials != null)
        {
            SuperCrypt crypt = new SuperCrypt(_credentials.UserId, _credentials.Password, _credentials.PIN.Value);
            byte[] encryptedData = crypt.Encrypt(_original);
            crypt.Dispose();
            if (encryptedData != null)
            {
                newText = Convert.ToBase64String(encryptedData);
                Array.Clear(encryptedData, 0, encryptedData.Length);
            }
        }
        return newText;
    }
}
