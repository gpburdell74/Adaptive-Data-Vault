using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.Logging;

namespace Adaptive.Data.Vault.Tests
{
    public class SecureDeleteClientTests
    {
        [Fact]
        public async Task SecureDeleteFileAsync_FileDoesNotExist_OnlyStartAndCompleteEventsRaised()
        {
            // Arrange
            var client = new SecureDeleteClient();
            string fileName = "nonexistentfile.txt";
            int eventCount = 0;
            client.StatusUpdate += (s, e) => eventCount++;

            // Act
            await client.SecureDeleteFileAsync(fileName);

            // Assert
            Assert.Equal(2, eventCount); // "Starting..." and "Completed..."
        }

        [Fact]
        public async Task SecureDeleteFileAsync_FileExists_AllPassesAndEventsRaised()
        {
            // Arrange
            var client = new SecureDeleteClient();
            string fileName = "testfile.txt";
            int eventCount = 0;
            client.StatusUpdate += (s, e) => eventCount++;

            // Setup file
            File.WriteAllBytes(fileName, new byte[2048]);

            // Act
            await client.SecureDeleteFileAsync(fileName);

            // Assert
            Assert.True(eventCount >= 2); // At least "Starting..." and "Completed..."
            Assert.False(File.Exists(fileName));
        }

        [Fact]
        public async Task SecureDeleteFileAsync_StatusUpdateEvent_RaisedWithCorrectProgress()
        {
            // Arrange
            var client = new SecureDeleteClient();
            string fileName = "testfile2.txt";
            int lastProgress = 0;
            client.StatusUpdate += (s, e) => lastProgress = e.PercentDone;

            File.WriteAllBytes(fileName, new byte[1024]);

            // Act
            await client.SecureDeleteFileAsync(fileName);

            // Assert
            Assert.Equal(100, lastProgress);
        }

        [Fact]
        public void OnStatusUpdate_ExceptionInHandler_LogsException()
        {
            // Arrange
            var client = new SecureDeleteClient();
            bool logCalled = false;
            client.StatusUpdate += (s, e) => throw new InvalidOperationException();

            // Act
            client.GetType().GetMethod("OnStatusUpdate", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(client, new object[] { new ProgressUpdateEventArgs("Test", 0) });

            // Assert
            Assert.True(logCalled);
        }
    }
}