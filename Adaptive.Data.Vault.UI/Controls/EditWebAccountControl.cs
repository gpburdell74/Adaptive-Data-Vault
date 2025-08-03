using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a control for editing the content of a Web account.
/// </summary>
/// <seealso cref="AdaptiveControlBase" />
public partial class EditWebAccountControl : AdaptiveControlBase
{
    #region Private Member Declarations
    /// <summary>
    /// The account instance.
    /// </summary>
    private WebAccount? _account;
    #endregion

    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="EditWebAccountControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public EditWebAccountControl()
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

        _account = null;
        components = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the web account instance to edit.
    /// </summary>
    /// <value>
    /// The <see cref="WebAccount"/> instance to edit.
    /// </value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public WebAccount? Account
    {
        get
        {
            SaveControlValues();
            return _account;
        }
        set
        {
            _account = value;
            SetControlValues();
            Invalidate();
        }
    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Saves the control values to the business object.
    /// </summary>
    private void SaveControlValues()
    {
        if (_account != null)
        {
            _account.Name = NameText.Text;
            _account.Description = DescText.Text;
            _account.Url = UrlText.Text;
            _account.UserId = UserIdText.Text;
            _account.Password = PasswordText.Text;
            _account.UsesMFA = MfaCheck.Checked;

            if (_account.UsesMFA)
            {
                _account.MFADescription = MfaTypeText.Text;
                _account.MFADeviceAddress = MfaAddressText.Text;
            }
            else
            {
                _account.MFADescription = string.Empty;
                _account.MFADeviceAddress = string.Empty;
            }
        }

    }

    /// <summary>
    /// Sets the content of the control from the business object.
    /// </summary>
    private void SetControlValues()
    {
        if (_account != null)
        {
            NameText.Text = _account.Name;
            DescText.Text = _account.Description;
            UrlText.Text = _account.Url;
            UserIdText.Text = _account.UserId;
            PasswordText.Text = _account.Password;
            MfaCheck.Checked = _account.UsesMFA;

            if (_account.UsesMFA)
            {
                MfaTypeText.Text = _account.MFADescription;
                MfaAddressText.Text = _account.MFADeviceAddress;
            }
        }
    }
    #endregion
}
