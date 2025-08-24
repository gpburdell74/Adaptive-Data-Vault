using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.DataAccess.Tests.Entity;

public class UserCategoryEntityTests
{
    [Fact]
    public void DefaultConstructor_InitializesIdAndDefaults()
    {
        var entity = new UserCategoryEntity();
        Assert.NotEqual(Guid.Empty, entity.Id);
        Assert.Null(entity.Name);
        Assert.Null(entity.Description);
        Assert.Equal(Guid.Empty, entity.CategoryId);
    }

    [Fact]
    public void Constructor_WithName_SetsName()
    {
        var entity = new UserCategoryEntity("TestCategory");
        Assert.Equal("TestCategory", entity.Name);
        Assert.NotEqual(Guid.Empty, entity.Id);
    }

    [Fact]
    public void Id_Property_GetSet_Works()
    {
        var entity = new UserCategoryEntity();
        var guid = Guid.NewGuid();
        entity.Id = guid;
        Assert.Equal(guid, entity.Id);
    }

    [Fact]
    public void InheritedProperties_GetSet_Works()
    {
        var entity = new UserCategoryEntity
        {
            Name = "CategoryName",
            Description = "CategoryDescription",
            CategoryId = Guid.NewGuid(),
            UserId = "user",
            Password = "pw"
        };

        Assert.Equal("CategoryName", entity.Name);
        Assert.Equal("CategoryDescription", entity.Description);
        Assert.Equal("user", entity.UserId);
        Assert.Equal("pw", entity.Password);
    }

    [Fact]
    public void Dispose_ClearsSensitiveFields()
    {
        var entity = new UserCategoryEntity("TestCategory")
        {
            Description = "desc",
            CategoryId = Guid.NewGuid(),
            UserId = "user",
            Password = "pw"
        };

        var id = entity.Id;
        entity.Dispose();

        Assert.Equal(Guid.Empty, entity.Id);
        Assert.Null(entity.Name);
        Assert.Null(entity.Description);
        Assert.Null(entity.UserId);
        Assert.Null(entity.Password);
        Assert.Null(entity.CategoryId);
    }
}