namespace Film.Kom
{
    public class MainContext : ApplicationContext
    {
        public MainContext()
        {
            var loginForm = new frmLogin();
            loginForm.FormClosed += (s, e) => ExitThread(); // sluit de app als login wordt gesloten
            loginForm.Show();
        }
    }
}
