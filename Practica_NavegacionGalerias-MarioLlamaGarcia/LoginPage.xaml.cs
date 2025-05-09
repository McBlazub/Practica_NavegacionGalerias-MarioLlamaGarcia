
namespace Practica_NavegacionGalerias_MarioLlamaGarcia;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Aquí se crea toda la base para loggearse, siendo la base de el usuario y la contraseña.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        //Usuario
        string usuario = UsernameEntry.Text?.Trim();

        //Contraseña
        string contraseña = PasswordEntry.Text;

        //Se inicializa el programa al introducir correctamente el usuario y contraseña.

        if (usuario == "admin" && contraseña == "1234")
        {
            Application.Current.MainPage = new AppShell(); 
        }
        else //Si no, te dará error y volverás a probar.
        {
            await DisplayAlert("Error", "Pruebe de nuevo porfavor", "Aceptar");
        }
    }

}