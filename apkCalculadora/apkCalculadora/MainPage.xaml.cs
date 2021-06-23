using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace apkCalculadora
{
    public partial class MainPage : ContentPage
    {
        double res = 0;
        public MainPage()
        {
            InitializeComponent();
            wkOperacion.Items.Add("suma");
            wkOperacion.Items.Add("resta");
            wkOperacion.Items.Add("multiplicacion");
            wkOperacion.Items.Add("division");
            wkOperacion.SelectedIndexChanged += WkOperacion_SelectedIndexChanged;
            calcular.Clicked += Calcular_Clicked;
            
        }

        private void WkOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtn1.Text) && !string.IsNullOrEmpty(txtn2.Text))
            {
                String op = wkOperacion.SelectedItem.ToString();
                int n1 = Int32.Parse(txtn1.Text);
                int n2 = Int32.Parse(txtn2.Text);


                if (op == "suma")
                {
                    res = n1 + n2;
                }
                else if (op == "resta")
                {
                    res = n1 - n2;
                }
                else if (op == "multiplicacion")
                {
                    res = n1 * n2;
                }
                else if (op == "division")
                {
                    res = n1 / n2;
                }
                else
                {
                    Console.WriteLine("no se pueden hacer calculos multiples");
                }

            }
            else
            {
                DisplayAlert("Datos erroneos","Por favor llene los cuadros de texto correctamente", "Ok");
            }
            lblRes.Text = res + "";
        }
    }
}
