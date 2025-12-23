using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.DataAccess.Tests.Entity;
public class SecureNoteEntityTests
{
    [Fact]
    public void Constructor_InitializesDefaults()
    {
        var entity = new SecureNoteEntity();
        Assert.Null(entity.SecureContent);
        Assert.Null(entity.Name);
        Assert.Null(entity.Description);
        Assert.Equal(Guid.Empty, entity.CategoryId);
    }

    [Fact]
    public void SecureContent_Property_GetSet_Works()
    {
        var entity = new SecureNoteEntity();
        entity.SecureContent = "Secret";
        Assert.Equal("Secret", entity.SecureContent);

        // Overwrite with new value
        entity.SecureContent = "NewSecret";
        Assert.Equal("NewSecret", entity.SecureContent);

        // Set to null
        entity.SecureContent = null;
        Assert.Null(entity.SecureContent);
    }

    [Fact]
    public void InheritedProperties_GetSet_Works()
    {
        var entity = new SecureNoteEntity
        {
            Name = "NoteName",
            Description = "NoteDescription",
            CategoryId = Guid.NewGuid(),
            UserId = "user",
            Password = "pw"
        };

        Assert.Equal("NoteName", entity.Name);
        Assert.Equal("NoteDescription", entity.Description);
        Assert.Equal("user", entity.UserId);
        Assert.Equal("pw", entity.Password);
    }

    [Fact]
    public void Dispose_ClearsSensitiveFields()
    {
        var entity = new SecureNoteEntity
        {
            SecureContent = "Secret",
            Name = "NoteName",
            Description = "NoteDescription",
            CategoryId = Guid.NewGuid(),
            UserId = "user",
            Password = "pw"
        };

        entity.Dispose();

        Assert.Null(entity.SecureContent);
        Assert.Null(entity.Name);
        Assert.Null(entity.Description);
        Assert.Null(entity.UserId);
        Assert.Null(entity.Password);
        Assert.Null(entity.CategoryId);
    }
}
