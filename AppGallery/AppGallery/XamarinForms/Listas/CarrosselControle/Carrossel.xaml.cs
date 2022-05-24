using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CarrosselControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrossel : ContentPage
    {
        private ObservableCollection<Colaborador> colaboradores { get; set; }
        public Carrossel()
        {
            InitializeComponent();

            colaboradores = GetColaboradores();
            Carrossel01.ItemsSource = colaboradores;
        }
        private ObservableCollection<Colaborador> GetColaboradores()
        {
            return new ObservableCollection<Colaborador>()
            {
                new Colaborador(){Nome = "João Ribeiro", Cargo = "Web Designer", Descricao = "Sou Web Designer desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Illustrator e Autodesk 3D MAX"},
                new Colaborador(){Nome = "Felipe Rodrigues", Cargo ="Programador", Descricao = "Sou Programador desde 2010. Trabalhei com JSF, JSP, Java EE, HTML e CSS"},
                new Colaborador(){Nome = "José Ribeiro", Cargo = "Programador Web", Descricao = "Sou Programador Web desde 2000. COnheço PHP, Frameworks como Laravel, Codeingnite e Zend Framework"},
                new Colaborador(){Nome = "Maria Ribeiro", Cargo = "Programador PHP", Descricao = "Sou Programadora PHP desde 2000. COnheço PHP, Frameworks como Laravel, Codeingnite e Zend Framework"},

            };
        }

        private void Carrossel01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            
            colaboradores.Add(new Colaborador() { Nome = "Emanoel Rodrigues", Cargo = "Programador PHP", Descricao = "Sou Programadora PHP desde 2000. COnheço PHP, Frameworks como Laravel, Codeingnite e Zend Framework" });
            colaboradores.Add(new Colaborador() { Nome = "Madalena Rodrigues", Cargo = "Programador PHP", Descricao = "Sou Programadora PHP desde 2000. COnheço PHP, Frameworks como Laravel, Codeingnite e Zend Framework" });
            colaboradores.Add(new Colaborador() { Nome = "Jessica Rodrigues", Cargo = "Programador PHP", Descricao = "Sou Programadora PHP desde 2000. COnheço PHP, Frameworks como Laravel, Codeingnite e Zend Framework" });

            Carrossel01.RemainingItemsThreshold = -1;
            Carrossel01.ItemsSource = colaboradores;
        }

        private void Carrossel01_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            LblPosition.Text = "Posição: " + e.CurrentPosition + " - Posição anterior: " + e.PreviousPosition;
        }
        private void Carrossel01_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            var colaborador = (Colaborador)e.CurrentItem;
            LblItem.Text = "Nome: " + colaborador.Nome;
        }

        private void Carrossel01_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            LblScroll.Text = "ScrollX: " + e.HorizontalOffset;
        }
    }
    public class Colaborador 
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }

    }
}