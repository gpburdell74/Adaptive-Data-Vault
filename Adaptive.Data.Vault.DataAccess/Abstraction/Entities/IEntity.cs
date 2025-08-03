namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Provides the signature definition for a base entity instance.
/// </summary>
/// <seealso cref="DisposableObjectBase" />
public interface IEntity : IDisposable
{
    #region Properties
    /// <summary>
    /// Gets or sets the category Id value.
    /// </summary>
    /// <value>
    /// A <see cref="Guid"/> containing the ID of the category the item belongs to,
    /// or <b>null</b> if the item is not categorized.
    /// </value>
    Guid? CategoryId { get; set; }

    /// <summary>
    /// Gets or sets the description text.
    /// </summary>
    /// <value>
    /// A string containing the description of the entry.
    /// </value>
    string? Description { get; set; }

    /// <summary>
    /// Gets or sets the name for the item.
    /// </summary>
    /// <value>
    /// A string containing the item name, or <b>null</b>.
    /// </value>
    string? Name { get; set; }

    /// <summary>
    /// Gets or sets the password value for the item.
    /// </summary>
    /// <value>
    /// A string containing the item value, or <b>null</b>.
    /// </value>
    string? Password { get; set; }

    /// <summary>
    /// Gets or sets the User ID / email / login name value for the item.
    /// </summary>
    /// <value>
    /// A string containing the user identity value, or <b>null</b>.
    /// </value>
    public string? UserId { get; set; }
    #endregion
}