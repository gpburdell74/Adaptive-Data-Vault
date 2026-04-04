using Adaptive.Intelligence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptive.Data.Vault.Tests
{
    public class SecureDeleteClientMock : SecureDeleteClient
    {
        public bool RaiseStatusUpdateEvent(ProgressUpdateEventArgs e)
        {
            bool didNotCrash = false;

            base.OnStatusUpdate(e);

            return true;
        }
    }
}
