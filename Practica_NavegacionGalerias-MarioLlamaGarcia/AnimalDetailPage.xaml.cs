namespace Practica_NavegacionGalerias_MarioLlamaGarcia;

public partial class AnimalDetailPage : ContentPage
{
    /// <summary>
    ///Se recurrirá a la clase de Animal.cs para crear al animal en cuestión.
    /// <summary>
    public AnimalDetailPage(Animales animal)
    {
        InitializeComponent();
        BindingContext = animal;
    }
}