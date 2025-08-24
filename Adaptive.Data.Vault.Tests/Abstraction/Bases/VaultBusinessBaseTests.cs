using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.Tests.Abstraction.Bases;

public class VaultBusinessBaseTests
{
    [Fact]
    public void DefaultConstructor_InitializesEntity()
    {
        var note = new SecureNote();
        Assert.NotNull(note.Entity);
        Assert.Equal(Guid.Empty, note.CategoryId);
    }

    [Fact]
    public void Constructor_WithEntity_SetsEntity()
    {
        var entity = new SecureNoteEntity { CategoryId = Guid.NewGuid() };
        var note = new SecureNote(entity);
        Assert.Equal(entity.CategoryId, note.CategoryId);
        Assert.Same(entity, note.Entity);
    }

    [Fact]
    public void CategoryId_GetSet_WorksCorrectly()
    {
        var note = new SecureNote();
        var testGuid = Guid.NewGuid();
        note.CategoryId = testGuid;
        Assert.Equal(testGuid, note.CategoryId);
    }

    [Fact]
    public void SetEntity_ChangesEntityReference()
    {
        VaultBusinessBaseTestsMock sut = new VaultBusinessBaseTestsMock();

        var entity = new WebAccountEntity { CategoryId = Guid.NewGuid() };
        sut.SetEntityTest(entity);
        Assert.Same(entity, sut.Entity);
        Assert.Equal(entity.CategoryId, sut.CategoryId);
    }

    [Fact]
    public void Dispose_DisposesEntityAndNullsReference()
    {
        var entity = new SecureNoteEntity();
        var note = new SecureNote(entity);
        note.Dispose();
        Assert.Null(note.Entity);
    }
}