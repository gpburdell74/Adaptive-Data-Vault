namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Represents and manages an entity that contains information for a website account or login.
/// </summary>
/// <seealso cref="EntityBase" />
/// <seealso cref="IWebAccountEntity"/>
public class WebAccountEntity : EntityBase, IWebAccountEntity
{
    #region Private Methods / Functions
    /// <summary>
    /// The string containing the URL of the website and/or login page.
    /// </summary>
    private string? _url;
    /// <summary>
    /// The MFA/2FS flag.
    /// </summary>
    private bool _usesMfa;
    /// <summary>
    /// The MFA/2FS description - indicating email, phone, or an authenticator app.
    /// </summary>
    private string? _mfaDesc;
    /// <summary>
    /// The email address or phone number used in the MFA process.
    /// </summary>
    private string? _mfaValue;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="WebAccountEntity"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public WebAccountEntity()
    {
    }
    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
    /// <b>false</b> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        _mfaDesc = null;
        _mfaValue = null;
        _url = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties        
    /// <summary>
    /// Gets or sets the string containing the URL of the website and/or login page.
    /// </summary>
    /// <value>
    /// A string containing the URL used to access the website and/or login page.
    /// </value>
    public string? Url {  get => _url; set => _url = value; }

    /// <summary>
    /// Gets or sets a value indicating whether MFA/2FA is turned on for the account.
    /// </summary>
    /// <value>
    ///   <b>true</b> if multi-factor authentication is used; otherwise, <b>false</b>.
    /// </value>
    public bool UsesMFA { get => _usesMfa; set => _usesMfa = value; }

    /// <summary>
    /// Gets or sets the user-defined MFA/2FA description.
    /// </summary>
    /// <value>
    /// A string containing the description.
    /// </value>
    public string? MFADescription { get => _mfaDesc; set => _mfaDesc = value; }

    /// <summary>
    /// Gets or sets the email address or phone number used in the MFA process.
    /// </summary>
    /// <value>
    /// The phone number, email address, or other such address used in the MFA process.
    /// </value>
    public string? MFADeviceAddress { get => _mfaValue; set => _mfaValue = value; }
    #endregion
}