namespace Film.Kom
{
    public class MainContext : ApplicationContext
    {
        public MainContext()
        {
            var MainForm = new frmMainMenu();
            MainForm.FormClosed += (s, e) => ExitThread();
            MainForm.Show();
        }
    }
}
