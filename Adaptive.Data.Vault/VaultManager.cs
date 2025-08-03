using Adaptive.Data.Vault.DataAccess.IO;
using Adaptive.Data.Vault.Entities;
using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.Security;

namespace Adaptive.Data.Vault;

/// <summary>
/// Provides the implementation for managing the business objects and data for a user 
/// data vault.
/// </summary>
/// <seealso cref="DisposableObjectBase" />
public sealed class VaultManager : DisposableObjectBase
{
    #region Private Member Declarations
    /// <summary>
    /// The data file to manage.
    /// </summary>
    private VaultFile? _file;

    /// <summary>
    /// The data content.
    /// </summary>
    private IEntityDataSet? _data;

    /// <summary>
    /// The path and file name.
    /// </summary>
    private string? _fileName;

    /// <summary>
    /// The user ID value.
    /// </summary>
    private SecureString? _userId;

    /// <summary>
    /// The password value.
    /// </summary>
    private SecureString? _password;

    /// <summary>
    /// The user PIN number.
    /// </summary>
    private SecureInt32? _pin;

    private WebAccountCollection? _webAccounts;
    private SecureNoteCollection? _secureNotes;
    private UserCategoryCollection? _categories;
    private IdentityProviderCollection? _idProviders;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="VaultManager"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public VaultManager()
    {
        _data = new VaultEntityDataSet();
        _categories = new UserCategoryCollection();
        _idProviders = new IdentityProviderCollection();
        _webAccounts = new WebAccountCollection();
        _secureNotes = new SecureNoteCollection();
    }

    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
    /// <b>false</b> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
            Close();

        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets the reference to the list of defined categories.
    /// </summary>
    /// <value>
    /// A <see cref="UserCategoryCollection"/> instance, or <b>null</b>.
    /// </value>
    public UserCategoryCollection? Categories => _categories;

    /// <summary>
    /// Gets the reference to the list of identity providers.
    /// </summary>
    /// <value>
    /// A <see cref="IdentityProviderCollection"/> instance, or <b>null</b>.
    /// </value>
    public IdentityProviderCollection? IdProviders => _idProviders;

    /// <summary>
    /// Gets the reference to the list of secure notes.
    /// </summary>
    /// <value>
    /// A <see cref="SecureNoteCollection"/> instance, or <b>null</b>.
    /// </value>
    public SecureNoteCollection? SecureNotes => _secureNotes;

    /// <summary>
    /// Gets the reference to the list of web accounts.
    /// </summary>
    /// <value>
    /// A <see cref="WebAccountCollection"/> instance, or <b>null</b>.
    /// </value>
    public WebAccountCollection? WebAccounts => _webAccounts;
    #endregion

    #region Public Methods / Functions
    /// <summary>
    /// Closes the current file and removes all security information.
    /// </summary>
    public void Close()
    {
        Save();
        _file?.Dispose();
        _data?.Dispose();
        _userId?.Dispose();
        _password?.Dispose();
        _pin?.Dispose();
        _webAccounts?.Clear();
        _secureNotes?.Clear();
        _idProviders?.Clear();
        _categories?.Clear();

        _file = null;
        _data = null;
        _userId = null;
        _password = null;
        _pin = null;
        _fileName = null;
        _webAccounts = null;
        _secureNotes = null;
        _idProviders = null;
        _categories = null;
    }

    /// <summary>
    /// Gets the list of web accounts for the specified category.
    /// </summary>
    /// <param name="categoryId">
    /// A <see cref="Guid"/> containing the category ID, or <b>null</b> for the 
    /// uncategorized items.
    /// </param>
    /// <returns>
    /// A <see cref="WebAccountCollection"/> containing the filtered list.
    /// </returns>
    public WebAccountCollection GetWebAccountsForCategory(Guid? categoryId)
    {
        WebAccountCollection list = new WebAccountCollection();

        if (categoryId == null)
            categoryId = Guid.Empty;

        if (_webAccounts != null)
            list.AddRange(_webAccounts.GetForCategory(categoryId));

        return list;
    }

    /// <summary>
    /// Gets the list of secure notes for the specified category.
    /// </summary>
    /// <param name="categoryId">
    /// A <see cref="Guid"/> containing the category ID, or <b>null</b> for the 
    /// uncategorized items.
    /// </param>
    /// <returns>
    /// A <see cref="SecureNoteCollection"/> containing the filtered list.
    /// </returns>
    public SecureNoteCollection GetSecureNotesForCategory(Guid? categoryId)
    {
        SecureNoteCollection list = new SecureNoteCollection();

        if (categoryId == null)
            categoryId = Guid.Empty;

        if (_secureNotes != null)
            list.AddRange(_secureNotes.GetForCategory(categoryId));

        return list;
    }

