using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Saude.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private async void Btn1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Paginas.PaginasMenu.Medico());
        }

        private async  void Btn2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Paginas.PaginasMenu.Fala());
        }

        private async void Btn3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Paginas.PaginasMenu.Remedio());
        }

        private async void Btn4 (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Paginas.PaginasMenu.MeuCorpo());
        }
        private async void Btn5 (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Paginas.PaginasMenu.MinhaCasa());
        }
        private async void Btn6 (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Paginas.PaginasMenu.Lupa());
        }
    }
}