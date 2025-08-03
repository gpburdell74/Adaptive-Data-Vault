using Adaptive.Intelligence.Shared;

namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Provides the container for all the raw entity data.
/// </summary>
/// <seealso cref="DisposableObjectBase" />
public sealed class VaultEntityDataSet : DisposableObjectBase, IEntityDataSet
{
    #region Private Member Declarations
    /// <summary>
    /// The categories list.
    /// </summary>
    private List<IUserCategoryEntity>? _categories;
    /// <summary>
    /// The web accounts list.
    /// </summary>
    private List<IWebAccountEntity>? _webAccounts;
    /// <summary>
    /// The identifier providers list.
    /// </summary>
    private List<IIdentityProviderEntity>? _idProviders;
    /// <summary>
    /// The secure notes list.
    /// </summary>
    private List<ISecureNoteEntity>? _secureNotes;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="VaultEntityDataSet"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public VaultEntityDataSet()
    {
        _categories = new List<IUserCategoryEntity>();
        _webAccounts = new List<IWebAccountEntity>();
        _idProviders = new List<IIdentityProviderEntity>();
        _secureNotes = new List<ISecureNoteEntity>();
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="VaultEntityDataSet"/> class.
    /// </summary>
    /// <param name="categories">
    /// The reference to the list of <see cref="IUserCategoryEntity"/> instances.
    /// </param>
    /// <param name="webAccounts">
    /// The reference to the list of <see cref="IWebAccountEntity"/> instances.
    /// </param>
    /// <param name="idProviders">
    /// The reference to the list of <see cref="IIdentityProviderEntity"/> instances.
    /// </param>
    /// <param name="secureNotes">
    /// The reference to the list of <see cref="ISecureNoteEntity"/> instances.
    /// </param>
    public VaultEntityDataSet(
        List<IUserCategoryEntity>? categories,
        List<IIdentityProviderEntity>? idProviders,
        List<ISecureNoteEntity>? secureNotes,
        List<IWebAccountEntity>? webAccounts)
    {
        _categories = categories;
        _idProviders = idProviders;
        _secureNotes = secureNotes;
        _webAccounts = webAccounts;
    }

    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
    /// <b>false</b> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            _categories?.Clear();
            _webAccounts?.Clear();
            _idProviders?.Clear();
            _secureNotes?.Clear();

        }

        _categories = null;
        _webAccounts = null;
        _idProviders = null;
        _secureNotes = null;

        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets the reference to the list of category entities.
    /// </summary>
    /// <value>
    /// A <see cref="List{T}"/> of <see cref="IUserCategoryEntity"/> instances.
    /// </value>
    public List<IUserCategoryEntity>? Categories => _categories;
    /// <summary>
    /// Gets the reference to the list of identity provider entities.
    /// </summary>
    /// <value>
    /// A <see cref="List{T}"/> of <see cref="IIdentityProviderEntity"/> instances.
    /// </value>
    public List<IIdentityProviderEntity>? IdProviders => _idProviders;
    /// <summary>
    /// Gets the reference to the list of secure note entities.
    /// </summary>
    /// <value>
    /// A <see cref="List{T}"/> of <see cref="ISecureNoteEntity"/> instances.
    /// </value>
    public List<ISecureNoteEntity>? SecureNotes => _secureNotes;
    /// <summary>
    /// Gets the reference to the list of web account entities.
    /// </summary>
    /// <value>
    /// A <see cref="List{T}"/> of <see cref="IWebAccountEntity"/> instances.
    /// </value>
    public List<IWebAccountEntity>? WebAccounts => _webAccounts;
    #endregion

    #region Public Methods / Functions
    /// <summary>
    /// Adds the category with the specified name.
    /// </summary>
    /// <param name="name">
    /// A string containing the name of the category to add.
    /// </param>
    public void AddCategory(string name)
    {
        UserCategoryEntity category = new UserCategoryEntity
        {
            Id = Guid.NewGuid(),
            Name = name
        };
        _categories?.Add(category);
    }

