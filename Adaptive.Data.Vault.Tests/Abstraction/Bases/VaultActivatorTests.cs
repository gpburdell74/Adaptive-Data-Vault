using Adaptive.Data.Vault;
using Adaptive.Data.Vault.Abstraction;
using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.Tests.Abstraction.Bases;

public class VaultActivatorTests
{
    [Fact]
    public void CreateInstance_SecureNoteEntity_ReturnsInstance()
    { 
        SecureNoteEntity note = VaultActivator.CreateInstance<SecureNoteEntity>();
        Assert.NotNull(note);
        Assert.IsType<SecureNoteEntity>(note);
    }

    [Fact]
    public void CreateInstance_IdentityProviderEntity_ReturnsInstance()
    {
        var instance = VaultActivator.CreateInstance<IIdentityProviderEntity>();
        Assert.NotNull(instance);
        Assert.IsType<IdentityProviderEntity>(instance);
    }

    [Fact]
    public void CreateInstance_UnsupportedType_ThrowsException()
    {
        Assert.Throws<Exception>(() => VaultActivator.CreateInstance<DummyEntity>());
    }

    [Fact]
    public void CreateInstanceForEntity_SecureNoteEntity_ReturnsBusinessBase()
    {
        var entity = new SecureNoteEntity();
        var result = VaultActivator.CreateInstanceForEntity(entity);
        Assert.NotNull(result);
        Assert.IsType<SecureNote>(result);
    }

    [Fact]
    public void CreateInstanceForEntity_UnsupportedType_ThrowsException()
    {
        var entity = new DummyEntity();
        Assert.Throws<Exception>(() => VaultActivator.CreateInstanceForEntity(entity));
    }

    // Dummy entity for negative test
    private class DummyEntity : IEntity
    {
        public Guid? CategoryId { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? UserId { get; set; }

        public void Dispose()
        {
            CategoryId = null;
            Description = null;
            Name = null;
            Password = null;
            UserId = null;
            GC.SuppressFinalize(this);
        }
    }
}