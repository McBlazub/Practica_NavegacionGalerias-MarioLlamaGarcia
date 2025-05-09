
namespace Practica_NavegacionGalerias_MarioLlamaGarcia;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Aqu� se crea toda la base para loggearse, siendo la base de el usuario y la contrase�a.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        //Usuario
        string usuario = UsernameEntry.Text?.Trim();

        //Contrase�a
        string contrase�a = PasswordEntry.Text;

        //Se inicializa el programa al introducir correctamente el usuario y contrase�a.

        if (usuario == "admin" && contrase�a == "1234")
        {
            Application.Current.MainPage = new AppShell(); 
        }
        else //Si no, te dar� error y volver�s a probar.
        {
            await DisplayAlert("Error", "Pruebe de nuevo porfavor", "Aceptar");
        }
    }

}