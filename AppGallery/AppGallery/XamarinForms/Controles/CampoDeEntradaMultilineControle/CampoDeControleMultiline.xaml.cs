using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.CampoDeEntradaMultilineControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoDeControleMultiline : ContentPage
    {
        public CampoDeControleMultiline()
        {
            InitializeComponent();
        }
        private void Editor_Focused(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "Campo focado!";
        }

        private void Editor_Unfocused(object sender, FocusEventArgs e)
        {
            lblUnfocus.Text = "Foco removido do campo!";
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextchange.Text = e.NewTextValue + "-" + e.NewTextValue.Length;
        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            lblCompleted.Text = "Preenchimento finalizado!";
        }
    }
}
