using AppGallery.XamarinForms.Concha.Hamburguer.Modelos;
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
        public static List<Animal> ListaDeCachorros = new List<Animal>
        {
            new Animal {Id = 1, Idade = 2, Nome = "Paçoquinha", Tipo="Cachorro"},
            new Animal {Id = 2, Idade = 5, Nome = "Lulu", Tipo="Cachorro"},
            new Animal {Id = 3, Idade = 10, Nome = "Dog", Tipo="Cachorro"},
        };
        public Cachorro()
        {
            InitializeComponent();

            ListViewCachorro.ItemsSource = ListaDeCachorros;
        }

        private async void AbrirGato(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//domesticos/populares/gato");
        }

        private async void AbriCachorroDetalhe(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("CachorroDetalhe");
        }

        private async void ListViewCachorro_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Animal animal = (Animal)e.Item;

            await Shell.Current.GoToAsync($"cachorrodetalhe?animalId={animal.Id}");
        }
    }
}