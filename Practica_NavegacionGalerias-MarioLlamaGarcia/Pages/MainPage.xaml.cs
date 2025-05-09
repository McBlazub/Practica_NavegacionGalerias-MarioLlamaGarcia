using Practica_NavegacionGalerias_MarioLlamaGarcia.Models;
using Practica_NavegacionGalerias_MarioLlamaGarcia.PageModels;

namespace Practica_NavegacionGalerias_MarioLlamaGarcia.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}