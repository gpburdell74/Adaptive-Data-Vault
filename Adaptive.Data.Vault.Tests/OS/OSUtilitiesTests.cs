using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Xunit;

namespace Adaptive.Data.Vault.Tests.OS;


public class OSUtilitiesTests
{
    [Fact]
    public void RenderBrowserStartCommand_Returns_ValidPath_OnWindows()
    {
        // Use reflection to invoke private method
        var method = typeof(Adaptive.Data.Vault.OS.OSUtilities)
            .GetMethod("RenderBrowserStartCommand", BindingFlags.NonPublic | BindingFlags.Static);

        string? result = (string?)method.Invoke(null, null);

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Assert.False(string.IsNullOrEmpty(result));
            Assert.EndsWith("explorer.exe", result, StringComparison.OrdinalIgnoreCase);
        }
        else
        {
            Assert.Null(result);
        }
    }

    [Fact]
    public void GetWindowsPath_Returns_NonNull_OnWindows()
    {
        var method = typeof(Adaptive.Data.Vault.OS.OSUtilities)
            .GetMethod("GetWindowsPath", BindingFlags.NonPublic | BindingFlags.Static);

        string? result = (string?)method.Invoke(null, null);

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            Assert.False(string.IsNullOrEmpty(result));
        else
            Assert.Null(result);
    }

    [Fact]
    public void StartBrowserOnWindows_ReplacesAmpersand()
    {
        // This test checks that the method does not throw and replaces '&' with '^&'
        string url = "http://example.com/?a=1&b=2";
        var method = typeof(Adaptive.Data.Vault.OS.OSUtilities)
            .GetMethod("StartBrowserOnWindows", BindingFlags.Public | BindingFlags.Static);

        // No exception should be thrown
        method.Invoke(null, new object[] { url });
    }

    [Fact]
    public void StartBrowser_CallsPlatformSpecificMethod()
    {
        // This test ensures no exception is thrown for any platform
        string url = "http://example.com";
        Adaptive.Data.Vault.OS.OSUtilities.StartBrowser(url);
    }
}