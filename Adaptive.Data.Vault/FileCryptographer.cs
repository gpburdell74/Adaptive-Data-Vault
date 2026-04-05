using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.IO;
using Adaptive.Intelligence.Shared.Security;

namespace Adaptive.Data.Vault
{
    /// <summary>
    /// Performs tasks for encrypting and decrypting files.
    /// </summary>
    /// <seealso cref="Adaptive.Intelligence.Shared.ExceptionTrackingBase" />
    public sealed class FileCryptographer : ExceptionTrackingBase
    {
        #region Public Events
        /// <summary>
        /// Occurs to update a caller on the progress of the operation.
        /// </summary>
        public event ProgressUpdateEventHandler? CryptoProgress;

        /// <summary>
        /// Occurs when the decryption process is complete.
        /// </summary>
        public event ProgressUpdateEventHandler? DecryptionComplete;

        /// <summary>
        /// Occurs when the decryption process starts.
        /// </summary>
        public event ProgressUpdateEventHandler? DecryptionStart;

        /// <summary>
        /// Occurs when the encryption process is complete.
        /// </summary>
        public event ProgressUpdateEventHandler? EncryptionComplete;

        /// <summary>
        /// Occurs when the encryption process starts.
        /// </summary>
        public event ProgressUpdateEventHandler? EncryptionStart;
        #endregion

