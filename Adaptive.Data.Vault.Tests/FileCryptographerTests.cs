using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Adaptive.Data.Vault;
using Adaptive.Intelligence.Shared.Security;
using Xunit;

namespace Adaptive.Data.Vault.Tests
{
    public class FileCryptographerTests : IDisposable
    {
        private readonly string _testInputFile;
        private readonly string _testEncryptedFile;
        private readonly string _testDecryptedFile;

        public FileCryptographerTests()
        {
            _testInputFile = Path.GetTempFileName();
            _testEncryptedFile = Path.GetTempFileName();
            _testDecryptedFile = Path.GetTempFileName();
        }

        [Fact]
        public void EncryptFile_And_DecryptFile_ShouldRestoreOriginalContent()
        {
            // Arrange
            string originalText = "Sensitive test data for encryption.";
            File.WriteAllText(_testInputFile, originalText, Encoding.UTF8);

            var cryptographer = new FileCryptographer("primaryKey", "secondaryKey", 1234);

            // Act
            var encryptResult = cryptographer.EncryptFile(_testInputFile, _testEncryptedFile);
            var decryptResult = cryptographer.DecryptFile(_testEncryptedFile, _testDecryptedFile);

            // Assert
            Assert.True(encryptResult.Success, "Encryption should succeed.");
            Assert.True(decryptResult.Success, "Decryption should succeed.");
            string decryptedText = File.ReadAllText(_testDecryptedFile, Encoding.UTF8);
            Assert.Equal(originalText, decryptedText);
        }

        [Fact]
        public async Task EncryptFileAsync_And_DecryptFileAsync_ShouldRestoreOriginalContent()
        {
            // Arrange
            string originalText = "Async sensitive test data for encryption.";
            File.WriteAllText(_testInputFile, originalText, Encoding.UTF8);

            var cryptographer = new FileCryptographer("primaryKey", "secondaryKey", 5678);

            // Act
            var encryptResult = await cryptographer.EncryptFileAsync(_testInputFile, _testEncryptedFile);
            var decryptResult = await cryptographer.DecryptFileAsync(_testEncryptedFile, _testDecryptedFile);

            // Assert
            Assert.True(encryptResult.Success, "Async encryption should succeed.");
            Assert.True(decryptResult.Success, "Async decryption should succeed.");
            string decryptedText = File.ReadAllText(_testDecryptedFile, Encoding.UTF8);
            Assert.Equal(originalText, decryptedText);
        }

        public void Dispose()
        {
            File.Delete(_testInputFile);
            File.Delete(_testEncryptedFile);
            File.Delete(_testDecryptedFile);
        }
    }
}