using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.Tests
{
    public class IdentityProviderCollectionTests
    {
        [Fact]
        public void DefaultConstructor_CreatesEmptyCollection()
        {
            var collection = new IdentityProviderCollection();
            Assert.Empty(collection);
        }

        [Fact]
        public void Constructor_WithSourceList_PopulatesCollection()
        {
            var mockEntity = new IdentityProviderEntity();
            mockEntity.Name = "TestProvider";
            var sourceList = new List<IIdentityProviderEntity> { mockEntity };

            var collection = new IdentityProviderCollection(sourceList);

            Assert.Single(collection);
            Assert.Equal("TestProvider", collection[0].Name);
        }

        [Fact]
        public void AddIdProvider_AddsProviderWithCorrectProperties()
        {
            var collection = new IdentityProviderCollection();
            collection.AddIdProvider(
                IdentityProviderType.Google,
                "Google Account",
                "Personal Google account",
                "https://accounts.google.com",
                "user@gmail.com",
                "password123",
                true,
                "Authenticator App",
                "user@gmail.com"
            );

            Assert.Single(collection);
            var provider = collection[0];
            Assert.Equal(IdentityProviderType.Google, provider.ProviderType);
            Assert.Equal("Google Account", provider.Name);
            Assert.Equal("Personal Google account", provider.Description);
            Assert.Equal("https://accounts.google.com", provider.Url);
            Assert.Equal("user@gmail.com", provider.UserId);
            Assert.Equal("password123", provider.Password);
            Assert.True(provider.UsesMFA);
            Assert.Equal("Authenticator App", provider.MFADescription);
            Assert.Equal("user@gmail.com", provider.MFADeviceAddress);
        }

        [Fact]
        public void SortAlpha_SortsProvidersByName()
        {
            var collection = new IdentityProviderCollection();
            collection.AddIdProvider(IdentityProviderType.Google, "Zeta", "", "", "", "");
            collection.AddIdProvider(IdentityProviderType.Google, "Alpha", "", "", "", "");
            collection.AddIdProvider(IdentityProviderType.Google, "Beta", "", "", "", "");

            collection.SortAlpha();

            Assert.Equal("Alpha", collection[0].Name);
            Assert.Equal("Beta", collection[1].Name);
            Assert.Equal("Zeta", collection[2].Name);
        }
    }
}