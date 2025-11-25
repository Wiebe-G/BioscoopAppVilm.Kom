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
<<<<<<< HEAD
            //Application.Run(new MainContext());
            Application.Run(new frmMainMenu());
=======
            Application.Run(new MainContext());
            //Application.Run(new frmProfielpagina());
>>>>>>> 453e3a6edc54d4e5540ea94ffdd978e72796f3a9
            //Application.Run(new frmPayment());
        }
    }
}