using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault;

/// <summary>
/// Represents and manages secure text data.
/// </summary>
/// <seealso cref="VaultBusinessBase{T}" />
/// <seealso cref="ISecureNote" />
public sealed class SecureNote : VaultBusinessBase<ISecureNoteEntity>
{
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="SecureNote"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public SecureNote() : base()
    {
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="SecureNote"/> class.
    /// </summary>
    /// <param name="entity">The entity to use for the data store.</param>
    public SecureNote(ISecureNoteEntity entity) 
        : base((SecureNoteEntity)entity)
    {

    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the name of the entry.
    /// </summary>
    /// <value>
    /// A string containing the name value.
    /// </value>
    public string? Name
    {
        get
        {
            if (Entity != null)
                return Entity.Name;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.Name = value;
        }
    }

    /// <summary>
    /// Gets or sets the content of the secure note.
    /// </summary>
    /// <value>
    /// A string containing the content of the secure note.
    /// </value>
    public string? SecureContent
    {
        get
        {
            if (Entity != null)
                return Entity.SecureContent;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.SecureContent = value;
        }
    }
    #endregion
}
