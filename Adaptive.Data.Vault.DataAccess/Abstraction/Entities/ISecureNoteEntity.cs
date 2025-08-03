namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Provides the signature definition for entities that contain secure text data.
/// </summary>
/// <seealso cref="IEntity" />
public interface ISecureNoteEntity : IEntity
{
    #region Properties
    /// <summary>
    /// Gets or sets the content of the secure note.
    /// </summary>
    /// <value>
    /// A string containing the content of the secure note.
    /// </value>
    string? SecureContent { get; set; }
    #endregion
}
