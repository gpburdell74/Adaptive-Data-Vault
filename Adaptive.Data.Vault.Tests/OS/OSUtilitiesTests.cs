using Adaptive.Data.Vault.OS;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Adaptive.Data.Vault.Tests.OS
{
    public class OSUtilitiesTests
    {
        [Fact]
        public void GetVersionOfExecutable_ReturnsValidVersion()
        {
            // Act
            Version version = OSUtilities.GetVersionOfExecutable();

            // Assert
            Assert.NotNull(version);
            Assert.True(version.Major >= 0);
            Assert.True(version.Minor >= 0);
        }

        [Fact]
        public void GetAdaptiveFrameworkVersion_ReturnsValidVersion()
        {
            // Act
            Version version = OSUtilities.GetAdaptiveFrameworkVersion();

            // Assert
            Assert.NotNull(version);
            Assert.True(version.Major >= 0);
            Assert.True(version.Minor >= 0);
        }

        [Fact]
        public void RenderBrowserStartCommand_ReturnsPath_WhenWindowsPathExists()
        {
            // Use reflection to invoke private method
            var method = typeof(OSUtilities).GetMethod("RenderBrowserStartCommand", BindingFlags.NonPublic | BindingFlags.Static);
            if (method != null)
            {
                string? result = (string?)method.Invoke(null, null);

                // Assert
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    Assert.False(string.IsNullOrEmpty(result));
                else
                    Assert.True(result == null || result.Contains("explorer.exe"));
            }
        }

        [Fact]
        public void GetWindowsPath_ReturnsPathOrNull()
        {
            // Use reflection to invoke private method
            var method = typeof(OSUtilities).GetMethod("GetWindowsPath", BindingFlags.NonPublic | BindingFlags.Static);
            if (method != null)
            {
                string? result = (string?)method.Invoke(null, null);

                // Assert
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    Assert.False(string.IsNullOrEmpty(result));
                else
                    Assert.True(result == null || result == string.Empty);
            }
        }
    }
}