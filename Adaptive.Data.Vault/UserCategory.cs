using Adaptive.Data.Vault.Entities;
using Adaptive.Intelligence.Shared;

namespace Adaptive.Data.Vault;

/// <summary>
/// Represents and manages a user-defined category.
/// </summary>
/// <seealso cref="DisposableObjectBase" />
/// <seealso cref="IUserCategory" />
public sealed class UserCategory : VaultBusinessBase<IUserCategoryEntity>
{
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCategory"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public UserCategory() : base()
    {

    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserCategory"/> class.
    /// </summary>
    /// <param name="entity">The entity to use for the data store.</param>
    public UserCategory(IUserCategoryEntity entity) 
        : base((UserCategoryEntity)entity)
    {
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the unique ID value for the instance.
    /// </summary>
    /// <value>
    /// An integer specifying the unique ID value.
    /// </value>
    public Guid Id
    {
        get
        {
            if (Entity == null)
                return Guid.Empty;
            else
                return Entity.Id;
        }
        set
        {
            if (Entity != null)
                Entity.Id = value;
        }
    }

    /// <summary>
    /// Gets or sets the name of the category.
    /// </summary>
    /// <value>
    /// A string containing the category name.
    /// </value>
    public string? Name
    {
        get => Entity?.Name;
        set
        {
            if (Entity != null)
                Entity.Name = value;
        }
    }
    #endregion

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        return Id.ToString() + " - " + Name;
    }
}
