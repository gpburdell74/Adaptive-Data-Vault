using System;
using Adaptive.Data.Vault;
using Adaptive.Intelligence.Shared.Security;
using Xunit;

namespace Adaptive.Data.Vault.Tests
{
    public class SecureFileParametersTests : IDisposable
    {
        private readonly SecureFileParameters _parameters;

        public SecureFileParametersTests()
        {
            _parameters = new SecureFileParameters();
        }

        [Fact]
        public void FileName_GetSet_WorksCorrectly()
        {
            string expected = "testfile.dat";
            _parameters.FileName = expected;
            Assert.Equal(expected, _parameters.FileName);
        }

        [Fact]
        public void UserId_GetSet_WorksCorrectly()
        {
            string expected = "testuser";
            _parameters.UserId = expected;
            Assert.Equal(expected, _parameters.UserId);
        }

        [Fact]
        public void Password_GetSet_WorksCorrectly()
        {
            string expected = "secret";
            _parameters.Password = expected;
            Assert.Equal(expected, _parameters.Password);
        }

        [Fact]
        public void Pin_GetSet_WorksCorrectly()
        {
            int expected = 1234;
            _parameters.Pin = expected;
            Assert.Equal(expected, _parameters.Pin);
        }

        [Fact]
        public void Dispose_ClearsProperties()
        {
            _parameters.FileName = "file";
            _parameters.UserId = "user";
            _parameters.Password = "pass";
            _parameters.Pin = 42;

            _parameters.Dispose();

            Assert.Null(_parameters.FileName);
            Assert.Null(_parameters.UserId);
            Assert.Null(_parameters.Password);
            Assert.Equal(0, _parameters.Pin);
        }

        public void Dispose()
        {
            _parameters.Dispose();
        }
    }
}