using Adaptive.Data.Vault.Entities;
using Adaptive.Intelligence.Shared;

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

    public static VaultBusinessBase<T> CreateInstanceForEntity<T>(T entity)
        where T : IEntity
    {
        VaultBusinessBase<T>? instance = null;

        Type dataType = typeof(T);
        switch (dataType)
        {
            case ISecureNoteEntity noteEntity:
                instance = (VaultBusinessBase<T>)(object)new SecureNote(noteEntity);
                break;

            case IIdentityProviderEntity idEntity:
                instance = (VaultBusinessBase<T>)(object)new IdentityProvider(idEntity);
                break;

            case IWebAccountEntity webEntity:
                instance = (VaultBusinessBase<T>)(object)new WebAccount(webEntity);
                break;

            case IUserCategoryEntity catEntity:
                instance = (VaultBusinessBase<T>)(object)new UserCategory(catEntity);
                break;

            default:
                throw new Exception();

        }
        return instance;
    }
}
