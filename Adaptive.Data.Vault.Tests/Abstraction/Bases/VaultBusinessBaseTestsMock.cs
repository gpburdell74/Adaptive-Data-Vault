using Adaptive.Data.Vault.Entities;

namespace Adaptive.Data.Vault.Tests.Abstraction.Bases
{
    public class VaultBusinessBaseTestsMock : VaultBusinessBase<WebAccountEntity>
    { 
        public VaultBusinessBaseTestsMock() : base()
        {
        }
        public VaultBusinessBaseTestsMock(WebAccountEntity entity) : base(entity)
        {
        }
        public void SetEntityTest(WebAccountEntity entity)
        {
            SetEntity(entity);
        }
    }
}
