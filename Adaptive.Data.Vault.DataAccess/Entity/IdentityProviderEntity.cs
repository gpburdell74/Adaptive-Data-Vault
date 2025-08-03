namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Represents and manages an entry for an identity provider account.
/// </summary>
/// <seealso cref="EntityBase" />
/// <seealso cref="IIdentityProviderEntity" />
public sealed class IdentityProviderEntity : WebAccountEntity, IIdentityProviderEntity
{
    #region Private Methods / Functions
    /// <summary>
    /// The provider name.
    /// </summary>
    private string? _providerName;
    /// <summary>
    /// The known identity provider type.
    /// </summary>
    private IdentityProviderType _providerType = IdentityProviderType.None;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProviderEntity"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public IdentityProviderEntity() : base()
    {
    }
    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
    /// <b>false</b> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        _providerName = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the type of the provider.
    /// </summary>
    /// <value>
    /// An <see cref="IdentityProviderType" /> enumerated value indicating the type of the
    /// identity provider.
    /// </value>
    public IdentityProviderType ProviderType { get => _providerType; set => _providerType = value; }

    /// <summary>
    /// Gets or sets the name of the identity provider.
    /// </summary>
    /// <value>
    /// A string containing the name of the identity provider.
    /// </value>
    public string? ProviderTypeName { get => _providerName; set => _providerName = value; }

    #endregion
}
