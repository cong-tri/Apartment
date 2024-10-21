using KTDK_CanHo_DaoCongTri.Authen;
using KTDK_CanHo_DaoCongTri.Models;

namespace KTDK_CanHo_DaoCongTri
{
    internal static class Program
    {
        public static AppDB db = new AppDB();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}