using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.IO;

/// <summary>
/// Provides the signature definition for the implementation that will read and write the 
/// secure vault files.
/// </summary>
/// <seealso cref="IDisposable" />
public interface IVaultFile : IDisposable
{
    /// <summary>
    /// Attempts to load the data set from a specified file.
    /// </summary>
    /// <param name="fileName">
    /// A string containing the fully-qualified path and name of the file.
    /// </param>
    /// <param name="userId">
    /// A string containing the user identifier/ user name for cryptographic access.
    /// </param>
    /// <param name="password">
    /// A string containing the password value for cryptographic access.
    /// </param>
    /// <param name="pin">
    /// An integer containing the user PIN value for cryptographic access.
    /// </param>
    /// <returns>
    /// An <see cref="IEntityDataSet"/> instance if successful; otherwise, returns
    /// <b>null</b>.
    /// </returns>
    IEntityDataSet? LoadDataSet(string fileName, string userId, string password, int pin);

    /// <summary>
    /// Attempts to load the data set from the specified <see cref="Stream"/>.
    /// </summary>
    /// <param name="sourceStream">
    /// An open <see cref="Stream"/> from which to read the content.
    /// </param>
    /// <param name="userId">
    /// A string containing the user identifier/ user name for cryptographic access.
    /// </param>
    /// <param name="password">
    /// A string containing the password value for cryptographic access.
    /// </param>
    /// <param name="pin">
    /// An integer containing the user PIN value for cryptographic access.
    /// </param>
    /// <returns>
    /// An <see cref="IEntityDataSet"/> instance if successful; otherwise, returns
    /// <b>null</b>.
    /// </returns>
    IEntityDataSet? LoadDataSet(Stream sourceStream, string userId, string password, int pin);

    /// <summary>
    /// Attempts to save the data set to a specified file.
    /// </summary>
    /// <param name="dataSet">
    /// The reference to the <see cref="IEntityDataSet"/> instance to be written.
    /// </param>
    /// <param name="fileName">
    /// A string containing the fully-qualified path and name of the file.
    /// </param>
    /// <param name="userId">
    /// A string containing the user identifier/ user name for cryptographic access.
    /// </param>
    /// <param name="password">
    /// A string containing the password value for cryptographic access.
    /// </param>
    /// <param name="pin">
    /// An integer containing the user PIN value for cryptographic access.
    /// </param>
    void SaveDataSet(IEntityDataSet dataSet, string fileName, string userId, string password, int pin);


    /// <summary>
    /// Attempts to save the data set to a specified file.
    /// </summary>
    /// <param name="dataSet">
    /// The reference to the <see cref="IEntityDataSet"/> instance to be written.
    /// </param>
    /// <param name="destinationStream">
    /// The reference to the <see cref="Stream"/> instance to be written to.
    /// </param>
    /// <param name="userId">
    /// A string containing the user identifier/ user name for cryptographic access.
    /// </param>
    /// <param name="password">
    /// A string containing the password value for cryptographic access.
    /// </param>
    /// <param name="pin">
    /// An integer containing the user PIN value for cryptographic access.
    /// </param>
    void SaveDataSet(IEntityDataSet dataSet, Stream destinationStream, string userId, string password, int pin);
}