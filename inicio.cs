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
using MaterialSkin;
using MaterialSkin.Controls;

namespace ClasesINA
{
    public partial class Formulario_Principal : MaterialForm
    {
        public Formulario_Principal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //aca vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan300, Primary.Cyan400,
                Primary.Cyan300, Accent.Cyan100,
                TextShade.WHITE);

            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue500, Primary.Blue700,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE);


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

        private void AbreCompuestos_Click_1(object sender, EventArgs e)
        {
            Compuestos VC = new Compuestos();
            VC.Show();
        }

        private void Abre_EstrControl_Click(object sender, EventArgs e)
        {
            EstructuraDeControles EC = new EstructuraDeControles();
            EC.Show();
            
        }

        private void Formulario_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
