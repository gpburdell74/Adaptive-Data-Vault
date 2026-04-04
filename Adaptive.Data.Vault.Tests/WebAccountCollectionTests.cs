using Adaptive.Data.Vault.Entities;
using Moq;

namespace Adaptive.Data.Vault.Tests
{
    public class WebAccountCollectionTests
    {
        [Fact]
        public void DefaultConstructor_CreatesEmptyCollection()
        {
            var collection = new WebAccountCollection();
            Assert.Empty(collection);
        }

        [Fact]
        public void Constructor_WithSourceList_AddsAllEntities()
        {
            var mockEntity1 = new Mock<IWebAccountEntity>();
            var mockEntity2 = new Mock<IWebAccountEntity>();
            var sourceList = new List<IWebAccountEntity> { mockEntity1.Object, mockEntity2.Object };

            var collection = new WebAccountCollection(sourceList);

            Assert.Equal(2, collection.Count);
        }

        [Fact]
        public void AddWebAccount_AddsAccountWithCorrectProperties()
        {
            var collection = new WebAccountCollection();
            collection.AddWebAccount("TestName", "TestDesc", "http://test.com", "user", "pass", true, "SMS", "555-1234");

            var account = collection.FirstOrDefault();
            Assert.NotNull(account);
            Assert.Equal("TestName", account.Name);
            Assert.Equal("http://test.com", account.Url);
            Assert.Equal("user", account.UserId);
            Assert.Equal("pass", account.Password);
            Assert.True(account.UsesMFA);
            Assert.Equal("SMS", account.MFADescription);
            Assert.Equal("555-1234", account.MFADeviceAddress);
        }

        [Fact]
        public void GetForCategory_ReturnsAccountsMatchingCategory()
        {
            var categoryId = Guid.NewGuid();
            var otherCategoryId = Guid.NewGuid();

            var account1 = new WebAccount { CategoryId = categoryId };
            var account2 = new WebAccount { CategoryId = otherCategoryId };
            var collection = new WebAccountCollection();
            collection.Add(account1);
            collection.Add(account2);

            var filtered = collection.GetForCategory(categoryId);

            Assert.Single(filtered);
            Assert.Equal(categoryId, filtered.First().CategoryId);
        }

        [Fact]
        public void GetForCategory_WithNullCategoryId_ReturnsAccountsWithEmptyGuid()
        {
            var account1 = new WebAccount { CategoryId = Guid.Empty };
            var account2 = new WebAccount { CategoryId = Guid.NewGuid() };
            var collection = new WebAccountCollection();
            collection.Add(account1);
            collection.Add(account2);

            var filtered = collection.GetForCategory(null);

            Assert.Single(filtered);
            Assert.Equal(Guid.Empty, filtered.First().CategoryId);
        }

        [Fact]
        public void SortAlpha_SortsAccountsByNameAlphabetically()
        {
            var accountA = new WebAccount { Name = "Charlie" };
            var accountB = new WebAccount { Name = "alice" };
            var accountC = new WebAccount { Name = "Bob" };
            var collection = new WebAccountCollection();
            collection.Add(accountA);
            collection.Add(accountB);
            collection.Add(accountC);

            collection.SortAlpha();

            Assert.Equal("alice", collection[0].Name);
            Assert.Equal("Bob", collection[1].Name);
            Assert.Equal("Charlie", collection[2].Name);
        }
    }
}