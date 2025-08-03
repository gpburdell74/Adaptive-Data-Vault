namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Provides the signature definition for container implementations to contain all the raw entity data.
/// </summary>
/// <seealso cref="IDisposable" />
public interface IEntityDataSet : IDisposable
{
    #region Properties
    /// <summary>
    /// Gets the reference to the list of category entities.
    /// </summary>
    /// <value>
    /// A <see cref="List{T}"/> of <see cref="IUserCategoryEntity"/> instances.
    /// </value>
    List<IUserCategoryEntity>? Categories { get; }

    /// <summary>
    /// Gets the reference to the list of identity provider entities.
    /// </summary>
    /// <value>
    /// A <see cref="List{T}"/> of <see cref="IIdentityProviderEntity"/> instances.
    /// </value>
    List<IIdentityProviderEntity>? IdProviders { get; }

    /// <summary>
    /// Gets the reference to the list of secure note entities.
    /// </summary>
    /// <value>
    /// A <see cref="List{T}"/> of <see cref="ISecureNoteEntity"/> instances.
    /// </value>
    List<ISecureNoteEntity>? SecureNotes { get; }

    /// <summary>
    /// Gets the reference to the list of web account entities.
    /// </summary>
    /// <value>
    /// A <see cref="List{T}"/> of <see cref="IWebAccountEntity"/> instances.
    /// </value>
    List<IWebAccountEntity>? WebAccounts { get; }
    #endregion

    #region Methods / Functions
    /// <summary>
    /// Adds the category with the specified name.
    /// </summary>
    /// <param name="name">
    /// A string containing the name of the category to add.
    /// </param>
    void AddCategory(string name);

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
    void AddIdProvider(
        IdentityProviderType providerType,
        string name, string description,
        string url, string userId,
        string password,
        bool usesMfa = false,
        string mfaDescription = "",
        string mfaAddress = "");

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
    void AddSecureNote(string name, string description, string content);

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
    void AddWebAccount(
        string name,
        string description,
        string url,
        string userId,
        string password,
        bool usesMfa = false,
        string mfaDescription = "",
        string mfaAddress = "");
    #endregion

}
