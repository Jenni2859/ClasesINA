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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string usuarioAutentica = txtUsuario.Text;
            string contrasenniaAutentica = txtContrasennia.Text;

            bool existeUser = Array.Exists(usuario, filtro => filtro == usuarioAutentica);
            bool existeContra = Array.Exists(contrasennia, filtro => filtro == contrasenniaAutentica);

            if (existeUser && existeContra)
            {
                Principal2 principal = new Principal2();
                principal.Show();
                Visible = false;

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña no coinciden",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}