        #region Event Methods
        /// <summary>
        /// Raises the <see cref="E:CryptoProgress" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void OnCryptoProgress(ProgressUpdateEventArgs e)
        {
            CryptoProgress?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:DecryptionComplete" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void OnDecryptionComplete(ProgressUpdateEventArgs e)
        {
            DecryptionComplete?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:DecryptionStart" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void OnDecryptionStart(ProgressUpdateEventArgs e)
        {
            DecryptionStart?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:EncryptionComplete" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void OnEncryptionComplete(ProgressUpdateEventArgs e)
        {
            EncryptionComplete?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:EncryptionStart" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void OnEncryptionStart(ProgressUpdateEventArgs e)
        {
            EncryptionStart?.Invoke(this, e);
        }
        #endregion

        #region Private Member Declarations
        /// <summary>
        /// The cryptography instance.
        /// </summary>
        private SuperCrypt? _crypt;

        /// <summary>
        /// The source file to read from.
        /// </summary>
        private FileStream? _sourceFile;

        /// <summary>
        /// The destination file to write to.
        /// </summary>
        private FileStream? _destFile;

        /// <summary>
        /// The reader for reading from an encrypted file.
        /// </summary>
        private SafeBinaryReader? _reader;

        /// <summary>
        /// The writer for writing to an encrypted file.
        /// </summary>
        private SafeBinaryWriter? _writer;
        #endregion

        #region Constructor / Dispose Methods        
        /// <summary>
        /// Initializes a new instance of the <see cref="FileCryptographer"/> class.
        /// </summary>
        /// <param name="primaryKey">
        /// A string containing the primary encryption key source data.
        /// </param>
        /// <param name="secondaryKey">
        /// A string containing the secondary encryption key source data.
        /// </param>
        /// <param name="pin">
        /// An integer specifying the PIN value for creating key data.
        /// </param>
        public FileCryptographer(string primaryKey, string secondaryKey, int pin)
        {
            _crypt = new SuperCrypt(primaryKey, secondaryKey, pin);
        }
        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
        /// <b>false</b> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (!IsDisposed && disposing)
            {
                _crypt?.Dispose();
                _sourceFile?.Dispose();
                _destFile?.Dispose();
                _reader?.Dispose();
                _writer?.Dispose();
            }
            _crypt = null;
            _sourceFile = null;
            _destFile = null;
            _writer = null;
            _reader = null;

            base.Dispose(disposing);
        }
        #endregion

        #region Public Methods / Functions
        /// <summary>
        /// Decrypts the content of the source file into the destination file.
        /// </summary>
        /// <param name="sourceFileName">
        /// A string containing the fully-qualified path and name of the source file the encrypted content will be read from.
        /// </param>
        /// <param name="destinationFileName">
        /// A string containing the fully-qualified path and name of the source file the clear content will be written to.
        /// </param>
        /// <returns>
        /// An <see cref="IOperationalResult"/> instance containing the result of the operation.
        /// </returns>
        public IOperationalResult DecryptFile(string sourceFileName, string destinationFileName)
        {
            OperationalResult result = new OperationalResult();

            OnDecryptionStart(new ProgressUpdateEventArgs("Decryption process started.", 0));
            OpenSourceFile(sourceFileName, result);
            if (result.Success)
            {
                OpenDestinationFile(destinationFileName, result);
                if (result.Success)
                {
                    PerformFileDecryption(result);
                    CloseDestinationFile();
                }
                CloseSourceFile();
            }
            OnDecryptionComplete(new ProgressUpdateEventArgs("Decryption process completed.", 100));
            return result;
        }

        /// <summary>
        /// Decrypts the content of the source file into the destination file.
        /// </summary>
        /// <param name="sourceFileName">
        /// A string containing the fully-qualified path and name of the source file the encrypted content will be read from.
        /// </param>
        /// <param name="destinationFileName">
        /// A string containing the fully-qualified path and name of the source file the clear content will be written to.
        /// </param>
        /// <returns>
        /// An <see cref="IOperationalResult"/> instance containing the result of the operation.
        /// </returns>
        public async Task<IOperationalResult> DecryptFileAsync(string sourceFileName, string destinationFileName)
        {
            OperationalResult result = new OperationalResult();

            OnDecryptionStart(new ProgressUpdateEventArgs("Decryption process started.", 0));
            OpenSourceFile(sourceFileName, result);
            if (result.Success)
            {
                OpenDestinationFile(destinationFileName, result);
                if (result.Success)
                {
                    await PerformFileDecryptionAsync(result).ConfigureAwait(false);
                    await CloseDestinationFileAsync().ConfigureAwait(false);
                }
                await CloseSourceFileAsync().ConfigureAwait(false);
            }
            OnDecryptionComplete(new ProgressUpdateEventArgs("Decryption process completed.", 100));
            return result;
        }

        /// <summary>
        /// Encrypts the content of the source file into the destination file.
        /// </summary>
        /// <param name="sourceFileName">
        /// A string containing the fully-qualified path and name of the source file the clear content will be read from.
        /// </param>
        /// <param name="destinationFileName">
        /// A string containing the fully-qualified path and name of the source file the encrypted content will be written to.
        /// </param>
        /// <returns>
        /// An <see cref="IOperationalResult"/> instance containing the result of the operation.
        /// </returns>
        public IOperationalResult EncryptFile(string sourceFileName, string destinationFileName)
        {
            OperationalResult result = new OperationalResult();

            OnEncryptionStart(new ProgressUpdateEventArgs("Encryption process started.", 0));
            OpenSourceFile(sourceFileName, result);
            if (result.Success)
            {
                OpenDestinationFile(destinationFileName, result);
                if (result.Success)
                {
                    PerformFileEncryption(result);
                    CloseDestinationFile();
                }
                CloseSourceFile();
            }
            OnEncryptionComplete(new ProgressUpdateEventArgs("Encryption process completed.", 100));
            return result;
        }

        /// <summary>
        /// Encrypts the content of the source file into the destination file.
        /// </summary>
        /// <param name="sourceFileName">
        /// A string containing the fully-qualified path and name of the source file the clear content will be read from.
        /// </param>
        /// <param name="destinationFileName">
        /// A string containing the fully-qualified path and name of the source file the encrypted content will be written to.
        /// </param>
        /// <returns>
        /// An <see cref="IOperationalResult"/> instance containing the result of the operation.
        /// </returns>
        public async Task<IOperationalResult> EncryptFileAsync(string sourceFileName, string destinationFileName)
        {
            OperationalResult result = new OperationalResult();

            OnEncryptionStart(new ProgressUpdateEventArgs("Encryption process started.", 0));
            await Task.Yield();

            OpenSourceFile(sourceFileName, result);
            if (result.Success)
            {
                OpenDestinationFile(destinationFileName, result);
                if (result.Success)
                {
                    await PerformFileEncryptionAsync(result).ConfigureAwait(false);
                    await CloseDestinationFileAsync().ConfigureAwait(false);
                }
                await CloseSourceFileAsync().ConfigureAwait(false);

            }
            OnEncryptionComplete(new ProgressUpdateEventArgs("Encryption process completed.", 100));
            return result;
        }
        #endregion

        #region Private Methods / Functions
        /// <summary>
        /// Closes the destination file.
        /// </summary>
        private void CloseDestinationFile()
        {
            _destFile?.Flush();
            _destFile?.Close();
            _destFile?.Dispose();
            _destFile = null;
        }

        /// <summary>
        /// Closes the destination file.
        /// </summary>
        private async Task CloseDestinationFileAsync()
        {
            if (_destFile != null)
            {
                await _destFile.FlushAsync().ConfigureAwait(false);
                _destFile.Close();
                await _destFile.DisposeAsync().ConfigureAwait(false);
            }
            _destFile = null;
        }

        /// <summary>
        /// Closes the source file.
        /// </summary>
        private void CloseSourceFile()
        {
            _sourceFile?.Flush();
            _sourceFile?.Close();
            _sourceFile?.Dispose();
            _sourceFile = null;
        }

        /// <summary>
        /// Closes the source file.
        /// </summary>
        private async Task CloseSourceFileAsync()
        {
            if (_sourceFile != null)
            {
                await _sourceFile.FlushAsync().ConfigureAwait(false);
                _sourceFile.Close();
                await _sourceFile.DisposeAsync().ConfigureAwait(false);
            }
            _sourceFile = null;
        }

        /// <summary>
        /// Attempts to open the source file.
        /// </summary>
        /// <param name="fileName">
        /// A string containing the fully-qualified path and name of the file to be opened.
        /// </param>
        /// <param name="result">
        /// An <see cref="OperationalResult"/> containing the result of the operation.
        /// </param>
        private void OpenSourceFile(string fileName, OperationalResult result)
        {
            if (SafeIO.FileExists(fileName))
            {
                try
                {
                    _sourceFile = SafeIO.OpenFileForExclusiveRead(fileName);
                    _reader = new SafeBinaryReader(_sourceFile!);
                    result.Success = true;
                }
                catch (Exception ex)
                {
                    result.AddException(ex);
                    result.SetFailureMessage($"Failed to open source file: {fileName}.");
                    _sourceFile = null;
                }
            }
        }

        /// <summary>
        /// Attempts to create and open the destination file.
        /// </summary>
        /// <param name="fileName">
        /// A fully-qualified path and name of the file to be created and opened.
        /// </param>
        /// <param name="result">
        /// The <see cref="OperationalResult"/> containing the result of the operation.
        /// </param>
        private void OpenDestinationFile(string fileName, OperationalResult result)
        {
            if (SafeIO.FileExists(fileName))
            {
                SafeIO.DeleteFile(fileName);
            }

            try
            {
                _destFile = SafeIO.CreateFileForExclusiveWrite(fileName);
                _writer = new SafeBinaryWriter(_destFile!);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.AddException(ex);
                result.SetFailureMessage($"Failed to open destination file: {fileName}.");
                _destFile = null;
            }
        }

        /// <summary>
        /// Performs the task of decrypting the content of the source file and writing the 
        /// result to the destination file.
        /// </summary>
        /// <param name="result">
        /// An <see cref="OperationalResult"/> containing the result of the operation.
        /// </param>
        private void PerformFileDecryption(OperationalResult result)
        {
            result.Success = true;
            ValidateFileSystemObjects(result);
            if (result.Success)
            { 
                do
                {
                    // Read the specified chunk.
                    int length = _reader!.ReadInt32();
                    byte[]? data = _reader.ReadBytes(length);
                    if (data == null)
                    {
                        result.SetFailureMessage("Could not read data from source file.");
                    }
                    else
                    {
                        byte[]? clearData = _crypt!.Decrypt(data);
                        if (clearData == null)
                        {
                            result.SetFailureMessage("Decryption operation failed.");
                        }
                        else
                        {
                            _destFile!.Write(clearData, 0, clearData.Length);
                            _destFile.Flush();
                        }
                        CryptoUtil.SecureClear(clearData);
                    }
                    CryptoUtil.SecureClear(data);

                    int percent = (int)(((float)_sourceFile!.Position / (float)_sourceFile.Length) * 100);
                    OnCryptoProgress(new ProgressUpdateEventArgs("Decryption Progress...", percent));
                } while (result.Success && _sourceFile!.Position < _sourceFile.Length);
            }
        }

        /// <summary>
        /// Performs the task of decrypting the content of the source file and writing the 
        /// result to the destination file.
        /// </summary>
        /// <param name="result">
        /// An <see cref="OperationalResult"/> containing the result of the operation.
        /// </param>
        private async Task PerformFileDecryptionAsync(OperationalResult result)
        {
            result.Success = true;
            ValidateFileSystemObjects(result);
            if (result.Success)
            { 
                do
                {
                    // Read the specified chunk.
                    int length = _reader!.ReadInt32();
                    byte[]? data = _reader!.ReadBytes(length);
                    if (data == null)
                    {
                        result.SetFailureMessage("Could not read data from source file.");
                    }
                    else
                    {
                        byte[]? clearData = _crypt!.Decrypt(data);
                        if (clearData == null)
                        {
                            result.SetFailureMessage("Decryption operation failed.");
                        }
                        else
                        {
                            await _destFile!.WriteAsync(clearData, 0, clearData.Length).ConfigureAwait(false);
                            await _destFile.FlushAsync().ConfigureAwait(false);
                        }
                        CryptoUtil.SecureClear(clearData);
                    }
                    CryptoUtil.SecureClear(data);
                    int percent = (int)(((float)_sourceFile!.Position / (float)_sourceFile.Length) * 100);
                    OnCryptoProgress(new ProgressUpdateEventArgs("Decryption Progress...", percent));
                } while (result.Success && _sourceFile!.Position < _sourceFile.Length);
            }
        }

        /// <summary>
        /// Performs the process of encrypting the content of the source file and writing the result
        /// into the destination file.
        /// </summary>
        /// <param name="result">
        /// An <see cref="OperationalResult"/> containing the result of the operation.
        /// </param>
        private void PerformFileEncryption(OperationalResult result)
        {
            result.Success = true;
            ValidateFileSystemObjects(result);
            if (result.Success)
            { 
                // Create the main read buffer.
                int bufferSize = 4194304;
                byte[] dataBuffer = new byte[bufferSize];
                Array.Clear(dataBuffer, 0, bufferSize);

                int bytesRead = 0;
                int totalBytes = (int)_sourceFile!.Length;

                do
                {
                    int readCount = 0;
                    try
                    {
                        // Read the clear data into the buffer.
                        readCount = _sourceFile.Read(dataBuffer, 0, dataBuffer.Length);
                    }
                    catch (Exception ex)
                    {
                        result.Success = false;
                        result.AddException(ex);
                    }
                    bytesRead += readCount;


                    if (readCount > 0 && result.Success)
                    {
                        // Re-size the array if needed and copy the buffer data, and clear
                        // the original buffer.
                        byte[] dataRead = new byte[readCount];
                        Array.Copy(dataBuffer, dataRead, readCount);

                        // Perform the encryption process.
                        if (_crypt != null)
                        {
                            byte[]? dataToWrite = _crypt.Encrypt(dataRead);

                            // Write the content.
                            PerformEncryptedDataWrite(result, dataToWrite);

                            // Clear memory.
                            CryptoUtil.SecureClear(dataToWrite);
                        }
                        CryptoUtil.SecureClear(dataRead);
                    }
                    else
                    {
                        result.Success = false;
                        result.SetFailureMessage("No data read from source file.");
                    }
                    int percent = (int)(((float)bytesRead / (float)totalBytes) * 100);
                    OnCryptoProgress(new ProgressUpdateEventArgs("Encryption Progress...", percent));
                } while (result.Success && bytesRead < totalBytes);

                CryptoUtil.SecureClear(dataBuffer);
            }
        }

        /// <summary>
        /// Performs the process of encrypting the content of the source file and writing the result
        /// into the destination file.
        /// </summary>
        /// <param name="result">
        /// An <see cref="OperationalResult"/> containing the result of the operation.
        /// </param>
        private async Task PerformFileEncryptionAsync(OperationalResult result)
        {
            await Task.Yield();
            result.Success = true;
            ValidateFileSystemObjects(result);
            if (result.Success)
            {
                // Create the main read buffer.
                int bufferSize = 4194304;
                byte[] dataBuffer = new byte[bufferSize];
                Array.Clear(dataBuffer, 0, bufferSize);

                int bytesRead = 0;
                int totalBytes = (int)_sourceFile!.Length;

                do
                {
                    int readCount = 0;
                    try
                    {
                        // Read the clear data into the buffer.
                        readCount = await _sourceFile.ReadAsync(dataBuffer, 0, dataBuffer.Length).ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        result.Success = false;
                        result.AddException(ex);
                    }
                    bytesRead += readCount;


                    if (readCount > 0 && result.Success)
                    {
                        // Re-size the array if needed and copy the buffer data, and clear
                        // the original buffer.
                        byte[] dataRead = new byte[readCount];
                        Array.Copy(dataBuffer, dataRead, readCount);

                        // Perform the encryption process.
                        byte[]? dataToWrite = _crypt!.Encrypt(dataRead);

                        // Write the content.
                        PerformEncryptedDataWrite(result, dataToWrite);
                        await _destFile!.FlushAsync().ConfigureAwait(false);

                        // Clear memory.
                        CryptoUtil.SecureClear(dataToWrite);
                        CryptoUtil.SecureClear(dataRead);
                    }
                    else
                    {
                        result.Success = false;
                        result.SetFailureMessage("No data read from source file.");
                    }
                    int percent = (int)(((float)bytesRead / (float)totalBytes) * 100);
                    OnCryptoProgress(new ProgressUpdateEventArgs("Encryption Progress...", percent));
                } while (result.Success && bytesRead < totalBytes);
                CryptoUtil.SecureClear(dataBuffer);
            }
        }

        /// <summary>
        /// Performs the task of writing the encrypted data to the destination file stream.
        /// </summary>
        /// <param name="result">
        /// An <see cref="OperationalResult"/> containing the result of the operation.
        /// </param>
        /// <param name="dataToWrite">
        /// A byte array containing the data to be written.
        /// </param>
        private void PerformEncryptedDataWrite(OperationalResult result, byte[]? dataToWrite)
        {
            if (result.Success && _writer != null && dataToWrite != null && dataToWrite.Length >= 0)
            {
                try
                {
                    // Write the size of the encrypted data.
                    _writer.Write((int)dataToWrite.Length);

                    // Write the encrypted data.
                    _writer.Write(dataToWrite);
                    _writer.Flush();

                    // Clear the array.
                    Array.Clear(dataToWrite);
                }
                catch (Exception ex)
                {
                    result.AddException(ex);
                    result.Success = false;
                }
            }
        }

        /// <summary>
        /// Validates that the file system objects are created and valid for use.
        /// </summary>
        /// <param name="result">
        /// An <see cref="OperationalResult"/> containing the result of the operation.
        /// </param>
        private void ValidateFileSystemObjects(OperationalResult result)
        {
            if (_crypt == null)
            {
                result.SetFailureMessage("Cryptographic engine is not initialized.");
            }
            else if (_sourceFile == null)
            {
                result.SetFailureMessage("Source file is not open or does not exist.");
            }
            else if (_destFile == null)
            {
                result.SetFailureMessage("Destination file is not open or does not exist.");
            }
            else if (!_sourceFile.CanRead)
            {
                result.SetFailureMessage("Source file cannot be read from.");
            }
            else if (!_destFile.CanWrite)
            {
                result.SetFailureMessage("Destination file cannot be written to.");
            }
            else if (_reader == null)
            {
                result.SetFailureMessage("Cannot read from the source file.");
            }
            else
            {
                result.Success = true;
            }
        }
        #endregion
    }
}
