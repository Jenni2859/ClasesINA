using MaterialSkin;
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
    public partial class Login : MaterialForm
    {
        public static String[] usuario = { "Jeni" };
        public static String[] contrasennia = { "123" };


        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //aca vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan300, Primary.Cyan400,
                Primary.Cyan300, Accent.Cyan700,
                TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            CreaCuentas NewCuenta = new CreaCuentas();
            NewCuenta.Show();
            
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (CreaCuentas.usuario1))
            {
                txtUsuario.Text = CreaCuentas.usuario1;
            }
        }
    }
}
