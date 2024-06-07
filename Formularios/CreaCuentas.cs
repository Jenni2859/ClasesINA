using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA.Formularios
{
    public partial class CreaCuentas : MaterialForm
    {
        public static string usuario1 = "";

        public CreaCuentas()
        {
            InitializeComponent();
           
        }

        private void CreaCuentas_Load(object sender, EventArgs e)
        {

        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            if (txtNewUsuario.Text.Equals(""))
            {
                MessageBox.Show("No ingreso el nombre de usuario");
            }
            else
            {
                if (txtNewContrasennia.Text.Equals("") || txtConfirmContrasennia.Text.Equals(""))
                {
                    MessageBox.Show("No ingresaste las contraseñas");
                }
                else
                {
                    if (!txtNewContrasennia.Text.Equals(txtConfirmContrasennia.Text))
                    {
                        MessageBox.Show("Las contraseñas NO coinciden");
                    }
                    else
                    {

                        string UsuarioRegistrar = txtNewUsuario.Text;
                        string password = txtNewContrasennia.Text;

                        bool existe = Array.Exists(Login.usuario,filtro => filtro == UsuarioRegistrar);

                        if (existe)
                        {
                            MessageBox.Show($"El usuario {UsuarioRegistrar} ya existe dentro de la base de datos" );
                        }
                        else
                        {
                            Array.Resize(ref Login.usuario,Login.usuario.Length +1);
                            Array.Resize(ref Login.contrasennia, Login.contrasennia.Length + 1);

                            Login.usuario[Login.usuario.Length - 1] = UsuarioRegistrar;
                            Login.contrasennia[Login.contrasennia.Length -1] = password;

                            MessageBox.Show($"Usuario: {UsuarioRegistrar} creado exitosamente");
                            DialogResult respuesta = MessageBox.Show("Desea autenticarte con este usuario?","Pregunta",MessageBoxButtons.OKCancel);
                            switch (respuesta)
                            {
                                case DialogResult.OK:
                                    usuario1 = UsuarioRegistrar;
                                    this.Dispose();
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }

                        }
                    }
                }

            }
        }
    }
}
