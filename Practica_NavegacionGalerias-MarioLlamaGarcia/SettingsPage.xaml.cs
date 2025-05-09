namespace Practica_NavegacionGalerias_MarioLlamaGarcia;

public partial class SettingsPage : ContentPage
{
    /// <summary>
    /// Aqu� funcionar� toda la l�gica de las opciones
    /// </summary>
	public SettingsPage()
	{
		InitializeComponent();

        VersionLabel.Text = $"Versi�n: {AppInfo.Current.VersionString}";
    }

    private void TemaVisual(object sender, ToggledEventArgs e)
    {
        if (e.Value)
            App.Current.UserAppTheme = AppTheme.Light; //Modo claro
        else
            App.Current.UserAppTheme = AppTheme.Dark; //Modo oscuro
    }
}