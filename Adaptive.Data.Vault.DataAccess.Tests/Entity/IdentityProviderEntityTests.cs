using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.DataAccess.Tests.Entity;

public class IdentityProviderEntityTests
{
    [Fact]
    public void Constructor_InitializesDefaults()
    {
        var entity = new IdentityProviderEntity();
        Assert.Null(entity.ProviderTypeName);
        Assert.Equal(IdentityProviderType.None, entity.ProviderType);
        Assert.Null(entity.Url);
        Assert.False(entity.UsesMFA);
        Assert.Null(entity.MFADescription);
        Assert.Null(entity.MFADeviceAddress);
        Assert.Equal(Guid.Empty, entity.CategoryId);
    }

    [Fact]
    public void ProviderType_Property_GetSet_Works()
    {
        var entity = new IdentityProviderEntity();
        entity.ProviderType = IdentityProviderType.Google;
        Assert.Equal(IdentityProviderType.Google, entity.ProviderType);
    }

    [Fact]
    public void ProviderTypeName_Property_GetSet_Works()
    {
        var entity = new IdentityProviderEntity();
        entity.ProviderTypeName = "Google";
        Assert.Equal("Google", entity.ProviderTypeName);
    }

    [Fact]
    public void InheritedProperties_GetSet_Works()
    {
        var entity = new IdentityProviderEntity
        {
            Url = "https://login.example.com",
            UsesMFA = true,
            MFADescription = "App",
            MFADeviceAddress = "user@example.com",
            Name = "Account",
            Description = "desc",
            CategoryId = Guid.NewGuid(),
            UserId = "user",
            Password = "pw"
        };

        Assert.Equal("https://login.example.com", entity.Url);
        Assert.True(entity.UsesMFA);
        Assert.Equal("App", entity.MFADescription);
        Assert.Equal("user@example.com", entity.MFADeviceAddress);
        Assert.Equal("Account", entity.Name);
        Assert.Equal("desc", entity.Description);
        Assert.Equal("user", entity.UserId);
        Assert.Equal("pw", entity.Password);
    }

    [Fact]
    public void Dispose_ClearsSensitiveFields()
    {
        var entity = new IdentityProviderEntity
        {
            ProviderTypeName = "Google",
            ProviderType = IdentityProviderType.Google,
            Url = "https://login.example.com",
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

        Assert.Null(entity.ProviderTypeName);
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