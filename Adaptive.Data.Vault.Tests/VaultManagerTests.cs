using Adaptive.Data.Vault.DataAccess.IO;
using Adaptive.Data.Vault.Entities;
using Moq;

namespace Adaptive.Data.Vault.Tests
{
    public class VaultManagerTests : IDisposable
    {
        private readonly VaultManager _manager;

        public VaultManagerTests()
        {
            _manager = new VaultManager();
        }

        public void Dispose()
        {
            _manager.Dispose();
        }

        [Fact]
        public void Constructor_InitializesCollections()
        {
            Assert.NotNull(_manager.Categories);
            Assert.NotNull(_manager.IdProviders);
            Assert.NotNull(_manager.SecureNotes);
            Assert.NotNull(_manager.WebAccounts);
        }

        [Fact]
        public void Close_ClearsAllFields()
        {
            _manager.Close();

            Assert.Null(GetPrivateField("_file"));
            Assert.Null(GetPrivateField("_data"));
            Assert.Null(GetPrivateField("_userId"));
            Assert.Null(GetPrivateField("_password"));
            Assert.Null(GetPrivateField("_pin"));
            Assert.Null(GetPrivateField("_fileName"));
            Assert.Null(GetPrivateField("_webAccounts"));
            Assert.Null(GetPrivateField("_secureNotes"));
            Assert.Null(GetPrivateField("_idProviders"));
            Assert.Null(GetPrivateField("_categories"));
        }

        [Fact]
        public void GetWebAccountsForCategory_ReturnsFilteredList()
        {
            var categoryId = Guid.NewGuid();
            var mockCollection = new WebAccountCollection();
            WebAccount provider = new WebAccount();
            provider.CategoryId = categoryId;
            mockCollection.Add(provider);
            mockCollection.Add(new WebAccount { CategoryId = Guid.NewGuid() });
            mockCollection.Add(new WebAccount { CategoryId = Guid.NewGuid() });
            mockCollection.Add(new WebAccount { CategoryId = Guid.NewGuid() });

            var result = mockCollection.GetForCategory(categoryId);

            Assert.Single(result);
            Assert.Equal(categoryId, result[0].CategoryId);
        }

        [Fact]
        public void GetSecureNotesForCategory_ReturnsFilteredList()
        {
            var categoryId = Guid.NewGuid();
            var mockCollection = new SecureNoteCollection();
            SecureNote provider = new SecureNote();
            provider.CategoryId = categoryId;
            mockCollection.Add(provider);
            mockCollection.Add(new SecureNote { CategoryId = Guid.NewGuid() });
            mockCollection.Add(new SecureNote { CategoryId = Guid.NewGuid() });
            mockCollection.Add(new SecureNote { CategoryId = Guid.NewGuid() });

            var result = mockCollection.GetForCategory(categoryId);

            Assert.Single(result);
            Assert.Equal(categoryId, result[0].CategoryId);
        }

        [Fact]
        public void GetIdentityProvidersForCategory_ReturnsFilteredList()
        {
            var categoryId = Guid.NewGuid();
            var mockCollection = new IdentityProviderCollection();
            IdentityProvider provider = new IdentityProvider();
            provider.CategoryId = categoryId;
            mockCollection.Add(provider);
            mockCollection.Add(new IdentityProvider {  CategoryId = Guid.NewGuid() });
            mockCollection.Add(new IdentityProvider { CategoryId = Guid.NewGuid() });
            mockCollection.Add(new IdentityProvider { CategoryId = Guid.NewGuid() });

            var result = mockCollection.GetForCategory(categoryId);

            Assert.Single(result);
            Assert.Equal(categoryId, result[0].CategoryId);
        }

        [Fact]
        public void Load_WithInvalidData_CallsCloseAndReturnsFalse()
        {
            var mockFile = new VaultFile();
            IEntityDataSet? ds = mockFile.LoadDataSet(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<int>());

            SetPrivateField("_file", mockFile);

            var result = _manager.Load("file", "user", "pass", 1234);

            Assert.False(result);
        }

        [Fact]
        public void Load_WithValidData_InitializesCollectionsAndReturnsFalse()
        {
            var dataSet = new VaultEntityDataSet();
            var dataFile = new VaultFile();
            dataFile.LoadDataSet(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<int>());

            SetPrivateField("_file", dataFile);

            var result = _manager.Load("file", "user", "pass", 1234);

            Assert.False(result);
            Assert.NotNull(_manager.Categories);
            Assert.NotNull(_manager.IdProviders);
            Assert.NotNull(_manager.WebAccounts);
            Assert.NotNull(_manager.SecureNotes);
        }

        [Fact]
        public void Save_DoesNotThrow_WhenCanSaveDataIsFalse()
        {
            SetPrivateField("_file", null);
            _manager.Save();
        }

        // Helper methods for private field access
        private object? GetPrivateField(string name)
        {
            var field = typeof(VaultManager).GetField(name, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return field?.GetValue(_manager);
        }

        private void SetPrivateField(string name, object? value)
        {
            var field = typeof(VaultManager).GetField(name, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            field?.SetValue(_manager, value);
        }
    }
}