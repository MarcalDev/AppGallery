using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Concha.Hamburguer.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cachorro : ContentPage
    {
        public Cachorro()
        {
            InitializeComponent();
        }

        private async void AbrirGato(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//domesticos/populares/gato");
        }
    }
}