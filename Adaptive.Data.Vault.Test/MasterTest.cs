using Adaptive.Data.Vault.DataAccess.IO;
using Adaptive.Data.Vault.Entities;
using Xunit;

namespace Adaptive.Data.Vault.Test
{
    public class MasterTest
    {
        private const string CredUid = "Sam Jones";
        private const string CredPwd = "7329.Wnyhiq";
        private const int CredPin = 12345;

        [Fact]
        public void ExecuteMasterBusinessTest()
        {
            // Set up the content.

            IEntityDataSet ds = DataSetTestFactory.CreateTestDataSet();

            VaultFile file = new VaultFile();
            file.SaveDataSet(ds, @"C:\Temp\TestVaultFile.adv", CredUid, CredPwd, CredPin);
            file.Dispose();

            VaultManager manager = new VaultManager();
            manager.Load(@"C:\Temp\TestVaultFile.adv", CredUid, CredPwd, CredPin);

            IEntityDataSet ds2 = new VaultEntityDataSet(
                manager.Categories.ToEntityList(),
                manager.IdProviders.ToEntityList(),
                manager.SecureNotes.ToEntityList(),
                manager.WebAccounts.ToEntityList());


            CompareCategories(ds, ds2);
            CompareIdProviders(ds, ds2);
            CompareSecureNotes(ds, ds2);
            CompareWebAccounts(ds, ds2);

            ds2.Dispose();

            manager.Save(@"C:\Temp\TestVaultFile2.adv", "aaabbbccc", "123456789", 2222);
            manager.Dispose();

            manager = new VaultManager();
            manager.Load(@"C:\Temp\TestVaultFile2.adv", "aaabbbccc", "123456789", 2222);

            ds2 = new VaultEntityDataSet(
    manager.Categories.ToEntityList(),
    manager.IdProviders.ToEntityList(),
    manager.SecureNotes.ToEntityList(),
    manager.WebAccounts.ToEntityList());

            CompareCategories(ds, ds2);
            CompareIdProviders(ds, ds2);
            CompareSecureNotes(ds, ds2);
            CompareWebAccounts(ds, ds2);

            ds2.Dispose();
            ds.Dispose();
            manager.Dispose();
        }

        [Fact]
        public void ExecuteMasterTest()
        {
            IEntityDataSet ds = DataSetTestFactory.CreateTestDataSet();

            VaultFile file = new VaultFile();
            file.SaveDataSet(ds, @"C:\Temp\TestVaultFile.adv", CredUid, CredPwd, CredPin);
            file.Dispose();

            file = new VaultFile();
            IEntityDataSet ds2 = file.LoadDataSet(@"C:\Temp\TestVaultFile.adv", CredUid, CredPwd, CredPin);
            file.Dispose();

            CompareCategories(ds, ds2);
            CompareIdProviders(ds, ds2);
            CompareSecureNotes(ds, ds2);
            CompareWebAccounts(ds, ds2);

            ds.Dispose();
            ds2.Dispose();

        }
        private static void CompareCategories(IEntityDataSet ds, IEntityDataSet ds2)
        {
            if (ds.Categories.Count != ds2.Categories.Count)
                throw new Exception();

            int length = ds.Categories.Count;
            for (int count = 0; count < length; count++)
            {
                CompareCategory(ds.Categories[count], ds2.Categories[count]);
            }
        }
        private static void CompareIdProviders(IEntityDataSet ds, IEntityDataSet ds2)
        {
            if (ds.IdProviders.Count != ds2.IdProviders.Count)
                throw new Exception();

            int length = ds.Categories.Count;
            for (int count = 0; count < length; count++)
            {
                CompareIdProvider(ds.IdProviders[count], ds2.IdProviders[count]);
            }
        }
        private static void CompareSecureNotes(IEntityDataSet ds, IEntityDataSet ds2)
        {
            if (ds.SecureNotes.Count != ds2.SecureNotes.Count)
                throw new Exception();

            int length = ds.SecureNotes.Count;
            for (int count = 0; count < length; count++)
            {
                CompareSecureNote(ds.SecureNotes[count], ds2.SecureNotes[count]);
            }
        }
        private static void CompareWebAccounts(IEntityDataSet ds, IEntityDataSet ds2)
        {
            if (ds.WebAccounts.Count != ds2.WebAccounts.Count)
                throw new Exception();

            int length = ds.WebAccounts.Count;
            for (int count = 0; count < length; count++)
            {
                CompareWebAccount(ds.WebAccounts[count], ds2.WebAccounts[count]);
            }

        }

        private static void CompareCategory(IUserCategoryEntity entityA, IUserCategoryEntity entityB)
        {
            if ((entityA.Id != entityB.Id) ||
                (entityA.Name != entityB.Name))
                throw new Exception("Category Ids do not match.");
        }
        private static void CompareIdProvider(IIdentityProviderEntity entityA, IIdentityProviderEntity entityB)
        {
            if ((entityA.CategoryId != entityB.CategoryId) ||
                (entityA.Name != entityB.Name) ||
                (entityA.Password != entityB.Password) ||
                (entityA.ProviderType != entityB.ProviderType) ||
                (entityA.MFADescription != entityB.MFADescription) ||
                (entityA.MFADeviceAddress != entityB.MFADeviceAddress))
                throw new Exception("Identity Provider Ids do not match.");
        }
        private static void CompareSecureNote(ISecureNoteEntity entityA, ISecureNoteEntity entityB)
        {
            if ((entityA.Name != entityA.Name) || (entityA.SecureContent != entityB.SecureContent))
                throw new Exception("Secure Notes do not match.");
        }
        private static void CompareWebAccount(IWebAccountEntity entityA, IWebAccountEntity entityB)
        {
            if (
            (entityA.CategoryId != entityB.CategoryId) ||
            (entityA.MFADescription != entityB.MFADescription) ||
            (entityA.MFADeviceAddress != entityB.MFADeviceAddress) ||
            (entityA.Name != entityB.Name) ||
            (entityA.Password != entityB.Password) ||
            (entityA.Url != entityB.Url) ||
            (entityA.UserId != entityB.UserId) ||
            (entityA.UsesMFA != entityB.UsesMFA))

                throw new Exception("Web Records do not match.");
        }

    }
}
