using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault
{
    /// <summary>
    /// Contains and manages a list of <see cref="SecureNote"/> instances.
    /// </summary>
    /// <seealso cref="List{T}" />
    public sealed class SecureNoteCollection : VaultBusinessCollectionBase<SecureNote, ISecureNoteEntity>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SecureNoteCollection"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public SecureNoteCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecureNoteCollection"/> class.
        /// </summary>
        /// <param name="sourceList">
        /// The <see cref="IEnumerable{T}"/> list of <see cref="SecureNoteEntity"/>
        /// entities used to create the business object(s) and populate the list.
        /// </param>
        public SecureNoteCollection(IEnumerable<ISecureNoteEntity> sourceList)
        {
            foreach (ISecureNoteEntity entity in sourceList)
            {
                SecureNote note = new SecureNote(entity);
                Add(note);
            }
        }
        #endregion

        #region Public Methods / Functions
        /// <summary>
        /// Adds the secure note.
        /// </summary>
        /// <param name="name">
        /// A string containing the name for the entry.
        /// </param>
        /// <param name="description">
        /// A string containing the description for the entry.
        /// </param>
        /// <param name="content">
        /// A string containing the content to be secured.
        /// </param>
        public void AddSecureNote(string name, string description, string content)
        {
            SecureNote entity = new SecureNote
            {
                Name = name,
                SecureContent = content,
            };
            Add(entity);
        }
        /// <summary>
        /// Sorts the list's content into alphabetical order by name.
        /// </summary>
        public void SortAlpha()
        {
            Sort(AlphabeticComparison);
        }
        #endregion

        #region Private Methods / Functions
        /// <summary>
        /// Provides the predicate implementation for comparing two <see cref="SecureNote"/> instances
        /// by name value.
        /// </summary>
        /// <param name="left">
        /// The left <see cref="SecureNote"/> to compare.
        /// </param>
        /// <param name="right">
        /// The right <see cref="SecureNote"/> to compare.
        /// </param>
        /// <returns>
        /// The result of the comparison, as an integer value, in the same context as the <see cref="string.Compare"/>
        /// function.
        /// </returns>
        private int AlphabeticComparison(SecureNote left, SecureNote right)
        {
            return string.Compare(left.Name, right.Name, StringComparison.OrdinalIgnoreCase);
        }
        #endregion
    }
}
