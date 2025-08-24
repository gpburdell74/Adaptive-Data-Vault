namespace Adaptive.Data.Vault.DataAccess.Tests.Entity;

public class EntityBaseTests
{
    [Fact]
    public void Constructor_SetsDefaultCategoryId()
    {
        var entity = new MockEntity();
        Assert.Equal(Guid.Empty, entity.CategoryId);
    }

    [Fact]
    public void Name_Property_GetSet_Works()
    {
        var entity = new MockEntity();
        entity.Name = "TestName";
        Assert.Equal("TestName", entity.Name);
    }

    [Fact]
    public void Description_Property_GetSet_Works()
    {
        var entity = new MockEntity();
        entity.Description = "TestDescription";
        Assert.Equal("TestDescription", entity.Description);
    }

    [Fact]
    public void CategoryId_Property_GetSet_Works()
    {
        var entity = new MockEntity();
        var guid = Guid.NewGuid();
        entity.CategoryId = guid;
        Assert.Equal(guid, entity.CategoryId);
    }

    [Fact]
    public void UserId_Property_SecureStringBehavior()
    {
        var entity = new MockEntity();
        entity.UserId = "user1";
        Assert.Equal("user1", entity.UserId);

        // Update value
        entity.UserId = "user2";
        Assert.Equal("user2", entity.UserId);

        // Clear value
        entity.UserId = null;
        Assert.Null(entity.UserId);
    }

    [Fact]
    public void Password_Property_SecureStringBehavior()
    {
        var entity = new MockEntity();
        entity.Password = "pass1";
        Assert.Equal("pass1", entity.Password);

        // Update value
        entity.Password = "pass2";
        Assert.Equal("pass2", entity.Password);

        // Clear value
        entity.Password = null;
        Assert.Null(entity.Password);
    }

    [Fact]
    public void Dispose_ClearsSensitiveFields()
    {
        var entity = new MockEntity
        {
            Name = "n",
            Description = "d",
            CategoryId = Guid.NewGuid(),
            UserId = "user",
            Password = "pw"
        };

        entity.Dispose();

        Assert.Null(entity.Name);
        Assert.Null(entity.Description);
        Assert.Null(entity.UserId);
        Assert.Null(entity.Password);
        Assert.Null(entity.CategoryId);
    }
}

