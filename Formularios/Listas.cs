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
using System.Xml.Linq;

namespace ClasesINA.Formularios
{
    public partial class Listas : MaterialForm  
    {
        //instancia de tipo list de tipo entero
        List<int> numeros = new List<int>();  // lista vacia

        List<int> numerosPredeterminados = new List<int> {10,20,30,40,50}; // Lista con valores predefinidos

        public Listas()
        {
            InitializeComponent();
        }

        private void Listas_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            foreach (int i in numerosPredeterminados)
            {
                Console.WriteLine(i);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            int numero = 0;
            bool esNumero = int.TryParse(txtNumero.Text, out numero);   

            if (esNumero)
            {
                // con esta instruccion agregamos un valor nuevo a la lista
                numerosPredeterminados.Add(numero);

                //llamamos 
                materialButton1_Click(sender, e);

            }

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            int numero = 0;
            bool esNumero = int.TryParse(txtNumero.Text, out numero);
            
           

            if (esNumero)
            {
                bool existe = numerosPredeterminados.Exists(filtro => filtro == numero);


                if (existe)
                {
                    // con esta instruccion agregamos un valor nuevo a la lista
                    numerosPredeterminados.Remove(numero);

                    MessageBox.Show("El numero fue eliminado");

                    materialButton1_Click(sender, e);
                    
                }
                else
                {
                    MessageBox.Show("El numero no existe");
                }
                

            }
        }
        // inicia la definicion de funciones del formulario

        /// <summary>
        /// Determina si existe o no el valor dentro de la colección
        /// </summary>
        /// <param name="elemento">Es el valor que se buscará en la colección</param>
        /// <returns>boolean</returns>
        private bool ElementoExiste(int elemento)
        {
            bool existe = numerosPredeterminados.Exists(filtro => filtro == elemento);

            return existe;
        }

        /// <summary>
        /// Registro un valor nuevo a la lista numerosPredeterminados
        /// </summary>
        /// <param name="valorNuevo">Es el nuevo valor a agregar</param>
        /// <returns></returns>
        private void AgregarElemento(int valorNuevo)
        {
            numerosPredeterminados.Add(valorNuevo);
            
        }



        private void materialButton4_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtNumero.Text);

            if (ElementoExiste(valor)) 
            {
                MessageBox.Show("Este numero ya existe");
            
            }
            else
            {
                MessageBox.Show("Este numero NO existe");
            }
        }
    } // finaliza la clase
}
