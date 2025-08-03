using Adaptive.Data.Vault.Entities;
using Adaptive.Data.Vault.IO;
using Adaptive.Intelligence.Shared;

namespace Adaptive.Data.Vault.DataAccess.IO
{
    /// <summary>
    /// Provides the methods and functions for writing <see cref="IEntity"/> derived instances
    /// to a data store.
    /// </summary>
    /// <seealso cref="IEntityWriter" />
    public sealed class VaultEntityWriter : DisposableObjectBase, IEntityWriter
    {
        #region Data Set
        /// <summary>
        /// Writes the entire entity data set.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="ISafeWriter" /> implementation used to perform the write operation.
        /// </param>
        /// <param name="dataSet">
        /// The reference to the <see cref="IEntityDataSet"/> instance whose content is to be written.
        /// </param>
        public void WriteEntityDataSet(ISafeWriter writer, IEntityDataSet dataSet)
        {
            WriteCategoryEntryList(writer, dataSet.Categories!);
            WriteIdentityProviderEntityList(writer, dataSet.IdProviders!);
            WriteSecureNoteEntityList(writer, dataSet.SecureNotes!);
            WriteWebAccountEntryEntityList(writer, dataSet.WebAccounts!);

            writer.Flush();
        }
        #endregion

        #region Categories
        /// <summary>
        /// Writes the category entry to the underlying data store.
        /// </summary>
        /// <param name="writer">The <see cref="ISafeWriter" /> implementation used to perform the write operation.</param>
        /// <param name="category"></param>
        public void WriteCategoryEntry(ISafeWriter writer, IUserCategoryEntity category)
        {
            writer.Write(category.Id);
            writer.Write(category.Name!);
            writer.Flush();
        }

        /// <summary>
        /// Writes the list of category entries to the underlying data store.
        /// </summary>
        /// <param name="writer">The <see cref="ISafeWriter" /> implementation used to perform the write operation.
        /// </param>
        /// <param name="entityList">
        /// The <see cref="List{T}" /> of <see cref="IUserCategoryEntity" /> instances to be written
        /// .</param>
        public void WriteCategoryEntryList(ISafeWriter writer, List<IUserCategoryEntity> entityList)
        {
            writer.Write(entityList.Count);
            foreach (IUserCategoryEntity entity in entityList)
                WriteCategoryEntry(writer, entity);
            writer.Flush();
        }
        #endregion

        #region Identity Providers
        /// <summary>
        /// Writes the identity provider entity to the data store.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="ISafeWriter" /> implementation used to perform the write operation.
        /// </param>
        /// <param name="entity">
        /// The <see cref="IIdentityProviderEntity" /> instance to be written.
        /// </param>
        public void WriteIdentityProviderEntity(ISafeWriter writer, IIdentityProviderEntity entity)
        {
            writer.Write(entity.CategoryId);
            writer.Write(entity.MFADescription!);
            writer.Write(entity.MFADeviceAddress!);
            writer.Write(entity.Name!);
            writer.Write(entity.Description!);
            writer.Write(entity.Password!);
            writer.Write((int)entity.ProviderType);
            writer.Write(entity.ProviderTypeName!);
            writer.Write(entity.Url!);
            writer.Write(entity.UserId!);
            writer.Write(entity.UsesMFA);
            writer.Flush();
        }

        /// <summary>
        /// Writes the list of identity provider entities to the data store.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="ISafeWriter" /> implementation used to perform the write operation.
        /// </param>
        /// <param name="entityList">
        /// The <see cref="List{T}" /> of <see cref="IIdentityProviderEntity" /> instances to be written.
        /// </param>
        public void WriteIdentityProviderEntityList(ISafeWriter writer, List<IIdentityProviderEntity> entityList)
        {
            writer.Write(entityList.Count);
            foreach (IIdentityProviderEntity entity in entityList)
                WriteIdentityProviderEntity(writer, entity);
            writer.Flush();
        }
        #endregion

        #region Security Notes
        /// <summary>
        /// Writes the secure note entity to the data store.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="ISafeWriter" /> implementation used to perform the write operation.
        /// </param>
        /// <param name="entity">
        /// The <see cref="ISecureNoteEntity" /> instance to be written.
        /// </param>
        public void WriteSecureNoteEntity(ISafeWriter writer, ISecureNoteEntity entity)
        {
            writer.Write(entity.CategoryId);
            writer.Write(entity.Name!);
            writer.Write(entity.Password!);
            writer.Write(entity.SecureContent!);
            writer.Write(entity.UserId!);
            writer.Flush();
        }

        /// <summary>
        /// Writes the list of secure note entities to the data store.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="ISafeWriter" /> implementation used to perform the write operation.
        /// </param>
        /// <param name="entityList">
        /// The <see cref="List{T}" /> of <see cref="ISecureNoteEntity" /> instances to be written.
        /// </param>
        public void WriteSecureNoteEntityList(ISafeWriter writer, List<ISecureNoteEntity> entityList)
        {
            writer.Write(entityList.Count);
            foreach (ISecureNoteEntity entity in entityList)
                WriteSecureNoteEntity(writer, entity);
            writer.Flush();
        }
        #endregion

        #region Web Accounts
        /// <summary>
        /// Writes the website account entity to the data store.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="ISafeWriter" /> implementation used to perform the write operation.
        /// </param>
        /// <param name="entity">
        /// The <see cref="IWebAccountEntity" /> instance to be written.
        /// </param>
        public void WriteWebAccountEntryEntity(ISafeWriter writer, IWebAccountEntity entity)
        {
            writer.Write(entity.CategoryId);
            writer.Write(entity.MFADescription!);
            writer.Write(entity.MFADeviceAddress!);
            writer.Write(entity.Name!);
            writer.Write(entity.Description!);
            writer.Write(entity.Password!);
            writer.Write(entity.Url!);
            writer.Write(entity.UserId!);
            writer.Write(entity.UsesMFA!);
            writer.Flush();
        }

        /// <summary>
        /// Writes the list of web site account entities to the data store.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="ISafeWriter" /> implementation used to perform the write operation.
        /// </param>
        /// <param name="entityList">
        /// The <see cref="List{T}" /> of <see cref="IWebAccountEntity" /> instances to be written.
        /// </param>
        public void WriteWebAccountEntryEntityList(ISafeWriter writer, List<IWebAccountEntity> entityList)
        {
            writer.Write(entityList.Count);
            foreach (IWebAccountEntity entity in entityList)
                WriteWebAccountEntryEntity(writer, entity);
            writer.Flush();
        }
        #endregion
    }
}

