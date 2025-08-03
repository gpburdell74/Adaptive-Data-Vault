namespace Adaptive.Data.Vault;

/// <summary>
/// Lists the types of known identity providers that are stored.
/// </summary>
public enum IdentityProviderType
{
    /// <summary>
    /// Indicates no identity service is specified.
    /// </summary>
    None = 0,
    /// <summary>
    /// Indicates the Microsoft Identity Provider.
    /// </summary>
    Microsoft = 1,
    /// <summary>
    /// Indicates the Google Identity Provider.
    /// </summary>
    Google = 2,
    /// <summary>
    /// Indicates the Facebook Identity Provider.
    /// </summary>
    Facebook = 3,
    /// <summary>
    /// Indicates the Apple Identity Provider.
    /// </summary>
    Apple = 4,
    /// <summary>
    /// Indicates another corporate identity provider.
    /// </summary>
    CorporateCustomOrOther = 5,
}
