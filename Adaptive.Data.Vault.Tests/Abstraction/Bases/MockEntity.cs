using Adaptive.Data.Vault.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptive.Data.Vault.Tests.Abstraction.Bases
{
    public class MockEntity : IWebAccountEntity
    {
        public MockEntity()
        {

        }
        public Guid? CategoryId { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? UserId { get; set; }
        public string? MFADescription { get; set; }
        public string? MFADeviceAddress { get; set; }
        public string? Url { get; set; }
        public bool UsesMFA { get; set; }

        public void Dispose()
        {
            Name = null;
            Password = null;
            UserId = null;
            Description = null;
        }
    }
}
