using Adaptive.Data.Vault.Entities;
using Moq;

namespace Adaptive.Data.Vault.Tests
{
    public class UserCategoryCollectionTests
    {
        [Fact]
        public void DefaultConstructor_CreatesEmptyCollection()
        {
            // Act
            var collection = new UserCategoryCollection();

            // Assert
            Assert.Empty(collection);
        }

        [Fact]
        public void Constructor_WithSourceList_PopulatesCollection()
        {
            // Arrange
            var mockEntity1 = new UserCategoryEntity();
            mockEntity1.Id = Guid.NewGuid();
            mockEntity1.Name = "Category1";

            var mockEntity2 = new UserCategoryEntity();
            mockEntity2.Id = Guid.NewGuid();
            mockEntity2.Name = "Category2";

            var sourceList = new List<IUserCategoryEntity>
            {
                mockEntity1,
                mockEntity2
            };

            // Act
            var collection = new UserCategoryCollection(sourceList);

            // Assert
            Assert.Equal(2, collection.Count);
            Assert.Contains(collection, c => c.Name == "Category1");
            Assert.Contains(collection, c => c.Name == "Category2");
        }

        [Fact]
        public void AddCategory_AddsNewCategoryWithGivenName()
        {
            // Arrange
            var collection = new UserCategoryCollection();
            string categoryName = "TestCategory";

            // Act
            collection.AddCategory(categoryName);

            // Assert
            Assert.Single(collection);
            Assert.Equal(categoryName, collection[0].Name);
            Assert.NotEqual(Guid.Empty, collection[0].Id);
        }
    }
}