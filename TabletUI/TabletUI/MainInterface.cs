using System.Diagnostics;

namespace TabletUI
{
    internal static class MainInterface
    {
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PantallaIngreso());
        }
    }
}