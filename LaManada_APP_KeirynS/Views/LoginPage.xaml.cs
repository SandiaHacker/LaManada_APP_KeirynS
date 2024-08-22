using LaManada_APP_KeirynS.Views;

namespace LaManada_APP_KeirynS.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

		MainPagee = new NavigationPage(new LoginPage());
		
	}
}