using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault;

/// <summary>
/// Contains and manages a list of <see cref="UserCategory"/> instances.
/// </summary>
/// <seealso cref="List{T}" />
public sealed class UserCategoryCollection : VaultBusinessCollectionBase<UserCategory, IUserCategoryEntity>
{
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCategoryCollection"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public UserCategoryCollection()
    {
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCategoryCollection"/> class.
    /// </summary>
    /// <param name="sourceList">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> list of <typeparamref name="E" /> entities used to
    /// create the business object(s) and populate the list.</param>
    public UserCategoryCollection(IEnumerable<IUserCategoryEntity> sourceList) 
        : base()
    {
        foreach (IUserCategoryEntity entity in sourceList)
        {
            UserCategory category = new UserCategory(entity);
            Add(category);
        }
    }
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
        UserCategory category = new UserCategory
        {
            Id = Guid.NewGuid(),
            Name = name
        };
        Add(category);
    }
    #endregion

}
