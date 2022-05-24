﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.AtualizarControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Atualizar : ContentPage
    {
        public Atualizar()
        {
            InitializeComponent();
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            lblStatus.Text = $"Atualizado: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";

            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}


