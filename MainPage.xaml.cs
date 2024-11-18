using CadastroDeEventosApp.Models;
using CadastroDeEventosApp.Views;
using System.Windows.Input;

namespace CadastroDeEventosApp
{
    public partial class MainPage : ContentPage
    {
        public Evento EventoAtual { get; set; }
        public ICommand CadastrarEventoCommand { get; }

        public MainPage()
        {
            InitializeComponent();

            EventoAtual = new Evento();
            CadastrarEventoCommand = new Command(CadastrarEvento);

            BindingContext = this;
        }

        private async void CadastrarEvento()
        {
            await Navigation.PushAsync(new ResumoPage(EventoAtual));
        }
    }
}
