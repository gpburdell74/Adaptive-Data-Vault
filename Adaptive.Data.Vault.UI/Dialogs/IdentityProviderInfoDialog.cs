using Adaptive.Data.Vault.OS;
using Adaptive.Intelligence.Shared.Logging;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;
/// <summary>
/// Provides the dialog for showing the detail information for an identity provider entry.
/// </summary>
/// <seealso cref="AdaptiveDialogBase" />

public partial class IdentityProviderInfoDialog : AdaptiveDialogBase
{
    #region Private Member Declarations
    /// <summary>
    /// The account instance to show.
    /// </summary>
    private IdentityProvider? _provider;

    /// <summary>
    /// The user identifier checked flag.
    /// </summary>
    private bool _userIdChecked;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProviderInfoDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public IdentityProviderInfoDialog()
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

        _provider = null;
        components = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the identity provider instance.
    /// </summary>
    /// <value>
    /// The <see cref="IdentityProvider"/> instance being displayed.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IdentityProvider? IdProvider
    {
        get => _provider;
        set
        {
            _provider = value;
            Invalidate();
        }
    }
    #endregion

    #region Protected Method Overrides
    /// <summary>
    /// Initializes the control and dialog state according to the form data.
    /// </summary>
    protected override void InitializeDataContent()
    {
        Header.Text = _provider?.Name;
        AddressLabel.Text = _provider?.Url;
        if (_provider != null)
        {
            if (_provider.UserId != null)
                UserIdLabel.Text = new string('*', _provider.UserId.Length);

            if (_provider.Password != null)
                PasswordLabel.Text = new string('*', _provider.Password.Length);
        }
    }

    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
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
    /// Removes the event handlers for the controls on the dialog.
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
    /// Sets the state of the UI controls before the data content is loaded.
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
    /// Sets the state of the UI controls after the data content is loaded.
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
    /// Handles the event when the address label is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleAddressClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        if (_provider != null && _provider.Url != null)
            OSUtilities.StartBrowser(_provider.Url);

        SetPostLoadState();
    }

    /// <summary>
    /// Handles the event when the show/hide user ID button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleShowUserIdClicked(object? sender, EventArgs e)
    {
        ShowUserIdButton.Checked = !ShowUserIdButton.Checked;
        if (_provider != null && _provider.UserId != null)
        {
            if (ShowUserIdButton.Checked)
                UserIdLabel.Text = _provider.UserId;
            else
                UserIdLabel.Text = new string('*', _provider.UserId.Length);
        }

    }

    /// <summary>
    /// Handles the event when the show/hide password button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleShowPasswordClicked(object? sender, EventArgs e)
    {
        ShowPasswordButton.Checked = !ShowPasswordButton.Checked;
        if (_provider != null && _provider.Password != null)
        {
            if (ShowPasswordButton.Checked)
                PasswordLabel.Text = _provider.Password;
            else
                PasswordLabel.Text = new string('*', _provider.Password.Length);
        }
        Invalidate();
    }

    /// <summary>
    /// Handles the event when the Copy password button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
    /// Handles the event when the Copy URL button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
    /// Handles the event when the Copy User ID button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
    /// Handles the event when the Close button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleCloseClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        Application.DoEvents();
        DialogResult = DialogResult.OK;
        Close();
    }
    #endregion
}
