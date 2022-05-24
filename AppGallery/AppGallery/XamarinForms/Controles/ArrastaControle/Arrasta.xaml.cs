using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ArrastaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Arrasta : ContentPage
    {
        public Arrasta()
        {
            InitializeComponent();
        }

        private void SwipeDetalhe(object sender, EventArgs e)
        {
            lblDetalhe.Text = $"Acionado Detalhe: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeEditar(object sender, EventArgs e)
        {
            lblEditar.Text = $"Acionado Editar: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeExcluir(object sender, EventArgs e)
        {
            lblExcluir.Text = $"Acionado Excluir: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            lblStarted.Text = $"Acionado SwipeStarted: {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection}";
        }

        private void SwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            lblChanging.Text = $"Acionado SwipeChanging: {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection}:{e.Offset}";
        }

        private void SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            lblEnded.Text = $"Acionado SwipeEnded: {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection}";
        }


        private void SwipeCloseRequested(object sender, CloseRequestedEventArgs e)
        {
            lblClose.Text = $"Acionado SwipeClose: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void CloseSwipeView(object sender, EventArgs e)
        {
            SwipeViewControle.Close();
        }
    }
}