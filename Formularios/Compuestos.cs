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
        }
    }
}
