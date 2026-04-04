using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.Tests
{
    public class IdentityProviderTests
    {
        [Fact]
        public void DefaultConstructor_InitializesWithNullEntity()
        {
            var provider = new IdentityProvider();
            Assert.True(provider.CategoryId == Guid.Empty);
            Assert.True(string.IsNullOrEmpty(provider.Description));
            Assert.True(string.IsNullOrEmpty(provider.MFADescription));
            Assert.True(string.IsNullOrEmpty(provider.MFADeviceAddress));
            Assert.True(string.IsNullOrEmpty(provider.Name));
            Assert.True(string.IsNullOrEmpty(provider.Password));
            Assert.True(string.IsNullOrEmpty(provider.Url));
            Assert.True(string.IsNullOrEmpty(provider.UserId));
            Assert.False(provider.UsesMFA);
            Assert.Equal(IdentityProviderType.None, provider.ProviderType);
            Assert.True(string.IsNullOrEmpty(provider.ProviderTypeName));
        }

        [Fact]
        public void Constructor_WithEntity_SetsPropertiesCorrectly()
        {
            var entityMock = new IdentityProviderEntity();
            var guid = Guid.NewGuid();
            entityMock.CategoryId = guid;
            entityMock.Description = "desc";
            entityMock.MFADescription = "mfa";
            entityMock.MFADeviceAddress = "address";
            entityMock.Name = "name";
            entityMock.Password = "pwd";
            entityMock.Url = "url";
            entityMock.UserId = "user";
            entityMock.UsesMFA = true;
            entityMock.ProviderType = IdentityProviderType.Google;
            entityMock.ProviderTypeName = "Google";

            var provider = new IdentityProvider(entityMock);

            Assert.Equal(guid, provider.CategoryId);
            Assert.Equal("desc", provider.Description);
            Assert.Equal("mfa", provider.MFADescription);
            Assert.Equal("address", provider.MFADeviceAddress);
            Assert.Equal("name", provider.Name);
            Assert.Equal("pwd", provider.Password);
            Assert.Equal("url", provider.Url);
            Assert.Equal("user", provider.UserId);
            Assert.True(provider.UsesMFA);
            Assert.Equal(IdentityProviderType.Google, provider.ProviderType);
            Assert.Equal("Google", provider.ProviderTypeName);
        }

        [Fact]
        public void Setters_UpdateEntityProperties()
        {
            var entityMock = new IdentityProviderEntity();
            var provider = new IdentityProvider(entityMock);

            var guid = Guid.NewGuid();
            provider.CategoryId = guid;
            provider.Description = "desc";
            provider.MFADescription = "mfa";
            provider.MFADeviceAddress = "address";
            provider.Name = "name";
            provider.Password = "pwd";
            provider.Url = "url";
            provider.UserId = "user";
            provider.UsesMFA = true;
            provider.ProviderType = IdentityProviderType.Microsoft;
            provider.ProviderTypeName = "Microsoft";

            Assert.Equal(guid, entityMock.CategoryId);
            Assert.Equal("desc", entityMock.Description);
            Assert.Equal("mfa", entityMock.MFADescription);
            Assert.Equal("address", entityMock.MFADeviceAddress);
            Assert.Equal("name", entityMock.Name);
            Assert.Equal("pwd", entityMock.Password);
            Assert.Equal("url", entityMock.Url);
            Assert.Equal("user", entityMock.UserId);
            Assert.True(entityMock.UsesMFA);
            Assert.Equal(IdentityProviderType.Microsoft, entityMock.ProviderType);
            Assert.Equal("Microsoft", entityMock.ProviderTypeName);
        }

        [Fact]
        public void Getters_ReturnNullOrDefault_WhenEntityIsNull()
        {
            var provider = new IdentityProvider();
            Assert.True(provider.CategoryId == Guid.Empty);
            Assert.True(string.IsNullOrEmpty(provider.Description));
            Assert.True(string.IsNullOrEmpty(provider.MFADescription));
            Assert.True(string.IsNullOrEmpty(provider.MFADeviceAddress));
            Assert.True(string.IsNullOrEmpty(provider.Name));
            Assert.True(string.IsNullOrEmpty(provider.Password));
            Assert.True(string.IsNullOrEmpty(provider.Url));
            Assert.True(string.IsNullOrEmpty(provider.UserId));
            Assert.False(provider.UsesMFA);
            Assert.Equal(IdentityProviderType.None, provider.ProviderType);
            Assert.True(string.IsNullOrEmpty(provider.ProviderTypeName));
        }
    }
}