namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Provides the signature definition for entities that represent known Identity Provider
/// login data.
/// </summary>
/// <seealso cref="IEntity" />
public interface IIdentityProviderEntity : IWebAccountEntity
{
    #region Properties    
    /// <summary>
    /// Gets or sets the type of the provider.
    /// </summary>
    /// <value>
    /// An <see cref="IdentityProviderType"/> enumerated value indicating the type of the 
    /// identity provider.
    /// </value>
    IdentityProviderType ProviderType { get; set; }

    /// <summary>
    /// Gets or sets the name of the identity provider.
    /// </summary>
    /// <value>
    /// A string containing the name of the identity provider.
    /// </value>
    string? ProviderTypeName { get; set; }
    #endregion
}
