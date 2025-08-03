using Adaptive.Intelligence.Shared;

namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Represents a user-defined category.
/// </summary>
/// <seealso cref="DisposableObjectBase" />
public sealed class UserCategoryEntity : EntityBase, IUserCategoryEntity 
{
    #region Private Member Declarations
    /// <summary>
    /// The ID value.
    /// </summary>
    private Guid? _id;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCategoryEntity"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public UserCategoryEntity()
    {
        _id = Guid.NewGuid();
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCategoryEntity"/> class.
    /// </summary>
    /// <param name="name">
    /// A string containing the name of the category.
    /// </param>
    public UserCategoryEntity(string name) : this()
    {
        Name = name;
    }
    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
    /// <b>false</b> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        _id = null;
        base.Dispose(disposing);
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
            if (_id == null || _id == Guid.Empty)
            {
                return Guid.Empty;
            }
            else
                return _id.Value;
        }
        set => _id = value;
    }
    #endregion
}
