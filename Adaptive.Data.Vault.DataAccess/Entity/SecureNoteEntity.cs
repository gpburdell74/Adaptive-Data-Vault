using Adaptive.Intelligence.Shared.Security;

namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Represents and contains the data for a secure note.
/// </summary>
/// <seealso cref="EntityBase" />
public sealed class SecureNoteEntity : EntityBase, ISecureNoteEntity
{
    #region Private Member Declarations
    /// <summary>
    /// The content of the note.
    /// </summary>
    private SecureString? _content;
    #endregion

    #region Constructor / Dispose Methods        
    /// <summary>
    /// Initializes a new instance of the <see cref="SecureNoteEntity"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public SecureNoteEntity()
    {
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
            _content?.Dispose();
        }

        _content = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties        
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
            if (_content == null)
                return null;
            else
                return _content.Value;
        }
        set
        {
            _content?.Dispose();
            _content = new SecureString(value);
        }
    }
    #endregion
}
