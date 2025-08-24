using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a control for editing the content of an Identity Provider account.
/// </summary>
/// <seealso cref="AdaptiveControlBase" />
public partial class EditIdentityProviderControl : AdaptiveControlBase
{
    #region Private Member Declarations
    /// <summary>
    /// The ID provider instance.
    /// </summary>
    private IdentityProvider? _provider;
    #endregion

    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="EditIdentityProviderControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public EditIdentityProviderControl()
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
    /// Gets or sets the reference to the identity provider instance to edit.
    /// </summary>
    /// <value>
    /// The <see cref="IdentityProvider"/> instance to edit.
    /// </value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IdentityProvider? IdProvider
    {
        get
        {
            SaveControlValues();
            return _provider;
        }
        set
        {
            _provider = value;
            SetControlValues();
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
        if (IdProviderTypeList.Items.Count == 0)
        {
            IdProviderTypeList.Items.Add("None");
            IdProviderTypeList.Items.Add("Microsoft");
            IdProviderTypeList.Items.Add("Google");
            IdProviderTypeList.Items.Add("Facebook");
            IdProviderTypeList.Items.Add("Apple");
            IdProviderTypeList.Items.Add("Corporate, Custom, or Other");
            IdProviderTypeList.SelectedIndex = 0;
        }
    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Saves the control values to the business object.
    /// </summary>
    private void SaveControlValues()
    {
        if (_provider != null)
        {
            _provider.ProviderType = (IdentityProviderType)IdProviderTypeList.SelectedIndex;
            _provider.ProviderTypeName = IdentityProviderNameFactory.GetProviderTypeName(_provider.ProviderType);
            _provider.Name = NameText.Text;
            _provider.Description = DescText.Text;
            _provider.Url = UrlText.Text;
            _provider.UserId = UserIdText.Text;
            _provider.Password = PasswordText.Text;
            _provider.UsesMFA = MfaCheck.Checked;

            if (_provider.UsesMFA)
            {
                _provider.MFADescription = MfaTypeText.Text;
                _provider.MFADeviceAddress = MfaAddressText.Text;
            }
            else
            {
                _provider.MFADescription = string.Empty;
                _provider.MFADeviceAddress = string.Empty;
            }
        }

    }

    /// <summary>
    /// Sets the content of the control from the business object.
    /// </summary>
    private void SetControlValues()
    {
        if (_provider != null)
        {
            if (IdProviderTypeList.Items.Count == 0)
                InitializeDataContent();

            IdProviderTypeList.SelectedIndex = (int)_provider.ProviderType;
            NameText.Text = _provider.Name;
            DescText.Text = _provider.Description;
            UrlText.Text = _provider.Url;
            UserIdText.Text = _provider.UserId;
            PasswordText.Text = _provider.Password;
            MfaCheck.Checked = _provider.UsesMFA;

            if (_provider.UsesMFA)
            {
                MfaTypeText.Text = _provider.MFADescription;
                MfaAddressText.Text = _provider.MFADeviceAddress;
            }
        }
    }
    #endregion
}
