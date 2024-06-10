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
    public partial class Principal2 : Form
    {
        public Principal2()
        {
            InitializeComponent();
        }

        private void Principal2_Load(object sender, EventArgs e)
        {

        }

        private void facturarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear(); //quitamos forms si ya los hay

            // creamos una instancia del formulario a abrir
            Principal facturacion = new Principal();

            // indicamos que no es el principal (sino que es secundario)
            facturacion.TopLevel = false;
            facturacion.AutoScroll = true; // permite hacer scroll
            //facturacion.FormBorderStyle = FormBorderStyle.None;
            facturacion.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(facturacion);

            facturacion.Show();
        }

        private void crearCuentaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear(); //quitamos forms si ya los hay

            // creamos una instancia del formulario a abrir
            CreaCuentas NewCuenta = new CreaCuentas();

            // indicamos que no es el principal (sino que es secundario)
            NewCuenta.TopLevel = false;
            NewCuenta.AutoScroll = true; // permite hacer scroll
            NewCuenta.FormBorderStyle = FormBorderStyle.None;
            //NewCuenta.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(NewCuenta);

            NewCuenta.Show();

        }
    }
}
