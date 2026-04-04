using Adaptive.Data.Vault.Entities;
using Moq;

namespace Adaptive.Data.Vault.Tests
{
    public class WebAccountTests
    {
        [Fact]
        public void DefaultConstructor_InitializesWithNullEntity()
        {
            var account = new WebAccount();
            Assert.True(account.CategoryId == Guid.Empty);
            Assert.True(string.IsNullOrEmpty(account.Description));
            Assert.True(string.IsNullOrEmpty(account.MFADescription));
            Assert.True(string.IsNullOrEmpty(account.MFADeviceAddress));
            Assert.True(string.IsNullOrEmpty(account.Name));
            Assert.True(string.IsNullOrEmpty(account.Password));
            Assert.True(string.IsNullOrEmpty(account.Url));
            Assert.True(string.IsNullOrEmpty(account.UserId));
            Assert.False(account.UsesMFA);
        }

        [Fact]
        public void Constructor_WithEntity_SetsPropertiesCorrectly()
        {
            var mockEntity = new Mock<IWebAccountEntity>();
            mockEntity.SetupAllProperties();
            var guid = Guid.NewGuid();
            mockEntity.Object.CategoryId = guid;
            mockEntity.Object.Description = "desc";
            mockEntity.Object.MFADescription = "mfa";
            mockEntity.Object.MFADeviceAddress = "address";
            mockEntity.Object.Name = "name";
            mockEntity.Object.Password = "pwd";
            mockEntity.Object.Url = "url";
            mockEntity.Object.UserId = "user";
            mockEntity.Object.UsesMFA = true;

            var account = new WebAccount(mockEntity.Object);

            Assert.Equal(guid, account.CategoryId);
            Assert.Equal("desc", account.Description);
            Assert.Equal("mfa", account.MFADescription);
            Assert.Equal("address", account.MFADeviceAddress);
            Assert.Equal("name", account.Name);
            Assert.Equal("pwd", account.Password);
            Assert.Equal("url", account.Url);
            Assert.Equal("user", account.UserId);
            Assert.True(account.UsesMFA);
        }

        [Fact]
        public void Setters_UpdateEntityProperties()
        {
            var mockEntity = new Mock<IWebAccountEntity>();
            mockEntity.SetupAllProperties();
            var account = new WebAccount(mockEntity.Object);

            var guid = Guid.NewGuid();
            account.CategoryId = guid;
            account.Description = "desc";
            account.MFADescription = "mfa";
            account.MFADeviceAddress = "address";
            account.Name = "name";
            account.Password = "pwd";
            account.Url = "url";
            account.UserId = "user";
            account.UsesMFA = true;

            Assert.Equal(guid, mockEntity.Object.CategoryId);
            Assert.Equal("desc", mockEntity.Object.Description);
            Assert.Equal("mfa", mockEntity.Object.MFADescription);
            Assert.Equal("address", mockEntity.Object.MFADeviceAddress);
            Assert.Equal("name", mockEntity.Object.Name);
            Assert.Equal("pwd", mockEntity.Object.Password);
            Assert.Equal("url", mockEntity.Object.Url);
            Assert.Equal("user", mockEntity.Object.UserId);
            Assert.True(mockEntity.Object.UsesMFA);
        }
    }
}