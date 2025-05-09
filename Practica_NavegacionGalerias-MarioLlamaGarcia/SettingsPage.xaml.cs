namespace Practica_NavegacionGalerias_MarioLlamaGarcia;

public partial class SettingsPage : ContentPage
{
    /// <summary>
    /// Aquí funcionará toda la lógica de las opciones
    /// </summary>
	public SettingsPage()
	{
		InitializeComponent();

        VersionLabel.Text = $"Versión: {AppInfo.Current.VersionString}";
    }

    private void TemaVisual(object sender, ToggledEventArgs e)
    {
        if (e.Value)
            App.Current.UserAppTheme = AppTheme.Light; //Modo claro
        else
            App.Current.UserAppTheme = AppTheme.Dark; //Modo oscuro
    }
}