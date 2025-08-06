using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.IO;
using Adaptive.Intelligence.Shared.Logging;
using System.Security.Cryptography;

namespace Adaptive.Data.Vault
{
    /// <summary>
    /// Provides the mechanism to perform a secure deletion operation on a file or batch
    /// of files.
    /// </summary>
    /// <seealso cref="Adaptive.Intelligence.Shared.DisposableObjectBase" />
    public sealed class SecureDeleteClient : DisposableObjectBase
    {
        #region Public Events
        /// <summary>
        /// Occurs when the status is to be updated in the UI.
        /// </summary>
        public event ProgressUpdateEventHandler StatusUpdate;
        #endregion

        #region Constructor / Dispose Methods
        public SecureDeleteClient()
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        #endregion

        #region Public Properties
        #endregion

        #region Event Methods
        /// <summary>
        /// Raises the <see cref="E:StatusUpdate" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void OnStatusUpdate(ProgressUpdateEventArgs e)
        {
            try
            {
                StatusUpdate?.Invoke(this, e);
            }
            catch(Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }
        #endregion

        #region Public Methods / Functions
        /// <summary>
        /// Securely deletes the specified file.
        /// </summary>
        /// <param name="fileName">
        /// A string containing the fully-qualified path and name of the file to delete.
        /// Name of the file.</param>
        public async Task SecureDeleteFileAsync(string fileName)
        {
            OnStatusUpdate(new ProgressUpdateEventArgs("Starting...", 0));

            if (SafeIO.FileExists(fileName))
            {
                // DOD 5220.22-M 7 Pass Wipe
                OnStatusUpdate(new ProgressUpdateEventArgs("Pass 1...", 12));
                await PerformDoDPassOneAsync(fileName).ConfigureAwait(false);

                OnStatusUpdate(new ProgressUpdateEventArgs("Pass 2...", 24));
                await PerformDoDPassTwoAsync(fileName).ConfigureAwait(false);

                OnStatusUpdate(new ProgressUpdateEventArgs("Pass 3...", 36));
                await PerformDoDPassThreeAsync(fileName).ConfigureAwait(false);

                OnStatusUpdate(new ProgressUpdateEventArgs("Pass 4...", 49));
                await PerformDoDPassOneAsync(fileName).ConfigureAwait(false);

                OnStatusUpdate(new ProgressUpdateEventArgs("Pass 5...", 61));
                await PerformDoDPassTwoAsync(fileName).ConfigureAwait(false);

                OnStatusUpdate(new ProgressUpdateEventArgs("Pass 6...", 73));
                await PerformDoDPassThreeAsync(fileName).ConfigureAwait(false);

                OnStatusUpdate(new ProgressUpdateEventArgs("Pass 7...", 86));
                await PerformRandomPassAsync(fileName).ConfigureAwait(false);

                OnStatusUpdate(new ProgressUpdateEventArgs("Pass 8...", 94));
                await PerformDoDPassThreeAsync(fileName).ConfigureAwait(false);

                // Delete the original.
                SafeIO.DeleteFile(fileName);

                // Create a fake for the MFT.
                await CreateFakeFileAsync(fileName).ConfigureAwait(false);

                // Delete the fake.
                SafeIO.DeleteFile(fileName);
            }

            OnStatusUpdate(new ProgressUpdateEventArgs("Completed...", 100));
            
            // Slight delay for the UI update.
            await Task.Delay(100);
        }
        #endregion

        #region Private Methods / Functions
        /// <summary>
        /// Overwrites the specified file with all zeros for each bit.
        /// </summary>
        /// <param name="fileName">
        /// A string containing the fully-qualified path and name of the file.
        /// </param>
        private async Task PerformDoDPassOneAsync(string fileName)
        {
            long length = SafeIO.GetFileSize(fileName);
            FileStream? stream = SafeIO.OpenFileForExclusiveWrite(fileName);
            if (stream != null)
            {
                await WriteDataAsync(stream, length, 0).ConfigureAwait(false);

                stream.Flush();
                stream.Dispose();
            }
        }
        /// <summary>
        /// Overwrites the specified file with all ones for each bit.
        /// </summary>
        /// <param name="fileName">
        /// A string containing the fully-qualified path and name of the file.
        /// </param>
        private async Task PerformDoDPassTwoAsync(string fileName)
        {
            long length = SafeIO.GetFileSize(fileName);
            FileStream? stream = SafeIO.OpenFileForExclusiveWrite(fileName);
            if (stream != null)
            {
                await WriteDataAsync(stream, length, 255).ConfigureAwait(false);

                stream.Flush();
                stream.Dispose();
            }
        }

        private async Task PerformDoDPassThreeAsync(string fileName)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] randomChar = new byte[1] { 0 };
            rng.GetBytes(randomChar);

