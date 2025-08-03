using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault
{
    /// <summary>
    /// Contains and manages a list of <see cref="IdentityProvider"/> instances.
    /// </summary>
    /// <seealso cref="List{T}" />
    public sealed class IdentityProviderCollection : VaultBusinessCollectionBase<IdentityProvider, IIdentityProviderEntity>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderCollection"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public IdentityProviderCollection()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderCollection"/> class.
        /// </summary>
        /// <param name="sourceList">
        /// The <see cref="IEnumerable{T}" /> list of <see cref="IdentityProviderEntity"/> entities used to
        /// create the business object(s) and populate the list.</param>
        public IdentityProviderCollection(IEnumerable<IIdentityProviderEntity> sourceList) 
            : base()
        {
            foreach (IIdentityProviderEntity entity in sourceList)
            {
                IdentityProvider provider = new IdentityProvider(entity);
                Add(provider);
            }

        }
        #endregion

        #region Public Methods / Functions

        /// <summary>
        /// Adds the identity provider record.
        /// </summary>
        /// <param name="providerType">
        /// An <see cref="IdentityProviderType"/> enumerated value indicating the provider type.
        /// </param>
        /// <param name="name">
        /// A string containing the name for the entry.
        /// </param>
        /// <param name="description">
        /// A string containing a description of the entry.
        /// </param>
        /// <param name="url">
        /// A string specifying the URL for the related website.
        /// </param>
        /// <param name="userId">
        /// A string containing the user ID or login name for the website.
        /// </param>
        /// <param name="password">
        /// A string containing the password for the website.
        /// </param>
        /// <param name="usesMfa">
        /// A value indicating whether multi-factor authentication (MFA) is active for this login.
        /// </param>
        /// <param name="mfaDescription">
        /// A description for the MFA type - such as phone or email or authenticator app.
        /// </param>
        /// <param name="mfaAddress">
        /// A string containing a phone number, email address, or other address value for MFA
        /// for this account.
        /// </param>
        public void AddIdProvider(IdentityProviderType providerType, string name, string description, string url, string userId, string password,
                bool usesMfa = false, string mfaDescription = "", string mfaAddress = "")
        {
            IdentityProvider provider = new IdentityProvider
            {
                MFADescription = mfaDescription,
                MFADeviceAddress = mfaAddress,
                Name = name,
                Password = password,
                UserId = userId,
                UsesMFA = usesMfa,
                ProviderType = providerType,
                ProviderTypeName = IdentityProviderNameFactory.GetProviderTypeName(providerType),
                Url = url
            };

            Add(provider);
        }

        #endregion
    }
}
