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
    public partial class Principal : MaterialForm
    {
        string[] Productos = { };
        int[] unidadesCompra = { };
        double[] precioUnidad = { };
        double[] totalpago = { };

        
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private void precio_Leave(object sender, EventArgs e)
        {
            if (precio.Text.Length >= 0)
            {
                double numero = 0;
                bool EsNumero = double.TryParse(precio.Text, out numero);

                if (EsNumero)
                {
                    int PrecioUnitario = Convert.ToInt32(precio.Text);
                    int unidadesCompradas = Convert.ToInt32(Unidades.Value);
                    TotalPrecio.Text = "" + PrecioUnitario * unidadesCompradas;
                }
                else
                {
                    precio.Focus();
                    precio.Hint = "Debe de ser un numero";
                    precio.SelectAll();
                    precio.BackColor = Color.Red;
                }

            }

        }

        private void Unidades_onValueChanged(object sender, int newValue)
        {
            int PrecioUnitario = Convert.ToInt32(precio.Text);
            int unidadesCompradas = Convert.ToInt32(Unidades.Value);
            TotalPrecio.Text = "" + PrecioUnitario * unidadesCompradas;
        }

        private void Compra_Click(object sender, EventArgs e)
        {
            string nombreProduct = Producto.Text;
            int unidades = Convert.ToInt32(Unidades.Value);
            double precioUnidades = Convert.ToDouble(precio.Text);
            double total = Convert.ToDouble(TotalPrecio.Text);


            if (total <=0 || precioUnidades <= 0)
            {
                MessageBox.Show("Los valores no pueden ser cero");

            }
            else
            {
                if (string.IsNullOrEmpty(nombreProduct))
                {
                    MessageBox.Show("El nombre no debe de ser cero");
                }
                else // se realiza la inserción y se redimenciona los vectores
                {
                    Array.Resize(ref Productos, Productos.Length +1);
                    Array.Resize(ref unidadesCompra, unidadesCompra.Length +1);
                    Array.Resize(ref precioUnidad, precioUnidad.Length +1);
                    Array.Resize(ref totalpago, totalpago.Length + 1);

                    Productos[Productos.Length - 1] = nombreProduct;
                    unidadesCompra[unidadesCompra.Length - 1] = unidades;
                    precioUnidad[precioUnidad.Length - 1] = precioUnidades;
                    totalpago[totalpago.Length - 1] = total;

                    DetalleCompra.Rows.Add(Producto.Text, Unidades.Value, precio.Text, TotalPrecio.Text);

                    Producto.Text = "";
                    Unidades.Value = 0;
                    precio.Text = "";
                    TotalPrecio.Text = "0.0";

                    //MessageBox.Show("Compra efectuada con éxito");
                    //Producto.Focus();

                    

                }
            }


        }
    }
}
