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
    public partial class Compuestos : Form
    {
        string[] sexo = { "Hombre", "Mujer", "Otro" };

        string[] marcaCarro = new string[100];
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
    }
}
