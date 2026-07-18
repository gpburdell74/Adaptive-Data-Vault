using Adaptive.Data.Vault.OS;
using Adaptive.Intelligence.Shared.Logging;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a dialog for displaying information about an identity provider, including its name, URL, user ID, and password. The dialog allows users to view and copy this information securely.
/// </summary>
public partial class IdentityProviderInfoDialog : AdaptiveDialogBase
{
    #region Private Member Declarations
    /// <summary>
    /// The identity provider being edited.
    /// </summary>
    private IdentityProvider? _provider;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProviderInfoDialog"/> class.
    /// </summary>
    public IdentityProviderInfoDialog()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="IdentityProviderInfoDialog"/> and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing"></param>
    protected override void Dispose(bool disposing)
    {
        if (!base.IsDisposed && disposing)
        {
            components?.Dispose();
        }
        _provider = null;
        components = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the <see cref="IdentityProvider"/> instance being edited.
    /// </summary>
    /// <value>
    /// An <see cref="IdentityProvider"/> instance, or <b>null</b>.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IdentityProvider? IdProvider
    {
        get
        {
            return _provider;
        }
        set
        {
            _provider = value;
            Invalidate();
        }
    }
    #endregion

    #region Protected Method Overrides
    /// <summary>
    /// Initializes the data content of the dialog based on the current <see cref="IdentityProvider"/> instance. 
    /// </summary>
    protected override void InitializeDataContent()
    {
        Header.Text = _provider?.Name;
        AddressLabel.Text = _provider?.Url;
        if (_provider != null)
        {
            if (_provider.UserId != null)
            {
                UserIdLabel.Text = new string('*', _provider.UserId.Length);
            }
            if (_provider.Password != null)
            {
                PasswordLabel.Text = new string('*', _provider.Password.Length);
            }
        }
    }

    /// <summary>
    /// Assigns event handlers to the dialog's controls for handling user interactions, such as clicking buttons or labels.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        AddressLabel.Click += HandleAddressClicked;
        ShowUserIdButton.Click += HandleShowUserIdClicked;
        ShowPasswordButton.Click += HandleShowPasswordClicked;
        CopyPasswordButton.Click += HandleCopyPasswordClicked;
        CopyUrlButton.Click += HandleCopyUrlClicked;
        CopyUserIdButton.Click += HandleCopyUserIdClicked;
        CloseButton.Click += HandleCloseClicked;
    }

    /// <summary>
    /// 
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        AddressLabel.Click -= HandleAddressClicked;
        ShowUserIdButton.Click -= HandleShowUserIdClicked;
        ShowPasswordButton.Click -= HandleShowPasswordClicked;
        CopyPasswordButton.Click -= HandleCopyPasswordClicked;
        CopyUrlButton.Click -= HandleCopyUrlClicked;
        CopyUserIdButton.Click -= HandleCopyUserIdClicked;
        CloseButton.Click -= HandleCloseClicked;
    }

    /// <summary>
    /// Sets the dialog's state to a pre-load state, disabling user interactions and changing the cursor to indicate that a process is ongoing.
    /// </summary>
    protected override void SetPreLoadState()
    {
        Cursor = Cursors.WaitCursor;
        ShowUserIdButton.Enabled = false;
        ShowPasswordButton.Enabled = false;
        CopyPasswordButton.Enabled = false;
        CopyUrlButton.Enabled = false;
        CopyUserIdButton.Enabled = false;
        CloseButton.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    /// <summary>
    /// Sets the dialog to a UI state when not busy.
    /// </summary>
    protected override void SetPostLoadState()
    {
        Cursor = Cursors.Default;
        ShowUserIdButton.Enabled = true;
        ShowPasswordButton.Enabled = true;
        CopyPasswordButton.Enabled = true;
        CopyUrlButton.Enabled = true;
        CopyUserIdButton.Enabled = true;
        CloseButton.Enabled = true;
        ResumeLayout();
        Invalidate();
        Application.DoEvents();
    }
    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles th event when the address label is clicked, opening the identity provider's URL in the default web browser.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleAddressClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && _provider.Url != null)
        {
            OSUtilities.StartBrowser(_provider.Url);
        }
        SetPostLoadState();
    }

    /// <summary>
    /// Handles the event when the "Show User ID" button is clicked, toggling the visibility of the user ID in the dialog.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleShowUserIdClicked(object? sender, EventArgs e)
    {
        ShowUserIdButton.Checked = !ShowUserIdButton.Checked;
        if (_provider != null && _provider.UserId != null)
        {
            if (ShowUserIdButton.Checked)
            {
                UserIdLabel.Text = _provider.UserId;
            }
            else
            {
                UserIdLabel.Text = new string('*', _provider.UserId.Length);
            }
        }
    }

    /// <summary>
    /// Handles the event when the "Show Password" button is clicked, toggling the visibility of the password in the dialog.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleShowPasswordClicked(object? sender, EventArgs e)
    {
        ShowPasswordButton.Checked = !ShowPasswordButton.Checked;
        if (_provider != null && _provider.Password != null)
        {
            if (ShowPasswordButton.Checked)
            {
                PasswordLabel.Text = _provider.Password;
            }
            else
            {
                PasswordLabel.Text = new string('*', _provider.Password.Length);
            }
        }
        Invalidate();
    }

    /// <summary>
    /// Handles the event when the "Copy Password" button is clicked, copying the password to the clipboard.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleCopyPasswordClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && _provider.Password != null)
        {
            try
            {
                Clipboard.SetText(_provider.Password);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }
        SetPostLoadState();
    }

    /// <summary>
    /// Handles the event when the "Copy URL" button is clicked, copying the identity provider's URL to the clipboard.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleCopyUrlClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && _provider.Url != null)
        {
            try
            {
                Clipboard.SetText(_provider.Url);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }
        SetPostLoadState();
    }

    /// <summary>
    /// Handles the event when the "Copy User ID" button is clicked, copying the user ID to the clipboard.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleCopyUserIdClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && _provider.UserId != null)
        {
            try
            {
                Clipboard.SetText(_provider.UserId);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }
        SetPostLoadState();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleCloseClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        Application.DoEvents();
        base.DialogResult = DialogResult.OK;
        Close();
    }
    #endregion
}
