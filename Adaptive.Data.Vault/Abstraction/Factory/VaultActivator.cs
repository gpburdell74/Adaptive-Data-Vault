using Adaptive.Data.Vault.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Adaptive.Data.Vault.Abstraction;

/// <summary>
/// Provides static methods / functions for properly instantiating business objects from
/// interface types.
/// </summary>
public static class VaultActivator
{
    public static T CreateInstance<T>()
        where T : IEntity
    {
        T? instance = default(T);

        Type dataType = typeof(T);

        if (typeof(ISecureNoteEntity).IsAssignableFrom(dataType))
            instance = (T)(object)new SecureNoteEntity();

        else if (typeof(IIdentityProviderEntity).IsAssignableFrom(dataType))
            instance = (T)(object)new IdentityProviderEntity();

        else if (typeof(IWebAccountEntity).IsAssignableFrom(dataType))
            instance = (T)(object)new WebAccountEntity();

        else if (typeof(IUserCategoryEntity).IsAssignableFrom(dataType))

            instance = (T)(object)new UserCategoryEntity();

        else
            throw new Exception();
        return instance;

    }

    /// <summary>
    /// Creates the business object instance for the specified entity.
    /// </summary>
    /// <typeparam name="T">
    /// The expected data type of entity used to populate the business object.
    /// </typeparam>
    /// <param name="entity">
    /// The data entity used to create the business object.
    /// </param>
    /// <returns>
    /// The new <see cref="VaultBusinessBase{T}"/> business object instance related to the 
    /// specified entity.
    /// </returns>
    public static object CreateInstanceForEntity<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] T>(T entity)
            where T : IEntity
    {
        object? instance = null;
        Type dataType = typeof(T);

        if (typeof(ISecureNoteEntity).IsAssignableFrom(dataType))
        {
            instance = new SecureNote((ISecureNoteEntity)entity);
        }
        else if (typeof(IIdentityProviderEntity).IsAssignableFrom(dataType))
        {
            instance = new IdentityProvider((IIdentityProviderEntity)entity);
        }
        else if (typeof(IWebAccountEntity).IsAssignableFrom(dataType))
        {
            instance = new WebAccount((IWebAccountEntity)entity);
        }
        else if (typeof(IUserCategoryEntity).IsAssignableFrom(dataType))
        {
            instance = new UserCategory((IUserCategoryEntity)entity);
        }
        else
        {
            throw new Exception("Invalid interface type specified to factory.");
        }

        return instance;
    }
}
