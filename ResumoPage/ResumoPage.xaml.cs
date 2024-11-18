using CadastroDeEventosApp.Models;

namespace CadastroDeEventosApp.Views
{
    public partial class ResumoPage : ContentPage
    {
        public ResumoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }
    }
}
