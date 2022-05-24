using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.CampoDeEntradaSimplesControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoDeEntradaSimples : ContentPage
    {
        public CampoDeEntradaSimples()
        {
            InitializeComponent();
        }
        
        private void Entra(object sender, EventArgs e)
        {
            Label1.Text = Caixa1.Text;
            
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "Campo focado!";
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            lblUnfocus.Text = "Foco removido do campo!";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextchange.Text = e.NewTextValue + "-" +e.NewTextValue.Length;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            lblCompleted.Text = "Preenchimento finalizado!";
        }
    }
}