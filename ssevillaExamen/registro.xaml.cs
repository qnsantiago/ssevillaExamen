using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ssevillaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        string usuario;
        public registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO" + " " + "ES" + " " + usuario;
            this.usuario = usuario;
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string dato1 = txtNombre.Text;
            string dato2 = txtApellido.Text;
            string dato3 = txtEdad.Text;
            string dato5 = dpPais.SelectedItem.ToString();
            String dato6 = dpCiudad.SelectedItem.ToString();
            string dato7 = txtMonto.Text;
            string dato8 = txtPago.Text;
            Navigation.PushAsync(new resumen(dato1, dato2, dato3, dato5, dato6, dato7, dato8));

        }

        private void btnPago_Clicked(object sender, EventArgs e)
        {

            double Monto = Convert.ToDouble(txtMonto.Text);
            double incremento = (1500 * 4) /100;
            double mensual = ((1500 - Monto) / 4) + incremento;
            double CPago = (mensual * 4) + Monto;
            txtPago.Text = CPago.ToString();

        }
        private void dpPais_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void dpCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    
