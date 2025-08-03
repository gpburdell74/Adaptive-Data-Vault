using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.Security;

namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Provides the base definition for the data entities in the application.
/// </summary>
/// <seealso cref="DisposableObjectBase" />
public abstract class EntityBase : DisposableObjectBase, IEntity
{
    #region Private Methods / Functions
    /// <summary>
    /// The name of the instance.
    /// </summary>
    private string? _name;
    /// <summary>
    /// The description of the instance.
    /// </summary>
    private string? _description;
    /// <summary>
    /// The secure string container for the user ID value.
    /// </summary>
    private SecureString? _userId;
    /// <summary>
    /// The secure string container for the password value.
    /// </summary>
    private SecureString? _password;
    /// <summary>
    /// The category ID value.
    /// </summary>
    private Guid? _categoryId;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityBase"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    protected EntityBase()
    {
        CategoryId = Guid.Empty;
    }
    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
    /// <b>false</b> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            _userId?.Dispose();
            _password?.Dispose();
        }

        _name = null;
        _description = null;
        _userId = null;
        _password = null;
        _categoryId = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the category Id value.
    /// </summary>
    /// <value>
    /// A <see cref="Guid"/> containing the ID of the category the item belongs to,
    /// or <b>null</b> if the item is not categorized.
    /// </value>
    public Guid? CategoryId { get => _categoryId; set => _categoryId = value; }

    /// <summary>
    /// Gets or sets the description text.
    /// </summary>
    /// <value>
    /// A string containing the description of the entry.
    /// </value>
    public string? Description { get => _description; set => _description = value; }

    /// <summary>
    /// Gets or sets the name for the item.
    /// </summary>
    /// <value>
    /// A string containing the item name, or <b>null</b>.
    /// </value>
    public virtual string? Name { get => _name; set => _name = value; }
    /// <summary>
    /// Gets or sets the password value for the item.
    /// </summary>
    /// <value>
    /// A string containing the item value, or <b>null</b>.
    /// </value>
    public virtual string? Password
    {
        get { return _password?.Value; }
        set
        {
            if (value == null)
            {
                _password?.Dispose();
                _password = null;
            }
            else
            {
                if (_password == null)
                    _password = new SecureString(value);
                else
                {
                    _password.ClearStorage();
                    _password.Value = value;
                }
            }
        }
    }
    /// <summary>
    /// Gets or sets the User ID / email / login name value for the item.
    /// </summary>
    /// <value>
    /// A string containing the user identity value, or <b>null</b>.
    /// </value>
    public virtual string? UserId
    {
        get { return _userId?.Value; }
        set
        {
            if (value == null)
            {
                _userId?.Dispose();
                _userId = null;
            }
            else
            {
                if (_userId == null)
                    _userId = new SecureString(value);
                else
                {
                    _userId.ClearStorage();
                    _userId.Value = value;
                }
            }
        }
    }
    #endregion
}
