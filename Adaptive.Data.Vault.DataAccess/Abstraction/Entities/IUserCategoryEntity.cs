namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Provides the signature definition for a user-defined category of items.
/// </summary>
/// <seealso cref="IDisposable" />
public interface IUserCategoryEntity : IEntity
{
    #region Properties
    /// <summary>
    /// Gets or sets the unique ID value for the instance.
    /// </summary>
    /// <value>
    /// An integer specifying the unique ID value.
    /// </value>
    public Guid Id { get; set; }
    #endregion
}


