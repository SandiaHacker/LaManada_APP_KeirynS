using LaManada_APP_KeirynS.Views;

namespace LaManada_APP_KeirynS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
