using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.Test
{
    public static class DataSetTestFactory
    {
        public static IEntityDataSet CreateTestDataSet()
        {

            IEntityDataSet ds = new VaultEntityDataSet();

            // Add the web site logins.
            AddWebSiteLogins(ds);

            // Add the identity provider logins.
            AddIdProviderLogins(ds);

            // Add the secure notes.
            AddSecureNotes(ds);

            // Create and add categories.
            AddCategories(ds);

            // Categorize Items.
            CategorizeItems(ds);

            return ds;
        }


        public static WebAccountCollection CreateWebSiteLogins()
        {
            WebAccountCollection ds = new WebAccountCollection();
            ds.AddWebAccount("North Georgia Realty", "Rent", "https://www.ngeorgiarealty.net/", "gpburdell74@outlook.com", "0210.Xnydym");

            ds.AddWebAccount("Delta", "Fly!", "https://www.delta.com/", "9356829128", "gtd722a");
            ds.AddWebAccount("FitBit", "", "www.fitbit.com", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("Endomondo", "", "https://www.endomondo.com/", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("EveryMove", "", "www.everymove.org", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("Origin", "Sim City", "https://www.origin.com/en-us/store/", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("LA Fitness", "", "lafitness.com", "gpburdell74", "gtd722a");
            ds.AddWebAccount("Minecraft", "", "www.minecraft.net", "gpburdell74@outlook.com", "gtd722a");
            ds.AddWebAccount("Steam", "", "www.steam.com", "gpburdell74", "7329.Wnyhiq");
            ds.AddWebAccount("T-Mobile", "", "www.t-mobile.com", "6784315012", "7329Wnyhiq");
            ds.AddWebAccount("DevExpress", "", "www.devexpress.com", "gpburdell74@outlook.com", "7329.Wnyhiq");
            ds.AddWebAccount("Amazon", "", "www.amazon.com", "6788223654", "913724Xnygtd722a");
            ds.AddWebAccount("Highlands Church", "", "https://highlandschurch.ccbchurch.com/goto/login", "gpburdell74@outlook.com", "0210.Xnydym");
            ds.AddWebAccount("Data Annotations", "", "https://www.dataannotation.tech", "gpburdell74@outlook.com", "7329.Wnyhiq-1");
            ds.AddWebAccount("PayPal", "", "https://www.paypal.com/", "gpburdell74@outlook.com", "7329.Wnyhiq");
            ds.AddWebAccount("Linked In", "", "www.linkedin.com", "gpburdell74@outlook.com", "7329.Wnyhiq");
            ds.AddWebAccount("Indeed", "", "www.indeed.com", "gpburdell74@outlook.com", "7329.Wnyhiq-1");
            ds.AddWebAccount("GitHub", "", "www.github.com", "gpburdell74@outlook.com", "7329.Wnyhiq");
            ds.AddWebAccount("Monster", "", "www.monster.com", "gpburdell74@outlook.com", "zgd48c7S_D_sk73");
            ds.AddWebAccount("Career Builder", "", "https://www.careerbuilder.com", "gpburdell74@outlook.com", "0210.Xnydym");
            ds.AddWebAccount("ZIP Recruiter", "", "https://www.ziprecruiter.com/", "gpburdell74@outlook.com", "0210.Xnydym");
            ds.AddWebAccount("Truist", "", "www.truist.com", "adaptiveint", "66ww3241zXnygtd722a");
            ds.AddWebAccount("Chase", "", "", "gpburdell74", "7329!Wnyhiq");
            ds.AddWebAccount("Discount Tire Card", "", "https://www.mysynchrony.com/?show_cc_login_frame=Y", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("Merrick", "", "https://merrickbank.com/", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("Credit One Card", "", "https://www.creditonebank.com/", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("Capital One", "", "https://myaccounts.capitalone.com/accountSummary", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("Avant", "", "https://www.avant.com/login", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("BrightWay", "", "https://www.onemainfinancial.com/credit-cards", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("KAY Jewelers", "", "https://c.comenity.net/ac/kay/public/sign-in?target_page=secure%2Fhome", "gpburdell74", "7329.Wnyhiq.3976Xdefg");
            ds.AddWebAccount("Home Depot", "", "https://citiretailservices.citibankonline.com/RSnextgen/svc/launch/index.action?siteId=PLCN_HOMEDEPOT&langId=en_US&pagename=authenticate#dashboard", "gpburdell74", "0210.Xnydym");
            ds.AddWebAccount("Lending Club", "", "https://banking.lendingclub.com/login?next=%2F%3FfromMC%3Dtrue", "gpburdell74@outlook.com", "0210.Xnydym");
            ds.AddWebAccount("Upgrade", "", "https://www.upgrade.com/portal/login", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("Sawnee", "Electric Bill", "https://sawnee.smarthub.coop/", "gpburdell74@outlook.com", "gtd722a");
            ds.AddWebAccount("Tru Natural Gas", "Gas Bill", "http://www.truenaturalgas.com", "gpburdell74", "gtd722a");
            ds.AddWebAccount("Cumming Utilities", "Water Bill", "https://www.cummingutilities.com/", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("Red Oak", "Garbage Bill", "http://www.sanitation-services.com/payments.php", "1491040", "5966");
            ds.AddWebAccount("Progressive", "Insurance", "https://account.apps.progressive.com/access/login?cntgrp=A&fd=accountHome", "Taterhead2000", "CjTj2023@4");
            return ds;
        }

        // Add the identity provider logins.
        public static IdentityProviderCollection CreateProviderLogins()
        {
            IdentityProviderCollection ds = new IdentityProviderCollection();

            ds.AddIdProvider(IdentityProviderType.Microsoft, "Microsoft", "", "http://www.microsoft.com", "gpburdell74@outlook.com", "2976.Xnydym");
            ds.AddIdProvider(IdentityProviderType.Facebook, "Facebook", "", "http://www.facebook.com", "6788223654", "Z.x.C.34%11.aSd");
            ds.AddIdProvider(IdentityProviderType.Google, "Google 1", "", "https://www.google.com", "csharpsam74@gmail.com", "0210Xnydym");
            ds.AddIdProvider(IdentityProviderType.Google, "Google 2", "", "https://www.google.com", "samjonesdotnet@gmail.com", "7329.Wnyhiq");
            ds.AddIdProvider(IdentityProviderType.Microsoft, "Training Azure Acct", "", "https://portal.azure.com/#home", "samjonesdotnet@gmail.com", "7329.Wnyhiq");

            return ds;
        }

        // Add the secure notes.
        public static SecureNoteCollection CreateSecureNotes()
        {
            SecureNoteCollection ds = new SecureNoteCollection();
            ds.AddSecureNote("Test Note 1", "Data", "Data");
            ds.AddSecureNote("Test Note 2", "Data2", "Data2");
            ds.AddSecureNote("Test Note 3", "Data3", "Data3");
            return ds;
        }

        // Create and add categories.
        public static UserCategoryCollection CreateCategories()
        {
            UserCategoryCollection ds = new UserCategoryCollection();
            ds.AddCategory("Bills");
            ds.AddCategory("Job Search");
            ds.AddCategory("Work");
            ds.AddCategory("Old");
            return ds;
        }

        // Add the web site logins.
        private static void AddWebSiteLogins(IEntityDataSet ds)
        {
            ds.AddWebAccount("North Georgia Realty", "Rent", "https://www.ngeorgiarealty.net/", "gpburdell74@outlook.com", "0210.Xnydym");

            ds.AddWebAccount("Delta", "Fly!", "https://www.delta.com/", "9356829128", "gtd722a");
            ds.AddWebAccount("FitBit", "", "www.fitbit.com", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("Endomondo", "", "https://www.endomondo.com/", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("EveryMove", "", "www.everymove.org", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("Origin", "Sim City", "https://www.origin.com/en-us/store/", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("LA Fitness", "", "lafitness.com", "gpburdell74", "gtd722a");
            ds.AddWebAccount("Minecraft", "", "www.minecraft.net", "gpburdell74@outlook.com", "gtd722a");
            ds.AddWebAccount("Steam", "", "www.steam.com", "gpburdell74", "7329.Wnyhiq");
            ds.AddWebAccount("T-Mobile", "", "www.t-mobile.com", "6784315012", "7329Wnyhiq");
            ds.AddWebAccount("DevExpress", "", "www.devexpress.com", "gpburdell74@outlook.com", "7329.Wnyhiq");
            ds.AddWebAccount("Amazon", "", "www.amazon.com", "6788223654", "913724Xnygtd722a");
            ds.AddWebAccount("Highlands Church", "", "https://highlandschurch.ccbchurch.com/goto/login", "gpburdell74@outlook.com", "0210.Xnydym");
            ds.AddWebAccount("Data Annotations", "", "https://www.dataannotation.tech", "gpburdell74@outlook.com", "7329.Wnyhiq-1");
            ds.AddWebAccount("PayPal", "", "https://www.paypal.com/", "gpburdell74@outlook.com", "7329.Wnyhiq");
            ds.AddWebAccount("Linked In", "", "www.linkedin.com", "gpburdell74@outlook.com", "7329.Wnyhiq");
            ds.AddWebAccount("Indeed", "", "www.indeed.com", "gpburdell74@outlook.com", "7329.Wnyhiq-1");
            ds.AddWebAccount("GitHub", "", "www.github.com", "gpburdell74@outlook.com", "7329.Wnyhiq");
            ds.AddWebAccount("Monster", "", "www.monster.com", "gpburdell74@outlook.com", "zgd48c7S_D_sk73");
            ds.AddWebAccount("Career Builder", "", "https://www.careerbuilder.com", "gpburdell74@outlook.com", "0210.Xnydym");
            ds.AddWebAccount("ZIP Recruiter", "", "https://www.ziprecruiter.com/", "gpburdell74@outlook.com", "0210.Xnydym");
            ds.AddWebAccount("Truist", "", "www.truist.com", "adaptiveint", "66ww3241zXnygtd722a");
            ds.AddWebAccount("Chase", "", "", "gpburdell74", "7329!Wnyhiq");
            ds.AddWebAccount("Discount Tire Card", "", "https://www.mysynchrony.com/?show_cc_login_frame=Y", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("Merrick", "", "https://merrickbank.com/", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("Credit One Card", "", "https://www.creditonebank.com/", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("Capital One", "", "https://myaccounts.capitalone.com/accountSummary", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("Avant", "", "https://www.avant.com/login", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("BrightWay", "", "https://www.onemainfinancial.com/credit-cards", "gpburdell74", "0210Xnydym");
            ds.AddWebAccount("KAY Jewelers", "", "https://c.comenity.net/ac/kay/public/sign-in?target_page=secure%2Fhome", "gpburdell74", "7329.Wnyhiq.3976Xdefg");
            ds.AddWebAccount("Home Depot", "", "https://citiretailservices.citibankonline.com/RSnextgen/svc/launch/index.action?siteId=PLCN_HOMEDEPOT&langId=en_US&pagename=authenticate#dashboard", "gpburdell74", "0210.Xnydym");
            ds.AddWebAccount("Lending Club", "", "https://banking.lendingclub.com/login?next=%2F%3FfromMC%3Dtrue", "gpburdell74@outlook.com", "0210.Xnydym");
            ds.AddWebAccount("Upgrade", "", "https://www.upgrade.com/portal/login", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("Sawnee", "Electric Bill", "https://sawnee.smarthub.coop/", "gpburdell74@outlook.com", "gtd722a");
            ds.AddWebAccount("Tru Natural Gas", "Gas Bill", "http://www.truenaturalgas.com", "gpburdell74", "gtd722a");
            ds.AddWebAccount("Cumming Utilities", "Water Bill", "https://www.cummingutilities.com/", "gpburdell74@outlook.com", "0210Xnydym");
            ds.AddWebAccount("Red Oak", "Garbage Bill", "http://www.sanitation-services.com/payments.php", "1491040", "5966");
            ds.AddWebAccount("Progressive", "Insurance", "https://account.apps.progressive.com/access/login?cntgrp=A&fd=accountHome", "Taterhead2000", "CjTj2023@4");
        }

        // Add the identity provider logins.
        private static void AddIdProviderLogins(IEntityDataSet ds)
        {
            ds.AddIdProvider(IdentityProviderType.Microsoft, "Microsoft", "", "http://www.microsoft.com", "gpburdell74@outlook.com", "2976.Xnydym");
            ds.AddIdProvider(IdentityProviderType.Facebook, "Facebook", "", "http://www.facebook.com", "6788223654", "Z.x.C.34%11.aSd");
            ds.AddIdProvider(IdentityProviderType.Google, "Google 1", "", "https://www.google.com", "csharpsam74@gmail.com", "0210Xnydym");
            ds.AddIdProvider(IdentityProviderType.Google, "Google 2", "", "https://www.google.com", "samjonesdotnet@gmail.com", "7329.Wnyhiq");
            ds.AddIdProvider(IdentityProviderType.Microsoft, "Training Azure Acct", "", "https://portal.azure.com/#home", "samjonesdotnet@gmail.com", "7329.Wnyhiq");

        }

        // Add the secure notes.
        private static void AddSecureNotes(IEntityDataSet ds)
        {
            ds.AddSecureNote("Test Note 1", "Data", "Data");
            ds.AddSecureNote("Test Note 2", "Data2", "Data2");
            ds.AddSecureNote("Test Note 3", "Data3", "Data3");
        }

        // Create and add categories.
        private static void AddCategories(IEntityDataSet ds)
        {
            ds.AddCategory("Bills");
            ds.AddCategory("Job Search");
            ds.AddCategory("Work");
            ds.AddCategory("Old");
        }

        // Categorize Items.
        private static void CategorizeItems(IEntityDataSet ds)
        {
        }

    }
}
