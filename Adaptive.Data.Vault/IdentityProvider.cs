using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault;

/// <summary>
/// Represents and manages a known identity provider login.
/// login data.
/// </summary>
/// <seealso cref="VaultBusinessBase{T}" />
/// <seealso cref="IIdentityProviderEntity" />
public sealed class IdentityProvider : VaultBusinessBase<IIdentityProviderEntity>
{
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProvider"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public IdentityProvider() : base()
    {
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProvider"/> class.
    /// </summary>
    /// <param name="entity">The entity to use for the data store.</param>
    public IdentityProvider(IIdentityProviderEntity entity) : base((IdentityProviderEntity)entity)
    {

    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the category Id value.
    /// </summary>
    /// <value>
    /// A <see cref="T:System.Guid" /> containing the ID of the category the item belongs to,
    /// or <b>null</b> if the item is not categorized.
    /// </value>
    public Guid? CategoryId
    {
        get
        {
            if (Entity != null)
                return Entity.CategoryId;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.CategoryId = value;
        }
    }
    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>
    /// A string containing the description of the account.
    /// </value>
    public string? Description
    {
        get
        {
            if (Entity != null)
                return Entity.Description;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.Description = value;
        }
    }

    /// <summary>
    /// Gets or sets the user-defined MFA/2FA description.
    /// </summary>
    /// <value>
    /// A string containing the description.
    /// </value>
    public string? MFADescription
    {
        get
        {
            if (Entity != null)
                return Entity.MFADescription;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.MFADescription = value;
        }
    }

    /// <summary>
    /// Gets or sets the email address or phone number used in the MFA process.
    /// </summary>
    /// <value>
    /// The phone number, email address, or other such address used in the MFA process.
    /// </value>
    public string? MFADeviceAddress
    {
        get
        {
            if (Entity != null)
                return Entity.MFADeviceAddress;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.MFADeviceAddress = value;
        }
    }

    /// <summary>
    /// Gets or sets the name for the item.
    /// </summary>
    /// <value>
    /// A string containing the item name, or <b>null</b>.
    /// </value>
    public string? Name
    {
        get
        {
            if (Entity != null)
                return Entity.Name;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.Name = value;
        }
    }

    /// <summary>
    /// Gets or sets the password value for the item.
    /// </summary>
    /// <value>
    /// A string containing the item value, or <b>null</b>.
    /// </value>
    public string? Password
    {
        get
        {
            if (Entity != null)
                return Entity.Password;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.Password = value;
        }
    }

    /// <summary>
    /// Gets or sets the string containing the URL of the website and/or login page.
    /// </summary>
    /// <value>
    /// A string containing the URL used to access the website and/or login page.
    /// </value>
    public string? Url
    {
        get
        {
            if (Entity != null)
                return Entity.Url;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.Url = value;
        }
    }

    /// <summary>
    /// Gets or sets the User ID / email / login name value for the item.
    /// </summary>
    /// <value>
    /// A string containing the user identity value, or <b>null</b>.
    /// </value>
    public string? UserId
    {
        get
        {
            if (Entity != null)
                return Entity.UserId;
            else
                return null;
        }
        set
        {
            if (Entity != null)
                Entity.UserId = value;
        }
    }
    /// <summary>
    /// Gets or sets a value indicating whether MFA/2FA is turned on for the account.
    /// </summary>
    /// <value>
    /// <b>true</b> if multi-factor authentication is used; otherwise, <b>false</b>.
    /// </value>
    public bool UsesMFA
    {
        get
        {
            if (Entity != null)
                return Entity.UsesMFA;
            else
                return false;
        }
        set
        {
            if (Entity != null)
                Entity.UsesMFA = value;
        }
    }
    /// <summary>
    /// Gets or sets the type of the provider.
    /// </summary>
    /// <value>
    /// An <see cref="IdentityProviderType" /> enumerated value indicating the type of the
    /// identity provider.
    /// </value>
    public IdentityProviderType ProviderType
    {
        get
        {
            if (Entity == null)
                return IdentityProviderType.None;
            else
                return Entity.ProviderType;
        }
        set
        {
            if (Entity != null)
                Entity.ProviderType = value;
        }
    }

    /// <summary>
    /// Gets or sets the name of the identity provider.
    /// </summary>
    /// <value>
    /// A string containing the name of the identity provider.
    /// </value>
    public string? ProviderTypeName
    {
        get
        {
            if (Entity == null)
                return null;
            else
                return Entity.ProviderTypeName;
        }
        set
        {
            if (Entity != null)
                Entity.ProviderTypeName = value;
        }
    }
    #endregion
}
