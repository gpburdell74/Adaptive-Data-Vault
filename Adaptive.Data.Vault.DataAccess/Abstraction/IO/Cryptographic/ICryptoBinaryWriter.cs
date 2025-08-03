using Adaptive.Intelligence.Shared;

namespace Adaptive.Data.Vault.IO.Cryptographic;

/// <summary>
/// Provides the signature definition for a cryptographic binary writer implementation for writing to a stream.
/// </summary>
/// <seealso cref="ExceptionTrackingBase" />
public interface ICryptoBinaryWriter : IDisposable, ICryptoCompatibleObject, ISafeWriter 
{
    #region Properties
    /// <summary>
    /// Gets a value indicating whether the underlying stream can be written to.
    /// </summary>
    /// <value>
    ///   <c>true</c> if the underlying stream can be written to; otherwise, <c>false</c>.
    /// </value>
    bool CanWrite { get; }
    #endregion

    #region Public Methods / Functions
    /// <summary>
    /// Closes this writer and releases any system resources associated with the
    /// writer. Following a call to Close, any operations on the writer may raise exceptions.
    /// </summary>
    void Close();

    /// <summary>
    /// Sets the position in the underlying stream instance to the specified offset.
    /// </summary>
    /// <param name="offset">
    /// Am integer specifying the offset value.
    /// </param>
    /// <param name="origin">
    /// The <see cref="SeekOrigin"/> enumerated value indicating from what location to 
    /// calculate the offset.
    /// </param>
    /// <returns>
    /// A <see cref="long"/> specifying the new position in the stream.
    /// </returns>
    long Seek(int offset, SeekOrigin origin);

    /// <summary>
    /// Encrypts the specified byte value and then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="byte"/> value to be written.
    /// </param>
    void Write(byte value);

    /// <summary>
    /// Encrypts the specified byte array and then writes the result to the output stream.
    /// </summary>
    /// <param name="buffer">
    /// The <see cref="byte"/> array to be written.
    /// </param>
    void Write(byte[] buffer);

    /// <summary>
    /// Encrypts the a section of the specified byte array and then writes the result to the output stream.
    /// </summary>
    /// <param name="buffer">
    /// The <see cref="byte"/> array to be written.
    /// </param>
    /// <param name="index">
    /// The ordinal index of the source array at which to begin copying the data content.
    /// </param>
    /// <param name="count">
    /// An integer specifying the number of bytes to be written.
    /// </param>
    void Write(byte[] buffer, int index, int count);

    /// <summary>
    /// Encrypts the specified character then writes the result to the output stream.
    /// </summary>
    /// <param name="ch">
    /// The <see cref="char"/> to be written.
    /// </param>
    void Write(char ch);

    /// <summary>
    /// Encrypts the specified character array then writes the result to the output stream.
    /// </summary>
    /// <param name="chars">
    /// The <see cref="char"/> array to be written.
    /// </param>
    void Write(char[] chars);

    /// <summary>
    /// Encrypts the specified double-precision value then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="double"/> value to be written.
    /// </param>
    void Write(double value);

    /// <summary>
    /// Encrypts the specified decimal value then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="decimal"/> value to be written.
    /// </param>
    void Write(decimal value);

    /// <summary>
    /// Encrypts the specified short integer value then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="short"/> value to be written.
    /// </param>
    void Write(short value);

    /// <summary>
    /// Encrypts the specified unsigned short integer value then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="ushort"/> value to be written.
    /// </param>
    void Write(ushort value);

    /// <summary>
    /// Encrypts the specified unsigned integer value then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="uint"/> value to be written.
    /// </param>
    void Write(uint value);

    /// <summary>
    /// Encrypts the specified long integer value then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="long"/> value to be written.
    /// </param>
    void Write(long value);

    /// <summary>
    /// Encrypts the specified unsigned long integer value then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="ulong"/> value to be written.
    /// </param>
    void Write(ulong value);

    /// <summary>
    /// Encrypts the specified Half value then writes the result to the output stream.
    /// </summary>
    /// <param name="value">
    /// The <see cref="Half"/> value to be written.
    /// </param>
    void Write(Half value);
    #endregion

    #region Cryptographic Initialization and Key Derivation
    /// <summary>
    /// Performs the key-derivation activities and initializes the cryptographic provider instances.
    /// </summary>
    /// <param name="userId">
    /// A string containing the ID of the user.
    /// </param>
    /// <param name="filePassword">
    /// A string containing the password value for the user.
    /// </param>
    void PrepareCryptographicInstances(string userId, string filePassword);

    /// <summary>
    /// Encrypts the specified byte array.
    /// </summary>
    /// <param name="clearData">
    /// A byte array containing the clear data content to be written.
    /// </param>
    /// <returns>
    /// A byte array containing the encrypted data.
    /// </returns>
    byte[]? Encrypt(byte[] clearData);

    /// <summary>
    /// Encrypts the specified <see cref="Span{T}"/> of <see cref="byte"/>.
    /// </summary>
    /// <param name="clearData">
    /// A byte array containing the clear data content to be written.
    /// </param>
    /// <returns>
    /// A byte array containing the encrypted data.
    /// </returns>
    byte[]? Encrypt(Span<byte> clearData);

    /// <summary>
    /// Writes the data record to the stream.
    /// </summary>
    /// <remarks>
    /// This method writes a 4-byte array (integer) indicating the length of the data, and 
    /// then writes the data byte array.
    /// </remarks>
    /// <param name="dataToWrite">
    /// A byte array containing the data to write.
    /// </param>
    void WriteRecord(byte[]? dataToWrite);
    #endregion
}