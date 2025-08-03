using Adaptive.Data.Vault.Entities;
using Adaptive.Data.Vault.IO;
using Adaptive.Intelligence.Shared;

namespace Adaptive.Data.Vault.DataAccess.IO;

/// <summary>
/// Provides the methods and functions for reading <see cref="IEntity"/> derived instances
/// from a data store.
/// </summary>
/// <seealso cref="IEntityReader" />
public sealed class VaultEntityReader : DisposableObjectBase, IEntityReader
{
    #region Data Set
    /// <summary>
    /// Reads the entire entity data set.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// An <see cref="IEntityDataSet" /> instance containing all the data from the related file.
    /// </returns>
    public IEntityDataSet? ReadEntityDataSet(ISafeReader reader)
    {
        List<IUserCategoryEntity>? catList = ReadCategoryEntryList(reader);
        List<IIdentityProviderEntity>? idpList = ReadIdentityProviderEntityList(reader);
        List<ISecureNoteEntity>? noteList = ReadSecureNoteEntityList(reader);
        List<IWebAccountEntity>? webList = ReadWebAccountEntryEntityList(reader);

        return new VaultEntityDataSet(catList, idpList, noteList, webList);
    }
    #endregion

    #region Categories
    /// <summary>
    /// Reads the category entry from the underlying data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// The <see cref=".IUserCategoryEntity" /> instance that was read if successful; otherwise,
    /// returns <b>null</b>.
    /// </returns>
    public IUserCategoryEntity? ReadCategoryEntry(ISafeReader reader)
    {
        IUserCategoryEntity entity = new UserCategoryEntity();
        entity.Id = reader.ReadGuid();
        entity.Name = reader.ReadString();

        return entity;
    }

    /// <summary>
    /// Reads the list of category entries from the underlying data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// A <see cref=List{T}" /> containing the <see cref="IUserCategoryEntity" /> instances that
    /// were read if successful; otherwise, returns <b>null</b>.
    /// </returns>
    public List<IUserCategoryEntity>? ReadCategoryEntryList(ISafeReader reader)
    {
        int length = reader.ReadInt32();
        List<IUserCategoryEntity> entityList = new List<IUserCategoryEntity>(length);

        for (int count = 0; count < length; count++)
        {
            IUserCategoryEntity? entity = ReadCategoryEntry(reader);
            if (entity != null)
                entityList.Add(entity);
        }
        return entityList;
    }
    #endregion

    #region Identity Providers
    /// <summary>
    /// Reads the identity provider entity from the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// The <see cref="IIdentityProviderEntity" /> instance that was read, if successful,
    /// otherwise, returns <b>null</b>.
    /// </returns>
    public IIdentityProviderEntity? ReadIdentityProviderEntity(ISafeReader reader)
    {
        IIdentityProviderEntity entity = new IdentityProviderEntity();

        entity.CategoryId = reader.ReadGuid();
        entity.MFADescription = reader.ReadString();
        entity.MFADeviceAddress = reader.ReadString();
        entity.Name = reader.ReadString();
        entity.Description = reader.ReadString();
        entity.Password = reader.ReadString();
        entity.ProviderType = (IdentityProviderType)reader.ReadInt32();
        entity.ProviderTypeName = reader.ReadString();
        entity.Url = reader.ReadString();
        entity.UserId = reader.ReadString();
        entity.UsesMFA = reader.ReadBoolean();

        return entity;
    }

    /// <summary>
    /// Reads the list of identity provider entities from the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// A <see cref=List{T}" /> containing the <see cref="IIdentityProviderEntity" /> instances that
    /// were read if successful; otherwise, returns <b>null</b>.
    /// </returns>
    public List<IIdentityProviderEntity>? ReadIdentityProviderEntityList(ISafeReader reader)
    {
        int length = reader.ReadInt32();
        List<IIdentityProviderEntity> entityList = new List<IIdentityProviderEntity>(length);

        for (int count = 0; count < length; count++)
        {
            IIdentityProviderEntity? entity = ReadIdentityProviderEntity(reader);
            if (entity != null)
                entityList.Add(entity);
        }
        return entityList;

    }
    #endregion

    #region Secure Notes
    /// <summary>
    /// Reads the secure note entity from the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// The <see cref="ISecureNoteEntity" /> instance that was read, if successful,
    /// otherwise, returns <b>null</b>.
    /// </returns>
    public ISecureNoteEntity? ReadSecureNoteEntity(ISafeReader reader)
    {
        ISecureNoteEntity entity = new SecureNoteEntity();

        entity.CategoryId = reader.ReadGuid();
        entity.Name = reader.ReadString();
        entity.Password = reader.ReadString();
        entity.SecureContent = reader.ReadString();
        entity.UserId = reader.ReadString();

        return entity;
    }

    /// <summary>
    /// Reads the list of secure note entities to the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// A <see cref=List{T}" /> containing the <see cref="ISecureNoteEntity" /> instances that
    /// were read if successful; otherwise, returns <b>null</b>.
    /// </returns>
    public List<ISecureNoteEntity>? ReadSecureNoteEntityList(ISafeReader reader)
    {
        int length = reader.ReadInt32();
        List<ISecureNoteEntity> entityList = new List<ISecureNoteEntity>(length);

        for (int count = 0; count < length; count++)
        {
            ISecureNoteEntity? entity = ReadSecureNoteEntity(reader);
            if (entity != null)
                entityList.Add(entity);
        }
        return entityList;
    }
    #endregion

    #region Web Accounts
    /// <summary>
    /// Reads the website account entity from the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// The <see cref="IWebAccountEntity" /> instance that was read, if successful,
    /// otherwise, returns <b>null</b>.
    /// </returns>
    public IWebAccountEntity? ReadWebAccountEntryEntity(ISafeReader reader)
    {
        IWebAccountEntity entity = new WebAccountEntity();

        entity.CategoryId = reader.ReadGuid();
        entity.MFADescription = reader.ReadString();
        entity.MFADeviceAddress = reader.ReadString();
        entity.Name = reader.ReadString();
        entity.Description = reader.ReadString();
        entity.Password = reader.ReadString();
        entity.Url = reader.ReadString();
        entity.UserId = reader.ReadString();
        entity.UsesMFA = reader.ReadBoolean();

        return entity;
    }

    /// <summary>
    /// Reads the list of web account entities to the data store.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="ISafeReader" /> implementation used to perform the read operation.
    /// </param>
    /// <returns>
    /// A <see cref=List{T}" /> containing the <see cref=".IWebAccountEntity" /> instances that
    /// were read if successful; otherwise, returns <b>null</b>.
    /// </returns>
    public List<IWebAccountEntity>? ReadWebAccountEntryEntityList(ISafeReader reader)
    {
        int length = reader.ReadInt32();
        List<IWebAccountEntity> entityList = new List<IWebAccountEntity>(length);

        for (int count = 0; count < length; count++)
        {
            IWebAccountEntity? entity = ReadWebAccountEntryEntity(reader);
            if (entity != null)
                entityList.Add(entity);
        }
        return entityList;
    }
    #endregion
}