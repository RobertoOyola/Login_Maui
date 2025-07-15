namespace appFront.LogIn;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (User.Text == "" || User.Text == null)
		{
			DisplayAlert("Error", "Falta el Usuario", "Ok");
		}
        else if (Password.Text == "" || Password.Text == null)
        {
            DisplayAlert("Error", "Falta la Contrasenia", "Ok");
        }
		else
        {
            DisplayAlert("Login Exitoso", $"El usuario {User.Text} ingreso con exito", "Ok");
        }
    }
}