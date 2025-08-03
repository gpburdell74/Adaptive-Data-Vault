using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault
{
    /// <summary>
    /// Contains and manages a list of <see cref="WebAccount"/> instances.
    /// </summary>
    /// <seealso cref="List{T}" />
    public sealed class WebAccountCollection : VaultBusinessCollectionBase<WebAccount, IWebAccountEntity>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAccountCollection"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public WebAccountCollection()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebAccountCollection"/> class.
        /// </summary>
        /// <param name="sourceList">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> list of <typeparamref name="E" /> entities used to
        /// create the business object(s) and populate the list.</param>
        public WebAccountCollection(IEnumerable<IWebAccountEntity> sourceList) : base()
        {
            foreach (IWebAccountEntity entity in sourceList)
            {
                WebAccount account = new WebAccount(entity);
                Add(account);
            }

        }
        #endregion

        #region Public Methods / Functions
        /// <summary>
        /// Adds the web account record.
        /// </summary>
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
        public void AddWebAccount(string name, string description, string url, string userId, string password,
            bool usesMfa = false, string mfaDescription = "", string mfaAddress = "")
        {
            WebAccount entity = new WebAccount
            {
                Name = name,
                Url = url,
                UserId = userId,
                Password = password,
                MFADescription = mfaDescription,
                MFADeviceAddress = mfaAddress,
                UsesMFA = usesMfa
            };
            Add(entity);
        }

        /// <summary>
        /// Gets the list of items that are in the specified category.
        /// </summary>
        /// <param name="categoryId">The category identifier.</param>
        /// <returns></returns>
        public WebAccountCollection GetForCategory(Guid? categoryId)
        {
            WebAccountCollection results = new WebAccountCollection();

            if (categoryId == null)
                categoryId = Guid.Empty;

            results.AddRange(this.Where(x => x.CategoryId == categoryId));

            return results;
        }

        public void SortAlpha()
        {
            Sort(AlphabeticComparison);
        }
        #endregion

        private int AlphabeticComparison(WebAccount left, WebAccount right)
        {
            return string.Compare(left.Name, right.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
