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
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmFilmInfo("upgrade"));
            Application.Run(new MainContext());
            //Application.Run(new frmProfielpagina());
            //Application.Run(new frmPayment());
        }
    }
}