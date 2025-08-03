using Adaptive.Intelligence.Shared;

namespace Adaptive.Data.Vault.IO.Cryptographic;

/// <summary>
/// Provides the signature definition for a cryptographic binary reader implementation for reading 
/// from a stream created by <see cref="ICryptoBinaryWriter"/>.
/// </summary>
/// <seealso cref="ExceptionTrackingBase" />
public interface ICryptoBinaryReader : IDisposable, ICryptoCompatibleObject, ISafeReader
{
    #region Properties
    /// <summary>
    /// Gets the reference to the stream associated with the reader.
    /// </summary>
    /// <value>
    /// The <see cref="Stream"/> being read from.
    /// </value>
    Stream? BaseStream { get; }

    /// <summary>
    /// Gets a value indicating whether the underlying stream can be read from.
    /// </summary>
    /// <value>
    ///   <c>true</c> if the underlying stream can be read from; otherwise, <c>false</c>.
    /// </value>
    bool CanRead { get; }
    #endregion

    #region Public Methods / Functions
    /// <summary>
    /// Closes this reader and releases any system resources associated with the
    /// reader. Following a call to Close, any operations on the reader may raise exceptions.
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
    /// Reads and decrypts the next section of data, and returns the next (single) byte value.
    /// </summary>
    /// <returns>
    /// The <see cref="byte"/> value that was read and decrypted.
    /// </returns>
    byte ReadByte();

    /// <summary>
    /// Reads a byte array from the encrypted content.
    /// </summary>
    /// <remarks>
    /// The length of the array is written by the writer, and read from the record content.
    /// </remarks>
    /// <returns>
    /// The decrypted byte array from the source content, or <b>null</b> if the data is missing or invalid.
    /// </returns>
    byte[]? ReadBytes();

    /// <summary>
    /// Reads and decrypts the next section of data, and returns the next (single) byte value.
    /// </summary>
    /// <returns>
    /// The <see cref="byte"/> value that was read and decrypted.
    /// </returns>
    char ReadChar();

    /// <summary>
    /// Reads a character array from the encrypted content.
    /// </summary>
    /// <remarks>
    /// The length of the array is written by the writer, and read from the record content.
    /// </remarks>
    /// <returns>
    /// The decrypted character array from the source content, or <b>null</b> if the data is missing or invalid.
    /// </returns>
    char[] ReadCharArray();

    /// <summary>
    /// Reads a double precision floating point value from the encrypted content.
    /// </summary>
    /// <returns>
    /// The decrypted <see cref="double"/> value.
    /// </returns>
    double ReadDouble();

    /// <summary>
    /// Reads a decimal structure from the encrypted content.
    /// </summary>
    /// <returns>
    /// The decrypted <see cref="decimal"/> value.
    /// </returns>
    decimal ReadDecimal();

    /// <summary>
    /// Reads a short integer value from the encrypted content.
    /// </summary>
    /// <returns>
    /// The decrypted <see cref="short"/> value.
    /// </returns>
    short ReadInt16();


    /// <summary>
    /// Reads an unsigned short integer value from the encrypted content.
    /// </summary>
    /// <returns>
    /// The decrypted <see cref="ushort"/> value.
    /// </returns>
    ushort ReadUInt16();

    /// <summary>
    /// Reads an unsigned integer value from the encrypted content.
    /// </summary>
    /// <returns>
    /// The decrypted <see cref="uint"/> value.
    /// </returns>
    uint ReadUInt32();

    /// <summary>
    /// Reads a long integer value from the encrypted content.
    /// </summary>
    /// <returns>
    /// The decrypted <see cref="long"/> value.
    /// </returns>
    long ReadInt64();

    /// <summary>
    /// Reads an unsigned long integer value from the encrypted content.
    /// </summary>
    /// <returns>
    /// The decrypted <see cref="ulong"/> value.
    /// </returns>
    ulong ReadUInt64();

    /// <summary>
    /// Reads half of a floating point value from the encrypted content.
    /// </summary>
    /// <returns>
    /// The decrypted <see cref="Half"/> value.
    /// </returns>
    Half ReadHalf();
    #endregion

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
}