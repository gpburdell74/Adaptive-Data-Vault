using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.Tests
{
    public class SecureNoteTests
    {
        [Fact]
        public void DefaultConstructor_InitializesWithNullEntity()
        {
            // Arrange & Act
            var note = new SecureNote();

            // Assert
            Assert.Null(note.Name);
            Assert.Null(note.SecureContent);
        }

        [Fact]
        public void Constructor_WithEntity_SetsPropertiesCorrectly()
        {
            // Arrange
            var mockEntity = new SecureNoteEntity();
            mockEntity.Name = "Test Note";
            mockEntity.SecureContent = "Secret Content";

            // Act
            var note = new SecureNote(mockEntity);

            // Assert
            Assert.Equal("Test Note", note.Name);
            Assert.Equal("Secret Content", note.SecureContent);
        }

        [Fact]
        public void Name_Setter_UpdatesEntityName()
        {
            // Arrange
            var mockEntity = new SecureNoteEntity();
            mockEntity.Name = "Original Name";
            var note = new SecureNote(mockEntity);

            // Act
            note.Name = "Updated Name";

            // Assert
            Assert.Equal("Updated Name", mockEntity.Name);
        }

        [Fact]
        public void SecureContent_Setter_UpdatesEntitySecureContent()
        {
            // Arrange
            var mockEntity = new SecureNoteEntity();
            mockEntity.SecureContent = "Original Content";
            var note = new SecureNote(mockEntity);

            // Act
            note.SecureContent = "Updated Content";

            // Assert
            Assert.Equal("Updated Content", mockEntity.SecureContent);
        }

        [Fact]
        public void Name_Getter_ReturnsNull_WhenEntityIsNull()
        {
            // Arrange
            var note = new SecureNote();

            // Act & Assert
            Assert.Null(note.Name);
        }

        [Fact]
        public void SecureContent_Getter_ReturnsNull_WhenEntityIsNull()
        {
            // Arrange
            var note = new SecureNote();

            // Act & Assert
            Assert.Null(note.SecureContent);
        }
    }
}