using Adaptive.Data.Vault.Entities;
using Newtonsoft.Json;

namespace Adaptive.Data.Vault.Tests.Abstraction.Bases
{
    // Dummy implementations for testing
    public class TestEntity : IEntity, ISecureNoteEntity
    {
        public Guid? CategoryId { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? UserId { get; set; }
        public string? SecureContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
        }
    }

    public class TestBusiness : VaultBusinessBase<IEntity>
    {
        public TestBusiness(TestEntity entity) : base(entity) { }
    }

    public class TestVaultBusinessCollection : VaultBusinessCollectionBase<TestBusiness, IEntity>
    {
        public TestVaultBusinessCollection() : base() { }
        public TestVaultBusinessCollection(IEnumerable<IEntity> sourceList) : base(sourceList) { }
    }

    public class VaultBusinessCollectionBaseTests
    {
        [Fact]
        public void DefaultConstructor_InitializesEmptyCollection()
        {
            var collection = new TestVaultBusinessCollection();
            Assert.Empty(collection);
        }

        [Fact]
        public void Constructor_WithEntities_PopulatesCollection()
        {
            var secureNotes = new SecureNoteEntity[]
            {
                new SecureNoteEntity()
            };
            var idProviders = new IdentityProviderEntity[]
            {
                new IdentityProviderEntity()
            };
            var userCategories = new UserCategoryEntity[]
            {
                new UserCategoryEntity()
            };
            var webAccounts = new WebAccountEntity[]
            {
                new WebAccountEntity()
            };

            // Mock VaultActivator to return TestBusiness for each entity
            var notesCollection = new SecureNoteCollection(secureNotes);
            var idProvidersCollection = new IdentityProviderCollection(idProviders);
            var userCategoriesCollection = new UserCategoryCollection(userCategories);
            var webCollection = new WebAccountCollection(webAccounts);

            Assert.Equal(secureNotes.Length, notesCollection.Count);
            Assert.Equal(idProviders.Length, idProvidersCollection.Count);
            Assert.Equal(userCategories.Length, userCategoriesCollection.Count);
            Assert.Equal(webAccounts.Length, webCollection.Count);

            Assert.All(notesCollection, item => Assert.IsType<SecureNote>(item));
            Assert.All(idProvidersCollection, item => Assert.IsType<IdentityProvider>(item));
            Assert.All(userCategoriesCollection, item => Assert.IsType<UserCategory>(item));
            Assert.All(webCollection, item => Assert.IsType<WebAccount>(item));
        }

        [Fact]
        public void GetForCategory_ReturnsMatchingItems()
        {
            var categoryId = Guid.NewGuid();
            var entities = new List<TestEntity>
            {
                new TestEntity { CategoryId = categoryId },
                new TestEntity { CategoryId = null },
                new TestEntity { CategoryId = categoryId }
            };

            var collection = new TestVaultBusinessCollection(entities);
            var result = collection.GetForCategory(categoryId);
            Assert.Equal(2, result.Count);
            Assert.All(result, item => Assert.Equal(categoryId, item.CategoryId));
        }

        [Fact]
        public void ToEntityList_ReturnsAllEntities()
        {
            var entities = new List<TestEntity>
            {
                new TestEntity(),
                new TestEntity()
            };

            var collection = new TestVaultBusinessCollection(entities);
            var entityList = collection.ToEntityList();
            Assert.Equal(entities.Count, entityList.Count);
            Assert.All(entityList, e => Assert.IsType<TestEntity>(e));
        }
    }
}