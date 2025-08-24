using Adaptive.Data.Vault.DataAccess.IO.Cryptographic;
using Adaptive.Data.Vault.Entities;
using Adaptive.Data.Vault.IO;
using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.IO;
using Adaptive.Intelligence.Shared.Logging;
using Adaptive.Intelligence.Shared.Security;

namespace Adaptive.Data.Vault.DataAccess.IO;

/// <summary>
/// Provides the methods and functions for securely reading and writing the vault files.
/// </summary>
/// <seealso cref="DisposableObjectBase" />
/// <seealso cref="IVaultFile" />
public sealed class VaultFile : DisposableObjectBase, IVaultFile
{
    #region Public Methods / Functions
    /// <summary>
    /// Attempts to load the data set from a specified file.
    /// </summary>
    /// <param name="fileName">A string containing the fully-qualified path and name of the file.</param>
    /// <param name="userId">A string containing the user identifier/ user name for cryptographic access.</param>
    /// <param name="password">A string containing the password value for cryptographic access.</param>
    /// <param name="pin">An integer containing the user PIN value for cryptographic access.</param>
    /// <returns>
    /// An <see cref="IEntityDataSet" /> instance if successful; otherwise, returns
    /// <b>null</b>.
    /// </returns>
    public IEntityDataSet? LoadDataSet(string fileName, string userId, string password, int pin)
    {
        IEntityDataSet? dataSet = null;

        // Open the file.
        FileStream? stream = OpenFile(fileName);
        if (stream != null)
        {
            byte[] content = new byte[(int)stream.Length];
            stream.ReadExactly(content, 0, content.Length);
            stream.Dispose();

            SuperCrypt crypt = new SuperCrypt(userId, password, pin);
            byte[]? clearData = crypt.Decrypt(content);

            if (clearData != null)
            {
                MemoryStream ms = new MemoryStream(clearData);

                dataSet = LoadDataSet(ms, userId, password, pin);

                ms.Dispose();
                Array.Clear(clearData, 0, clearData.Length);
            }
            
            Array.Clear(content, 0, content.Length);
        }

        return dataSet;
    }

    /// <summary>
    /// Attempts to load the data set from the specified <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="sourceStream">An open <see cref="T:System.IO.Stream" /> from which to read the content.</param>
    /// <param name="userId">A string containing the user identifier/ user name for cryptographic access.</param>
    /// <param name="password">A string containing the password value for cryptographic access.</param>
    /// <param name="pin">An integer containing the user PIN value for cryptographic access.</param>
    /// <returns>
    /// An <see cref="IEntityDataSet" /> instance if successful; otherwise, returns
    /// <b>null</b>.
    /// </returns>
    public IEntityDataSet? LoadDataSet(Stream sourceStream, string userId, string password, int pin)
    {
        IEntityDataSet? dataSet = null;

        // Create the cryptographic reader and entity reader instances.
        sourceStream.Seek(0, SeekOrigin.Begin);
        CryptoSafeReader cryptoReader = new CryptoSafeReader(sourceStream, userId, password);
        IEntityReader reader = new VaultEntityReader();

        dataSet = reader.ReadEntityDataSet(cryptoReader);

        cryptoReader.Dispose();
        reader.Dispose();

        return dataSet;
    }

    /// <summary>
    /// Attempts to save the data set to a specified file.
    /// </summary>
    /// <param name="dataSet">The reference to the <see cref="T:Adaptive.Data.Vault.Abstraction.Entities.IEntityDataSet" /> instance to be written.</param>
    /// <param name="fileName">A string containing the fully-qualified path and name of the file.</param>
    /// <param name="userId">A string containing the user identifier/ user name for cryptographic access.</param>
    /// <param name="password">A string containing the password value for cryptographic access.</param>
    /// <param name="pin">An integer containing the user PIN value for cryptographic access.</param>
    public void SaveDataSet(IEntityDataSet dataSet, string fileName, string userId, string password, int pin)
    {
        // Create file.
        FileStream? stream = CreateFile(fileName);
        if (stream != null)
        {
            // Prepare the initial data set.
            MemoryStream contentStream = new MemoryStream();
            SaveDataSet(dataSet, contentStream, userId, password, pin);
            byte[] data = contentStream.ToArray();
            contentStream.Dispose();

            SuperCrypt crypt = new SuperCrypt(userId, password, pin);
            byte[]? outputData = crypt.Encrypt(data);

            stream.Write(outputData, 0, outputData.Length);
            stream.Flush();
            stream.Dispose();

            Array.Clear(outputData, 0, outputData.Length);
            Array.Clear(data, 0, data.Length);
        }
    }

    /// <summary>
    /// Attempts to save the data set to a specified file.
    /// </summary>
    /// <param name="dataSet">The reference to the <see cref="T:Adaptive.Data.Vault.Abstraction.Entities.IEntityDataSet" /> instance to be written.</param>
    /// <param name="destinationStream">The reference to the <see cref="T:System.IO.Stream" /> instance to be written to.</param>
    /// <param name="userId">A string containing the user identifier/ user name for cryptographic access.</param>
    /// <param name="password">A string containing the password value for cryptographic access.</param>
    /// <param name="pin">An integer containing the user PIN value for cryptographic access.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    public void SaveDataSet(IEntityDataSet dataSet, Stream destinationStream, string userId, string password, int pin)
    {
        // Create the cryptographic writer and entity writer instances.
        CryptoSafeWriter cryptoWriter = new CryptoSafeWriter(destinationStream, userId, password);
        IEntityWriter writer = new VaultEntityWriter();

        // Write the contents of the data set.
        writer.WriteEntityDataSet(cryptoWriter, dataSet);

        // Close and Dispose.
        cryptoWriter.Flush();
        cryptoWriter.Dispose();
        writer.Dispose();
    }

    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Attempts to open a file for reading.
    /// </summary>
    /// <param name="pathAndFileName">
    /// A string containing the fully-qualified path and name of the file to be opened.
    /// </param>
    /// <returns></returns>
    private FileStream? OpenFile(string pathAndFileName)
    {
        FileStream? stream = null;

        if (SafeIO.FileExists(pathAndFileName))
        {
            try
            {
                stream = new FileStream(pathAndFileName, FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }
        return stream;
    }

    /// <summary>
    /// Attempts to open a file for writing.
    /// </summary>
    /// <param name="pathAndFileName">
    /// A string containing the fully-qualified path and name of the file to be opened.
    /// </param>
    /// <returns></returns>
    private FileStream? CreateFile(string pathAndFileName)
    {
        FileStream? stream = null;

        // Delete the original, if present, and write a new file.
        if (SafeIO.FileExists(pathAndFileName))
            SafeIO.DeleteFile(pathAndFileName);

        try
        {
            stream = new FileStream(pathAndFileName, FileMode.CreateNew, FileAccess.Write, FileShare.None);
        }
        catch (Exception ex)
        {
            ExceptionLog.LogException(ex);
        }

        return stream;
    }
    #endregion
}
