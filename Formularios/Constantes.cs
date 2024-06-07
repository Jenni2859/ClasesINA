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

namespace ClasesINA.NewFolder1
{
    public partial class Constantes : MaterialForm
    {
        // Declaramos los valores constantes
        const double PI = 3.14;

        public Constantes()
        {
            InitializeComponent();
        }

        private void lblValorConstante_Click(object sender, EventArgs e)
        {
            lblConstante.Text = "" + PI;

        }

        private void Constantes_Load(object sender, EventArgs e)
        {

        }
    }
}