            long length = SafeIO.GetFileSize(fileName);
            FileStream? stream = SafeIO.OpenFileForExclusiveWrite(fileName);
            if (stream != null)
            {
                await WriteDataAsync(stream, length, randomChar[0]).ConfigureAwait(false);

                stream.Flush();
                stream.Dispose();
            }
            rng.Dispose();
        }
        private async Task PerformRandomPassAsync(string fileName)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] randomChar = new byte[1] { 0 };
            rng.GetBytes(randomChar);

            long length = SafeIO.GetFileSize(fileName);
            FileStream? stream = SafeIO.OpenFileForExclusiveWrite(fileName);
            if (stream != null)
            {
                await WriteRandomDataAsync(stream, length).ConfigureAwait(false);

                stream.Flush();
                stream.Dispose();
            }
            rng.Dispose();
        }
        private async Task CreateFakeFileAsync(string fileName)
        {
            if (File.Exists(fileName))
                SafeIO.DeleteFile(fileName);

            FileStream? stream = SafeIO.CreateFileForExclusiveWrite(fileName);
            if (stream != null)
            {
                byte[] randomData = RandomNumberGenerator.GetBytes(5100);
                stream.Write(randomData, 0, randomData.Length);
                stream.Flush();
                stream.Dispose();
            }
        }

        private async Task WriteDataAsync(Stream destinationStream, long length, byte character)
        {
            int blocks = (int)((length / (long)1024));
            int remainder = (int)(length % 1024);

            byte[] data = new byte[1024];
            byte[] lastBlock = new byte[remainder];
            Array.Fill<byte>(data, character);
            Array.Fill<byte>(lastBlock, character);

            for (int count = 0; count < blocks; count++)
            {
                await destinationStream.WriteAsync(data, 0, data.Length).ConfigureAwait(false);
                await destinationStream.FlushAsync().ConfigureAwait(false);
            }

            await destinationStream.WriteAsync(lastBlock, 0, lastBlock.Length);
            await destinationStream.FlushAsync().ConfigureAwait(false);

            ByteArrayUtil.Clear(data);
            ByteArrayUtil.Clear(lastBlock);
        }

        private async Task WriteRandomDataAsync(Stream destinationStream, long length)
        {
            int blocks = (int)((length / (long)1024));
            int remainder = (int)(length % 1024);

            byte[] data = RandomNumberGenerator.GetBytes(1024);
            byte[] lastBlock = RandomNumberGenerator.GetBytes(remainder);


            for (int count = 0; count < blocks; count++)
            {
                await destinationStream.WriteAsync(data, 0, data.Length).ConfigureAwait(false);
                await destinationStream.FlushAsync().ConfigureAwait(false);
            }

            await destinationStream.WriteAsync(lastBlock, 0, lastBlock.Length);
            await destinationStream.FlushAsync().ConfigureAwait(false);

            ByteArrayUtil.Clear(data);
            ByteArrayUtil.Clear(lastBlock);
        }
        #endregion
    }
}