    /// <summary>
    /// Adds the identity provider record.
    /// </summary>
    /// <param name="providerType">
    /// An <see cref="IdentityProviderType"/> enumerated value indicating the provider type.
    /// </param>
    /// <param name="name">
    /// A string containing the name for the entry.
    /// </param>
    /// <param name="description">
    /// A string containing a description of the entry.
    /// </param>
    /// <param name="url">
    /// A string specifying the URL for the related website.
    /// </param>
    /// <param name="userId">
    /// A string containing the user ID or login name for the website.
    /// </param>
    /// <param name="password">
    /// A string containing the password for the website.
    /// </param>
    /// <param name="usesMfa">
    /// A value indicating whether multi-factor authentication (MFA) is active for this login.
    /// </param>
    /// <param name="mfaDescription">
    /// A description for the MFA type - such as phone or email or authenticator app.
    /// </param>
    /// <param name="mfaAddress">
    /// A string containing a phone number, email address, or other address value for MFA
    /// for this account.
    /// </param>
    public void AddIdProvider(IdentityProviderType providerType, string name, string description, string url, string userId, string password,
            bool usesMfa = false, string mfaDescription = "", string mfaAddress = "")
    {
        IdentityProviderEntity provider = new IdentityProviderEntity
        {
            MFADescription = mfaDescription,
            MFADeviceAddress = mfaAddress,
            Name = name,
            Password = password,
            UserId = userId,
            UsesMFA = usesMfa,
            ProviderType = providerType,
            ProviderTypeName = GetProviderTypeName(providerType),
            Url = url
        };

        _idProviders?.Add(provider);
    }

    /// <summary>
    /// Adds the secure note.
    /// </summary>
    /// <param name="name">
    /// A string containing the name for the entry.
    /// </param>
    /// <param name="description">
    /// A string containing the description for the entry.
    /// </param>
    /// <param name="content">
    /// A string containing the content to be secured.
    /// </param>
    public void AddSecureNote(string name, string description, string content)
    {
        SecureNoteEntity entity = new SecureNoteEntity
        {
            Name = name,
            SecureContent = content,
        };
        _secureNotes?.Add(entity);
    }

    /// <summary>
    /// Adds the web account record.
    /// </summary>
    /// <param name="name">
    /// A string containing the name for the entry.
    /// </param>
    /// <param name="description">
    /// A string containing a description of the entry.
    /// </param>
    /// <param name="url">
    /// A string specifying the URL for the related website.
    /// </param>
    /// <param name="userId">
    /// A string containing the user ID or login name for the website.
    /// </param>
    /// <param name="password">
    /// A string containing the password for the website.
    /// </param>
    /// <param name="usesMfa">
    /// A value indicating whether multi-factor authentication (MFA) is active for this login.
    /// </param>
    /// <param name="mfaDescription">
    /// A description for the MFA type - such as phone or email or authenticator app.
    /// </param>
    /// <param name="mfaAddress">
    /// A string containing a phone number, email address, or other address value for MFA
    /// for this account.
    /// </param>
    public void AddWebAccount(string name, string description, string url, string userId, string password,
        bool usesMfa = false, string mfaDescription = "", string mfaAddress = "")
    {
        WebAccountEntity entity = new WebAccountEntity
        {
            Name = name,
            Url = url,
            UserId = userId,
            Password = password,
            MFADescription = mfaDescription,
            MFADeviceAddress = mfaAddress,
            UsesMFA = usesMfa
        };
        _webAccounts?.Add(entity);
    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Gets the default name value for the provider type.
    /// </summary>
    /// <param name="providerType">
    /// An <see cref="IdentityProviderType"/> enumerated value indicating the provider type.
    /// </param>
    /// <returns>
    /// A string containing the name text.
    /// </returns>
    private string GetProviderTypeName(IdentityProviderType providerType)
    {
        string name = "";
        switch(providerType)
        {
            case IdentityProviderType.Apple:
                name = "Apple";
                break;

            case IdentityProviderType.Microsoft:
                name = "Microsoft";
                break;

            case IdentityProviderType.Facebook:
                name = "Facebook";
                break;

            case IdentityProviderType.CorporateCustomOrOther:
                name = "Corporate, Custom, or Other";
                break;

            case IdentityProviderType.Google:
                name = "Google";
                break;

            default:
                name = "Unknown";
                break;
        }
        return name;
    }
    #endregion
}
