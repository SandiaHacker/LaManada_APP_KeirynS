namespace LaManada_APP_KeirynS.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		
	}

    private void SwShowPassword_Toggled(object sender, ToggledEventArgs e)
    {
        TxtPassword.IsPassword = true;

        if (SwShowPassword.IsToggled)
        {
            TxtPassword.IsPassword = false;
        }
    }
}