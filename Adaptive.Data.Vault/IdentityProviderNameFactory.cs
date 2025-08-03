namespace Adaptive.Data.Vault
{
    public static class IdentityProviderNameFactory
    {
        /// <summary>
        /// Gets the default name value for the provider type.
        /// </summary>
        /// <param name="providerType">
        /// An <see cref="IdentityProviderType"/> enumerated value indicating the provider type.
        /// </param>
        /// <returns>
        /// A string containing the name text.
        /// </returns>
        public static string GetProviderTypeName(IdentityProviderType providerType)
        {
            string name = "";
            switch (providerType)
            {
                case IdentityProviderType.Apple:
                    name = "Apple";
                    break;

                case IdentityProviderType.Microsoft:
                    name = "Microsoft";
                    break;

                case IdentityProviderType.Facebook:
                    name = "Facebook";
                    break;

                case IdentityProviderType.CorporateCustomOrOther:
                    name = "Corporate, Custom, Or Other";
                    break;

                case IdentityProviderType.Google:
                    name = "Google";
                    break;

                default:
                    name = "Unknown";
                    break;
            }
            return name;
        }

    }
}
