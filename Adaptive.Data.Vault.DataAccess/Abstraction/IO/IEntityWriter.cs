using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.IO;

/// <summary>
/// Provides the signature definition for instances that write entities to a data store.
/// </summary>
/// <seealso cref="IDisposable" />
public interface IEntityWriter : IDisposable 
{
    /// <summary>
    /// Writes the entire entity data set.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <returns>
    /// An <see cref="IEntityDataSet"/> instance containing all the data from the related file.
    /// </returns>
    void WriteEntityDataSet(ISafeWriter writer, IEntityDataSet dataSet);

    /// <summary>
    /// Writes the category entry to the underlying data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <param name="entity">
    /// The <see cref="IUserCategoryEntity"/> instance to be written.
    /// </param>
    void WriteCategoryEntry(ISafeWriter writer, IUserCategoryEntity entity);

    /// <summary>
    /// Writes the list of category entries to the underlying data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <param name="entityList">
    /// The <see cref="List{T}"/> of <see cref="IUserCategoryEntity"/> instances to be written.
    /// </param>
    void WriteCategoryEntryList(ISafeWriter writer, List<IUserCategoryEntity> entityList);

    /// <summary>
    /// Writes the identity provider entity to the data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <param name="entity">
    /// The <see cref="IIdentityProviderEntity"/> instance to be written.
    /// </param>
    void WriteIdentityProviderEntity(ISafeWriter writer, IIdentityProviderEntity entity);

    /// <summary>
    /// Writes the list of identity provider entities to the data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <param name="entityList">
    /// The <see cref="List{T}"/> of <see cref="IIdentityProviderEntity"/> instances to be written.
    /// </param>
    void WriteIdentityProviderEntityList(ISafeWriter writer, List<IIdentityProviderEntity> entityList);

    /// <summary>
    /// Writes the secure note entity to the data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <param name="entity">
    /// The <see cref="ISecureNoteEntity"/> instance to be written.
    /// </param>
    void WriteSecureNoteEntity(ISafeWriter writer, ISecureNoteEntity entity);

    /// <summary>
    /// Writes the list of secure note entities to the data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <param name="entityList">
    /// The <see cref="List{T}"/> of <see cref="ISecureNoteEntity"/> instances to be written.
    /// </param>
    void WriteSecureNoteEntityList(ISafeWriter writer, List<ISecureNoteEntity> entityList);

    /// <summary>
    /// Writes the website account entity to the data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <param name="entity">
    /// The <see cref="IWebAccountEntity"/> instance to be written.
    /// </param>
    void WriteWebAccountEntryEntity(ISafeWriter writer, IWebAccountEntity entity);

    /// <summary>
    /// Writes the list of web site account entities to the data store.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="ISafeWriter"/> implementation used to perform the write operation.
    /// </param>
    /// <param name="entityList">
    /// The <see cref="List{T}"/> of <see cref="IWebAccountEntity"/> instances to be written.
    /// </param>
    void WriteWebAccountEntryEntityList(ISafeWriter writer, List<IWebAccountEntity> entityList);
}
