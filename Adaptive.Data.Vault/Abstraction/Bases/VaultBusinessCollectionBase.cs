using Adaptive.Data.Vault.Abstraction;
using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault;

/// <summary>
/// Provides the base definition for collections and lists that contain business objects.
/// </summary>
/// <typeparam name="T">
/// The data type of the business object in the collection.
/// </typeparam>
/// <typeparam name="E">
/// The data type of the underlying data entity for the business object.
/// </typeparam>
/// <seealso cref="List{T}" />
public abstract class VaultBusinessCollectionBase<T, E> : List<T>
    where T : VaultBusinessBase<E>
    where E : IEntity
{
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="VaultBusinessCollectionBase{T, E}"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    protected VaultBusinessCollectionBase() : base()
    {
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="VaultBusinessCollectionBase{T, E}"/> class.
    /// </summary>
    /// <param name="sourceList">
    /// The <see cref="IEnumerable{T}"/> list of <typeparamref name="E"/> entities used to 
    /// create the business object(s) and populate the list.
    /// </param>
    protected VaultBusinessCollectionBase(IEnumerable<E> sourceList) : base(sourceList.Count())
    {
        Type dataType = typeof(T);

        // For each entity, create an new wrapper business object and add it to the collection.
        foreach (E entity in sourceList)
        {
            T? businessObject = (T?)VaultActivator.CreateInstanceForEntity<E>(entity);
            if (businessObject != null)
                Add(businessObject);
        }
    }
    #endregion

    #region Public Methods / Functions    
    /// <summary>
    /// Gets the list of items in the collection that have the matching category ID.
    /// </summary>
    /// <param name="categoryId">
    /// A <see cref="Guid"/> containing the category ID value, or <b>null</b> for the
    /// uncategorized items.
    /// </param>
    /// <returns>
    /// A <see cref="List{T}"/> containing the results.
    /// </returns>
    public List<T> GetForCategory(Guid? categoryId)
    {
        return this.Where(x => x.CategoryId == categoryId).ToList();
    }
    /// <summary>
    /// Returns a list of <typeparamref name="E"/> entity instances for all the business objects
    /// contained in the collection.
    /// </summary>
    /// <remarks>
    /// This is used to translate the current collection into a list of writable entities.
    /// </remarks>
    /// <returns>
    /// A <see cref="List{T}"/> of <typeparamref name="E"/> instances.
    /// </returns>
    public virtual List<E> ToEntityList()
    {
        List<E> returnList = new List<E>();
        foreach(T item in this)
        {
            if (item.Entity != null)
                returnList.Add(item.Entity);
        }
        return returnList;
    }
    #endregion
}
