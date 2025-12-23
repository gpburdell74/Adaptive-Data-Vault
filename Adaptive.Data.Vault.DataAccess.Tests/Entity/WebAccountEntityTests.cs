using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.DataAccess.Tests.Entity
{
    public class WebAccountEntityTests
    {
        [Fact]
        public void Constructor_InitializesDefaults()
        {
            var entity = new WebAccountEntity();
            Assert.Null(entity.Url);
            Assert.False(entity.UsesMFA);
            Assert.Null(entity.MFADescription);
            Assert.Null(entity.MFADeviceAddress);
            Assert.Equal(Guid.Empty, entity.CategoryId);
        }

        [Fact]
        public void Url_Property_GetSet_Works()
        {
            var entity = new WebAccountEntity();
            entity.Url = "https://example.com";
            Assert.Equal("https://example.com", entity.Url);
        }

        [Fact]
        public void UsesMFA_Property_GetSet_Works()
        {
            var entity = new WebAccountEntity();
            entity.UsesMFA = true;
            Assert.True(entity.UsesMFA);
            entity.UsesMFA = false;
            Assert.False(entity.UsesMFA);
        }

        [Fact]
        public void MFADescription_Property_GetSet_Works()
        {
            var entity = new WebAccountEntity();
            entity.MFADescription = "Authenticator App";
            Assert.Equal("Authenticator App", entity.MFADescription);
        }

        [Fact]
        public void MFADeviceAddress_Property_GetSet_Works()
        {
            var entity = new WebAccountEntity();
            entity.MFADeviceAddress = "user@example.com";
            Assert.Equal("user@example.com", entity.MFADeviceAddress);
        }

        [Fact]
        public void Dispose_ClearsSensitiveFields()
        {
            var entity = new WebAccountEntity
            {
                Url = "https://example.com",
                UsesMFA = true,
                MFADescription = "App",
                MFADeviceAddress = "user@example.com",
                Name = "Account",
                Description = "desc",
                CategoryId = Guid.NewGuid(),
                UserId = "user",
                Password = "pw"
            };

            entity.Dispose();

            Assert.Null(entity.Url);
            Assert.Null(entity.MFADescription);
            Assert.Null(entity.MFADeviceAddress);
            Assert.Null(entity.Name);
            Assert.Null(entity.Description);
            Assert.Null(entity.UserId);
            Assert.Null(entity.Password);
            Assert.Null(entity.CategoryId);
        }
    }
}