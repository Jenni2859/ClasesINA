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

        private void Compra_Click(object sender, EventArgs e)
        {
            string nombreProduct = Producto.Text;
            int unidades = Convert.ToInt32(Unidades.Value);
            double precioUnidad = Convert.ToDouble(precio.Text);
            double total = Convert.ToDouble(TotalPrecio.Text);

            if (total <=0 || precioUnidad <=0)
            {
                MessageBox.Show("Los valores no pueden ser cero");

            }
            else
            {
                if (string.IsNullOrEmpty(nombreProduct))
                {
                    MessageBox.Show("El nombre no debe de ser cero");
                }
                else //
                {

                }
            }


        }
    }
}
