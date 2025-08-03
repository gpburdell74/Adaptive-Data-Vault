using Adaptive.Data.Vault.Abstraction;
using Adaptive.Data.Vault.Entities;
using Adaptive.Intelligence.Shared;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Adaptive.Data.Vault;

/// <summary>
/// Provides the base implementation for business objects.
/// </summary>
/// <typeparam name="T">
/// The data type of the underlying entity containing the instance's data.
/// </typeparam>
/// <seealso cref="DisposableObjectBase" />
/// <seealso cref="IEntity"/>
public abstract class VaultBusinessBase<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T> : DisposableObjectBase
    where T : IEntity
{
    #region Private Member Declarations
    /// <summary>
    /// The related entity instance with the data.
    /// </summary>
    private T? _entity;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="VaultBusinessBase{T}"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    protected VaultBusinessBase()
    {
        _entity = VaultActivator.CreateInstance<T>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VaultBusinessBase{T}"/> class.
    /// </summary>
    /// <param name="entity">
    /// The entity to use for the data store.
    /// </param>
    protected VaultBusinessBase(T entity)
    {
        _entity = entity;
    }

    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
    /// <b>false</b> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
            _entity?.Dispose();

        _entity = default;
        base.Dispose(disposing);
    }
    #endregion

    #region Protected Properties
    /// <summary>
    /// Gets or sets the category Id value.
    /// </summary>
    /// <value>
    /// A <see cref="Guid"/> containing the ID of the category the item belongs to,
    /// or <b>null</b> if the item is not categorized.
    /// </value>
    public Guid? CategoryId
    {
        get
        {
            // Read the category ID from th entity, if possible.
            Guid? value = null;
            if (_entity != null)
                value = _entity.CategoryId;

            // Translate null values to empty GUIDs for searching purposes.
            if (value == null)
                value = Guid.Empty;

            return value;
        }
        set
        {
            if (_entity != null)
                _entity.CategoryId = value;
        }
    }

    /// <summary>
    /// Gets the reference to the underlying entity instance.
    /// </summary>
    /// <value>
    /// The instance of <typeparamref name="T"/> containing the object's data.
    /// /// </value>
    public T? Entity => _entity;
    #endregion

    #region Protected Methods / Functions
    /// <summary>
    /// Sets the reference to the underlying entity instance to use.
    /// </summary>
    /// <param name="entity">
    /// A <typeparamref name="T"/> instance to use as the data store.
    /// The entity.</param>
    protected void SetEntity(T entity)
    {
        _entity = entity;
    }
    #endregion
}