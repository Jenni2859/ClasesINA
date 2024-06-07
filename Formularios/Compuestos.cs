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
    public partial class Compuestos : MaterialForm
    {
        string[] sexo = { "Hombre", "Mujer", "Otro" };

        string[] marcaCarro = new string[4];
        int contadorMarcasAgregadas = 0;

        public Compuestos()
        {
            InitializeComponent();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
           
            Console.WriteLine(sexo[0]);
            Console.WriteLine(sexo[1]);

        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            CBsexo.Items.Clear();
            CBsexo.Items.AddRange(sexo);
            CBsexo.Items.Add("Otro elemento manual");
        }

        private void RegistrarV_Click(object sender, EventArgs e)
        {
            string marcaAgregar = NameMarca.Text;

            marcaCarro[contadorMarcasAgregadas] = marcaAgregar;

            contadorMarcasAgregadas += 1;

            CantidadVehiculo.Text = ""+ contadorMarcasAgregadas;

            NameMarca.Text = "";


        }

        private void CantidadVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void ASC_Click(object sender, EventArgs e)
        {
            Array.Sort(marcaCarro);
            Console.WriteLine(string.Join(", ", marcaCarro));
        }

        private void DESC_Click(object sender, EventArgs e)
        {
            Array.Reverse(marcaCarro);
            Console.WriteLine(string.Join (", ", marcaCarro));
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            Marcas.Items.Clear();  
            Marcas.Items.AddRange(marcaCarro);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marcaBuscar = txtBuscaM.Text;

            if (string.IsNullOrEmpty(marcaBuscar))
            {
                MessageBox.Show("Debes ingresar una marca para buscar");

            }
            else
            {
                bool existe = Array.Exists(marcaCarro,x => x == marcaBuscar);
                if (existe)
                {
                    MessageBox.Show($"La marca {marcaBuscar} si existe");
                }
                else
                {
                    MessageBox.Show($"La marca {marcaBuscar} NO existe");
                }

            }
        }

        private void Compuestos_Load(object sender, EventArgs e)
        {

        }
    }
}
