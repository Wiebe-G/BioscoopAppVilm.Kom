namespace Film.Kom
{
    public class MainContext : ApplicationContext
    {
        // Wiebe
        public MainContext()
        {
            var MainForm = new frmMainMenu();
            MainForm.FormClosed += (s, e) => ExitThread();
            MainForm.Show();
        }
    }
}