    /// <summary>
    /// Gets the list of identity providers for the specified category.
    /// </summary>
    /// <param name="categoryId">
    /// A <see cref="Guid"/> containing the category ID, or <b>null</b> for the 
    /// uncategorized items.
    /// </param>
    /// <returns>
    /// An <see cref="IdentityProviderCollection"/> containing the filtered list.
    /// </returns>
    public IdentityProviderCollection GetIdentityProvidersForCategory(Guid? categoryId)
    {
        IdentityProviderCollection list = new IdentityProviderCollection();

        if (categoryId == null)
            categoryId = Guid.Empty;

        if (_idProviders != null)
            list.AddRange(_idProviders.GetForCategory(categoryId));

        return list;
    }

    /// <summary>
    /// Loads the content from the specified file.
    /// </summary>
    /// <param name="fileName">
    /// A string containing the fully-qualified path and name of the file to be loaded.
    /// </param>
    /// <param name="userId">
    /// A string containing the user ID / name for cryptographic operations.
    /// </param>
    /// <param name="password">
    /// A string containing the password for cryptographic operations.
    /// </param>
    /// <param name="pin">
    /// An integer containing the PIN value for cryptographic operations.
    /// </param>
    public bool Load(string fileName, string userId, string password, int pin)
    {
        bool loadSucess = false;

        // Clear previous data.
        Close();

        _fileName = fileName;
        _userId = new Intelligence.Shared.Security.SecureString(userId);
        _password = new Intelligence.Shared.Security.SecureString(password);
        _pin = new SecureInt32(pin);

        _file = new VaultFile();
        _data = _file.LoadDataSet(fileName, userId, password, pin);

        if (_data == null)
            Close();
        else
        {
            _categories = new UserCategoryCollection(_data.Categories!);
            _idProviders = new IdentityProviderCollection(_data.IdProviders!);
            _webAccounts = new WebAccountCollection(_data.WebAccounts!);
            _secureNotes = new SecureNoteCollection(_data.SecureNotes!);
            loadSucess = true;
        }
        return loadSucess;
    }

    /// <summary>
    /// Saves the current content to a known file, if values have been previously set and
    /// content is loaded.
    /// </summary>
    public void Save()
    {
        if (CanSaveData())
        {
            PerformSave();
        }
    }
    /// <summary>
    /// Saves the content to the specified file.
    /// </summary>
    /// <param name="fileName">
    /// A string containing the fully-qualified path and name of the file to be loaded.
    /// </param>
    /// <param name="userId">
    /// A string containing the user ID / name for cryptographic operations.
    /// </param>
    /// <param name="password">
    /// A string containing the password for cryptographic operations.
    /// </param>
    /// <param name="pin">
    /// An integer containing the PIN value for cryptographic operations.
    /// </param>
    public void Save(string fileName, string userId, string password, int pin)
    {
        // Clear old settings and re-create credentials.
        _userId?.Dispose();
        _password?.Dispose();
        _pin?.Dispose();

        _fileName = fileName;
        _userId = new SecureString(userId);
        _password = new SecureString(password);
        _pin = new SecureInt32(pin);
        _file ??= new VaultFile();

        Save();
    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Determines whether the current data content can be saved.
    /// </summary>
    /// <returns>
    ///   <c>true</c> if tall objects are in a state that will allow them to save the data; otherwise, <c>false</c>.
    /// </returns>
    private bool CanSaveData()
    {
        return (_file != null && _data != null &&
                _userId != null && _password != null &&
                _pin != null && !string.IsNullOrEmpty(_fileName) &&
                _webAccounts != null && _categories != null &&
                _idProviders != null && _secureNotes != null);
    }

    /// <summary>
    /// Performs the process of saving the data.
    /// </summary>
    private void PerformSave()
    {
        // Create the data set to save.
        _data?.Dispose();
        _data = new VaultEntityDataSet(
            _categories!.ToEntityList(),
            _idProviders!.ToEntityList(),
            _secureNotes!.ToEntityList(),
            _webAccounts!.ToEntityList());

        if (_file == null)
            _file = new VaultFile();

        _file.SaveDataSet(_data, _fileName!, _userId!.Value!, _password!.Value!, _pin!.Value);
    }
    #endregion

}
