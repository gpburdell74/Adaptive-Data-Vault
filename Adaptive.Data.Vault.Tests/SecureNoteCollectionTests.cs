using Adaptive.Data.Vault.Entities;
using Moq;

namespace Adaptive.Data.Vault.Tests
{
    public class SecureNoteCollectionTests
    {
        [Fact]
        public void DefaultConstructor_CreatesEmptyCollection()
        {
            // Act
            var collection = new SecureNoteCollection();

            // Assert
            Assert.Empty(collection);
        }

        [Fact]
        public void Constructor_WithSourceList_PopulatesCollection()
        {
            // Arrange
            var mockEntity1 = new SecureNoteEntity();
            mockEntity1.Name = "Note1";
            var mockEntity2 = new SecureNoteEntity();
            mockEntity2.Name = "Note2";
            var sourceList = new List<SecureNoteEntity> { mockEntity1, mockEntity2 };

            // Act
            var collection = new SecureNoteCollection(sourceList);

            // Assert
            Assert.Equal(2, collection.Count);
            Assert.Contains(collection, n => n.Name == "Note1");
            Assert.Contains(collection, n => n.Name == "Note2");
        }

        [Fact]
        public void AddSecureNote_AddsNoteToCollection()
        {
            // Arrange
            var collection = new SecureNoteCollection();

            // Act
            collection.AddSecureNote("TestName", "TestDescription", "TestContent");

            // Assert
            Assert.Single(collection);
            Assert.Equal("TestName", collection[0].Name);
            Assert.Equal("TestContent", collection[0].SecureContent);
        }

        [Fact]
        public void SortAlpha_SortsNotesAlphabeticallyByName()
        {
            // Arrange
            var collection = new SecureNoteCollection();
            collection.AddSecureNote("Charlie", "desc", "content");
            collection.AddSecureNote("alpha", "desc", "content");
            collection.AddSecureNote("Bravo", "desc", "content");

            // Act
            collection.SortAlpha();

            // Assert
            Assert.Equal("alpha", collection[0].Name, ignoreCase: true);
            Assert.Equal("Bravo", collection[1].Name, ignoreCase: true);
            Assert.Equal("Charlie", collection[2].Name, ignoreCase: true);
        }
    }
}