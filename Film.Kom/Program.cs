namespace Film.Kom
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            //Application.Run(new frmFilmInfo("upgrade"));
            //Application.Run(new MainContext());
            Application.Run(new frmMainMenu());
            Application.Run(new MainContext());
            //Application.Run(new frmProfielpagina());
            //Application.Run(new frmPayment());
=======
            Application.Run(new MainContext());
            //Application.Run(new frmProfielpagina());
>>>>>>> bad826148ac0bb8a0342d8ec45b55c6d2b71405f
        }
    }
}