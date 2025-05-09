using Practica_NavegacionGalerias_MarioLlamaGarcia;

namespace Practica_NavegacionGalerias_MarioLlamaGarcia
{
    public partial class App : Application
    {
        /// <summary>
        ///Se define la aplicación, empezando con la página de logearse como principal.
        /// <summary>
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
    }
}