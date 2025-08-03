using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.IO;

/// <summary>
/// Provides the signature definition for instances that read entities from a data store.
/// </summary>
/// <seealso cref="IDisposable" />
public interface IEntityReader : IDisposable
{
    /// <summary>
    /// Reads the entire entity data set.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// An <see cref="IEntityDataSet"/> instance containing all the data from the related file.
    /// </returns>
    IEntityDataSet? ReadEntityDataSet(ISafeReader reader);

    /// <summary>
    /// Reads the category entry from the underlying data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// The <see cref="IUserCategoryEntity"/> instance that was read if successful; otherwise,
    /// returns <b>null</b>.
    /// </returns>
    IUserCategoryEntity? ReadCategoryEntry(ISafeReader reader);

    /// <summary>
    /// Reads the list of category entries from the underlying data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// A <see cref="List{T}"/> containing the <see cref="IUserCategoryEntity"/> instances that 
    /// were read if successful; otherwise, returns <b>null</b>.
    /// </returns>
    List<IUserCategoryEntity>? ReadCategoryEntryList(ISafeReader reader);

    /// <summary>
    /// Reads the identity provider entity from the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// The <see cref="IIdentityProviderEntity"/> instance that was read, if successful,
    /// otherwise, returns <b>null</b>.
    /// </returns>
    IIdentityProviderEntity? ReadIdentityProviderEntity(ISafeReader reader);

    /// <summary>
    /// Reads the list of identity provider entities from the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// A <see cref="List{T}"/> containing the <see cref="IIdentityProviderEntity"/> instances that 
    /// were read if successful; otherwise, returns <b>null</b>.
    /// </returns>
    List<IIdentityProviderEntity>? ReadIdentityProviderEntityList(ISafeReader reader);

    /// <summary>
    /// Reads the secure note entity from the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// The <see cref="ISecureNoteEntity"/> instance that was read, if successful,
    /// otherwise, returns <b>null</b>.
    /// </returns>
    ISecureNoteEntity? ReadSecureNoteEntity(ISafeReader reader);

    /// <summary>
    /// Reads the list of secure note entities to the data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// A <see cref="List{T}"/> containing the <see cref="ISecureNoteEntity"/> instances that 
    /// were read if successful; otherwise, returns <b>null</b>.
    /// </returns>
    List<ISecureNoteEntity>? ReadSecureNoteEntityList(ISafeReader reader);

    /// <summary>
    /// Reads the website account entity from the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// The <see cref="IWebAccountEntity"/> instance that was read, if successful,
    /// otherwise, returns <b>null</b>.
    /// </returns>
    IWebAccountEntity? ReadWebAccountEntryEntity(ISafeReader reader);

    /// <summary>
    /// Reads the list of web account entities to the data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeReader"/> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// A <see cref="List{T}"/> containing the <see cref="IWebAccountEntity"/> instances that 
    /// were read if successful; otherwise, returns <b>null</b>.
    /// </returns>
    List<IWebAccountEntity>? ReadWebAccountEntryEntityList(ISafeReader reader);
}
