namespace Adaptive.Data.Vault;

/// <summary>
/// Provides constants definitions for various file operations.
/// </summary>
public static class FileConstants
{
    /// <summary>
    /// The file extension for Password Keep Clear Text Files.
    /// </summary>
    public const string ExtensionClearFile = ".txt";
    /// <summary>
    /// The file extension for Password Keep Secure Files.
    /// </summary>
    public const string ExtensionSecureFile = ".adv";

    /// <summary>
    /// The dialog file filter text for reading or writing Secure Files.
    /// </summary>
    public const string FilterSecureFile = "Adaptive Data Vault Files (*.adv)|*.adv";
    /// <summary>
    /// The dialog file filter text for reading or writing Secure or Clear Text Files.
    /// </summary>
    public const string FilterSecureAndClearFile = "Adaptive Data Vault Files (*.adv)|*.adv|Clear Text Files (*.txt)|*.txt";
}
