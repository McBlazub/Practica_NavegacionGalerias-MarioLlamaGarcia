using System.Collections.ObjectModel;

namespace Practica_NavegacionGalerias_MarioLlamaGarcia;

public partial class GalleryPage : ContentPage
{
    public ObservableCollection<Animales> Animals { get; set; }

    public GalleryPage()
    {
        InitializeComponent();

        Animals = new ObservableCollection<Animales>
        {
            new Animales { 
                Nombre = "Elefante",
                Imagen = "img_ele.jpg", 
                Descripcion = "Pertenece a la familia de mamíferos placentarios del orden proboscideos. Antiguamente se clasificaban, junto con otros mamíferos de piel gruesa, en el orden, ahora inválido, " +
                "de los paquidermos.\r \n Hoy en día existen tres especies y diversas subespecies.\r \nEntre los géneros extintos de esta familia destacan los mamuts.\r \nLos elefantes son los animales terrestres " +
                "más grandes que existen en la actualidad. Los elefantes actuales se clasifican en dos géneros distintos, Loxodonta (elefantes africanos) y Elephas (elefantes asiáticos), pertenecientes a dos" +
                " tribus distintas." 
            },

            new Animales { 
                Nombre = "Hipopótamo",
                Imagen = "img_hip.jpg", 
                Descripcion = "Este mamifero es un gran mamífero artiodáctilo fundamentalmente herbívoro que habita en el África subsahariana. Es un animal semiacuático que habita en ríos y lagos y donde machos " +
                "adultos territoriales con grupos de cinco a treinta hembras y jóvenes controlan una zona del río.\r \nDurante el día reposan en el agua o en el fango y al anochecer se vuelven más activos y salen" +
                " a comer hierbas terrestres. Es fácilmente reconocible por su torso en forma de barril, enorme boca y dientes, cuerpo con la piel lisa y casi sin pelo, patas rechonchas y su gran tamaño. Es el quinto" +
                " animal terrestre por su peso (entre 1,5 y 3 toneladas), por detrás del rinoceronte.\r \nA pesar de su parecido físico con los cerdos y otros ungulados terrestres, sus parientes vivos más cercanos son" +
                " los cetáceos. Es, junto al hipopótamo pigmeo, uno de los dos únicos miembros actuales de la familia Hippopotamidae."
            },

            new Animales {
                Nombre = "Jabali",
                Imagen = "img_jab.webp", 
                Descripcion = "Es una especie de mamífero artiodáctilo de la familia de los suidos. Se trata de un mamífero de tamaño mediano provisto de una cabeza grande y alargada, en la que destacan unos ojos muy" +
                " pequeños. El cuello es grueso y las patas son muy cortas,lo que acentúa aún más su rechoncho cuerpo. Compensa su mala vista con un importante desarrollo del olfato.\r \nEs de comportamiento muy sociable," +
                " no es muy territorialista y se desplaza en grupos matriarcales." 
            },

            new Animales { 
                Nombre = "Rinoceronte",
                Imagen = "img_rin.jpg", 
                Descripcion = "Este mamifero se trata de un animal placentario del suborden ceratomorfos perteneciente al orden de los perisodáctilos.\r \nDestaca por sus característicos cuernos en el hocico, su fuerte coraza" +
                " y gran tamaño, siendo de las pocas especies consideradas como megafauna existentes hoy día, junto con elefantes e hipopótamos; todas las especies pueden sobrepasar como mínimo la tonelada de peso.\r \nActualmente" +
                " existen cinco especies: el rinoceronte blanco y el rinoceronte negro en África y el rinoceronte de Java, el rinoceronte de la India y el rinoceronte de Sumatra en Asia. Según la clasificación de estado de" +
                " conservación confeccionada por la Unión Internacional para la Conservación de la Naturaleza, las especies de rinocerontes de Java, Sumatra y negro se encuentran en «peligro crítico»; el de la India se considera" +
                " «vulnerable» y el blanco «casi amenazado»."
            }
        };

        BindingContext = this;
    }

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var animal = button?.CommandParameter as Animales;

        if (animal != null)
        {
            await Navigation.PushAsync(new AnimalDetailPage(animal));
        }
    }


}