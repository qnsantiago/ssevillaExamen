﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ssevillaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resumen : ContentPage
    {
        public resumen(String dato1, string dato2, string dato3, string dato5, string dato6, string dato7, string dato8)
        {
            InitializeComponent();
            txtnombre.Text = dato1;
            txtApellido.Text = dato2;
            txtEdad.Text = dato3;
            txtPais.Text = dato5;
            txtCiudad.Text = dato6;
            txtMonto.Text = dato7;
            txtPago.Text = dato8;


        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {


            Navigation.PushAsync(new login());


        }
    }
}