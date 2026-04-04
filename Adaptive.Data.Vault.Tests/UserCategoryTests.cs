using Adaptive.Data.Vault.Entities;
using Moq;

namespace Adaptive.Data.Vault.Tests
{
    public class UserCategoryTests
    {
        [Fact]
        public void DefaultConstructor_InitializesWithNullEntity()
        {
            // Arrange & Act
            var category = new UserCategory();

            // Assert
            Assert.Equal(Guid.Empty, category.CategoryId);
            Assert.True(string.IsNullOrEmpty(category.Name));
        }

        [Fact]
        public void Constructor_WithEntity_SetsProperties()
        {
            // Arrange
            var guid = Guid.NewGuid();
            var mockEntity = new UserCategoryEntity();
            mockEntity.Id = guid;
            mockEntity.Name = "TestCategory";

            // Act
            var category = new UserCategory(mockEntity);

            // Assert
            Assert.Equal(guid, category.Id);
            Assert.Equal("TestCategory", category.Name);
        }

        [Fact]
        public void Id_Setter_UpdatesEntityId()
        {
            // Arrange
            var mockEntity = new UserCategoryEntity();
            var newGuid = Guid.NewGuid();
            mockEntity.Id = newGuid;
            var category = new UserCategory(mockEntity);
            

            // Act
            category.Id = newGuid;

            // Assert
            Assert.Equal(newGuid, mockEntity.Id);
        }

        [Fact]
        public void Name_Setter_UpdatesEntityName()
        {
            // Arrange
            var mockEntity = new UserCategoryEntity();
            mockEntity.Name = "Original Name";
            var category = new UserCategory(mockEntity);

            // Act
            category.Name = "UpdatedName";

            // Assert
            Assert.Equal("UpdatedName", mockEntity.Name);
        }

        [Fact]
        public void ToString_ReturnsExpectedFormat()
        {
            // Arrange
            var guid = Guid.NewGuid();
            var mockEntity = new UserCategoryEntity();
            mockEntity.Id = guid;
            mockEntity.Name = "CategoryName";
            var category = new UserCategory(mockEntity);

            // Act
            var result = category.ToString();

            // Assert
            Assert.Equal($"{guid} - CategoryName", result);
        }

        [Fact]
        public void Id_Getter_ReturnsGuidEmpty_WhenEntityIsNull()
        {
            // Arrange
            var category = new UserCategory();

            // Act
            var id = category.CategoryId;

            // Assert
            Assert.Equal(Guid.Empty, id);
        }

        [Fact]
        public void Name_Getter_ReturnsNull_WhenEntityIsNull()
        {
            // Arrange
            var category = new UserCategory();

            // Act
            var name = category.Name;

            // Assert
            Assert.Null(name);
        }
    }
}