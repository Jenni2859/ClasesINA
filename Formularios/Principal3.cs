using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA.Formularios
{
    public partial class Principal3 : MaterialForm
    {

        List<string> NameProduct = new List<string>();
        List<double> unitPrice = new List<double>();
        List<int> amount = new List<int>();
        List<double> total = new List<double>();

        public Principal3()
        {
            InitializeComponent();
        }

        private void Principal3_Load(object sender, EventArgs e)
        {

        }


        private void priceUnit_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            bool EsNumero = double.TryParse(priceUnit.Text, out numero);

            int PriceUnit = Convert.ToInt32(priceUnit.Text);
            int uniSale = Convert.ToInt32(Units.Value);

            double Totalpago = sacarTotal(PriceUnit, uniSale);

            if (EsNumero)
            {
                TotalPrice.Text = "" + Totalpago;
            }
            else
            {
                priceUnit.Focus();
                priceUnit.Hint = "Debe de ser un numero";
                priceUnit.SelectAll();
                priceUnit.BackColor = Color.Red;
            }
        }

        private void Units_onValueChanged(object sender, int newValue)
        {
            int PriceUnit = Convert.ToInt32(priceUnit.Text);
            int uniSale = Convert.ToInt32(Units.Value);

            double Totalpago = sacarTotal(PriceUnit, uniSale);
            TotalPrice.Text = "" + Totalpago;

        }

        private void sale_Click(object sender, EventArgs e)
        {
            string nombreProduct = NewProduct.Text;
            int unidades = Convert.ToInt32(Units.Value);
            double precioUnidades = Convert.ToDouble(priceUnit.Text);
            double totalpago = Convert.ToDouble(TotalPrice.Text);


            if (totalpago <= 0 || precioUnidades <= 0)
            {
                MessageBox.Show("Los valores no pueden ser cero");

            }
            else
            {
                if (string.IsNullOrEmpty(nombreProduct))
                {
                    MessageBox.Show("El nombre no debe de ser cero");
                }
                else 
                {
                    NameProduct.Add(nombreProduct);
                    amount.Add(unidades);
                    unitPrice.Add(precioUnidades);
                    total.Add(totalpago);


                    DetailSale.Rows.Add(NewProduct.Text, Units.Value, priceUnit.Text, TotalPrice.Text);

                    NewProduct.Text = "";
                    Units.Value = 0;
                    priceUnit.Text = "";
                    TotalPrice.Text = "0.0";



                }
            }

            
        }

        private double sacarTotal(double PrecioUnitario, int UnidadesComprar)
        {
            double Total = PrecioUnitario * UnidadesComprar;

            return Total;

        }

        
    }
}
