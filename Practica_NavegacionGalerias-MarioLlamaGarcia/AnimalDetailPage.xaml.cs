namespace Practica_NavegacionGalerias_MarioLlamaGarcia;

public partial class AnimalDetailPage : ContentPage
{
    /// <summary>
    ///Se recurrir� a la clase de Animal.cs para crear al animal en cuesti�n.
    /// <summary>
    public AnimalDetailPage(Animales animal)
    {
        InitializeComponent();
        BindingContext = animal;
    }
}