using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesINA.Formularios;
using ClasesINA.NewFolder1;

namespace ClasesINA
{
    public partial class Formulario_Principal : Form
    {
        public Formulario_Principal()
        {
            InitializeComponent();
        }

        private void AbreConstantes_Click(object sender, EventArgs e)
        {
            Constantes constantes= new Constantes();
            constantes.Show();
        }

        private void AbreCompuestos_Click(object sender, EventArgs e)
        {

            Compuestos VC = new Compuestos();
            VC.Show();
        }
    }
}
