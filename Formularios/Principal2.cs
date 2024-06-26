﻿using MaterialSkin.Controls;
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
    public partial class Principal2 : MaterialForm

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

        private void formularioDeListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear(); //quitamos forms si ya los hay

            // creamos una instancia del formulario a abrir
            Listas listas = new Listas();

            // indicamos que no es el principal (sino que es secundario)
            listas.TopLevel = false;
            listas.AutoScroll = true; // permite hacer scroll
            listas.FormBorderStyle = FormBorderStyle.None;
            //NewCuenta.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(listas);

            listas.Show();
        }

        private void facturarConListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear(); //quitamos forms si ya los hay

            // creamos una instancia del formulario a abrir
            Principal3 Facturar = new Principal3();

            // indicamos que no es el principal (sino que es secundario)
            Facturar.TopLevel = false;
            Facturar.AutoScroll = true; // permite hacer scroll
            Facturar.FormBorderStyle = FormBorderStyle.None;
            //NewCuenta.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(Facturar);

            Facturar.Show();
        }
    }
}
