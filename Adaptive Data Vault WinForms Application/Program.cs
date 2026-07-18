namespace Adaptive.Data.Vault.UI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using SplashScreenDialog splash = new SplashScreenDialog();
        splash.Show();
        Application.DoEvents();

        MainDialog dialog = new MainDialog();
        splash.Close();
        Application.Run(dialog);
        dialog.Dispose();
    }
}