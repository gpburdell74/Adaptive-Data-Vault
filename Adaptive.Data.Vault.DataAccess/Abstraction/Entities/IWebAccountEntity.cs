namespace Adaptive.Data.Vault.Entities;

/// <summary>
/// Provides the signature definition for entities that contain information for a website account or login.
/// </summary>
/// <seealso cref="IEntity" />
public interface IWebAccountEntity : IEntity
{
    #region Properties
    /// <summary>
    /// Gets or sets the user-defined MFA/2FA description.
    /// </summary>
    /// <value>
    /// A string containing the description.
    /// </value>
    string? MFADescription { get; set; }

    /// <summary>
    /// Gets or sets the email address or phone number used in the MFA process.
    /// </summary>
    /// <value>
    /// The phone number, email address, or other such address used in the MFA process.
    /// </value>
    string? MFADeviceAddress { get; set; }

    /// <summary>
    /// Gets or sets the string containing the URL of the website and/or login page.
    /// </summary>
    /// <value>
    /// A string containing the URL used to access the website and/or login page.
    /// </value>
    string? Url { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether MFA/2FA is turned on for the account.
    /// </summary>
    /// <value>
    /// <b>true</b> if multi-factor authentication is used; otherwise, <b>false</b>.
    /// </value>
    bool UsesMFA { get; set; }
    #endregion
}