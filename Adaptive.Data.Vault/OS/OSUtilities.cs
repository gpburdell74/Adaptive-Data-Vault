using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.Logging;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Adaptive.Data.Vault.OS;
/// <summary>
/// Provides static methods / functions for interacting with the operating system.
/// </summary>
public static class OSUtilities
{
    #region Private Constants		
    /// <summary>
    /// The explorer executable name.
    /// </summary>
    private const string ExplorerExe = "\\explorer.exe";
    #endregion

    #region Public Methods / Functions
    /// <summary>
    /// Attempts to start the default web browser session and open the specified URL value.
    /// </summary>
    /// <param name="url">
    /// A string containing the URL value to browse to.
    /// </param>
    public static void StartBrowser(string url)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            StartBrowserOnWindows(url);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("xdg-open", url);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Process.Start("open", url);
        }
    }
    /// <summary>
    /// Attempts to start the default web browser session and open the specified URL value.
    /// </summary>
    /// <param name="url">
    /// A string containing the URL value to browse to.
    /// </param>
    public static void StartBrowserOnWindows(string url)
    {
        url = url.Replace("&", "^&");

        try

        {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            ExceptionLog.LogException(ex);
        }
    }

    /// <summary>
    /// Gets the version of the currently executing assembly.
    /// </summary>
    /// <returns>
    /// A <see cref="Version"/> instance containing the version data, or all zeroes (0.0.0.0) if
    /// the version query fails.
    /// </returns>
    public static Version GetVersionOfExecutable()
    {
        Version? version = null;

        try
        {
            Assembly? exeAssembly = Assembly.GetExecutingAssembly();
            if (exeAssembly != null)
            {
                AssemblyName? exeName = exeAssembly.GetName();
                if (exeName != null)
                {
                    Version? exeVersion = exeName.Version;
                    if (exeVersion != null)
                    {
                        version = new Version(
                            exeVersion.Major,
                            exeVersion.Minor,
                            exeVersion.Build,
                            exeVersion.Revision);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionLog.LogException(ex);
        }
        if (version == null)
            version = new Version(0, 0, 0, 0);

        return version;
    }

    /// <summary>
    /// Gets the version of the underlying Adaptive Intelligence Framework library.
    /// </summary>
    /// <returns>
    /// A <see cref="Version"/> instance containing the version data, or all zeroes (0.0.0.0) if
    /// the version query fails.
    /// </returns>
    public static Version GetAdaptiveFrameworkVersion()
    {
        Version? version = null;

        try
        {
            Assembly? frameworkAssembly = Assembly.GetAssembly(typeof(DisposableObjectBase));
            if (frameworkAssembly != null)
            {
                AssemblyName? frameworkName = frameworkAssembly.GetName();
                if (frameworkName != null)
                {
                    Version? frameworkVersion = frameworkName.Version;
                    if (frameworkVersion != null)
                    {
                        version = new Version(
                        frameworkVersion.Major,
                        frameworkVersion.Minor,
                        frameworkVersion.Build,
                        frameworkVersion.Revision);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionLog.LogException(ex);
        }
        if (version == null)
            version = new Version(0, 0, 0, 0);

        return version;
    }
    #endregion

    #region Private Methods / Functions		
    /// <summary>
    /// Renders the command line needed to start the browser to browse to the specified URL.
    /// </summary>
    /// <param name="url">
    /// A string containing the URL value to browse to.
    /// </param>
    /// <returns>
    /// A string containing the command, or <b>null</b> if the operation is not valid.
    /// </returns>
    private static string? RenderBrowserStartCommand()
    {
        string? callPath = null;

        string? windowsPath = GetWindowsPath();
        if (!string.IsNullOrEmpty(windowsPath))
        {
            StringBuilder builder = new StringBuilder();

            //  <drive>:\<path>
            builder.Append(windowsPath);

            // \explorer.exe 
            builder.Append(ExplorerExe);

            // Should look similar to:
            // C:\Windows\explorer.exe
            callPath = builder.ToString();
            builder.Clear();
        }

        return callPath;

    }
    /// <summary>
    /// Gets the Windows operating system path.
    /// </summary>
    /// <returns>
    /// A string containing the path, if successful; otherwise, returns <b>null</b>.
    /// </returns>
    private static string? GetWindowsPath()
    {
        string? path = null;

        try
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        }
        catch (Exception ex)
        {
            ExceptionLog.LogException(ex);
            path = null;
        }

        return path;
    }
    #endregion
}
