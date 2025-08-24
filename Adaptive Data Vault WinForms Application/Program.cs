namespace Adaptive.Data.Vault.UI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // re-create.
        //MasterTest t = new MasterTest();
        //t.ExecuteMasterTest();
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        MainDialog dialog = new MainDialog();
        Application.Run(dialog);
        dialog.Dispose();
        dialog = null;
    }
}