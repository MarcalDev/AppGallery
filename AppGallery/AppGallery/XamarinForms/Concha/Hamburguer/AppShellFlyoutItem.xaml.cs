using AppGallery.XamarinForms.Concha.Hamburguer.Paginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Concha.Hamburguer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShellFlyoutItem : Shell
    {
        public AppShellFlyoutItem()
        {
            InitializeComponent();

            Routing.RegisterRoute("cachorrodetalhe", typeof(CachorroDetalhe));
        }

        private void AbrirAppGallery(object sender, EventArgs e)
        {
            App.Current.MainPage = new AppBase.Menu();
        }
    }
}