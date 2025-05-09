namespace Practica_NavegacionGalerias_MarioLlamaGarcia.Pages
{
    public partial class ProjectListPage : ContentPage
    {
        public ProjectListPage(ProjectListPageModel model)
        {
            BindingContext = model;
            InitializeComponent();
        }
    }
}