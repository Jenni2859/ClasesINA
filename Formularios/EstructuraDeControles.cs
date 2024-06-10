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
    public partial class EstructuraDeControles : MaterialForm
    {
        String[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
        public EstructuraDeControles()
        {
            InitializeComponent();
        }

        private void buttonIF_Click(object sender, EventArgs e)
        {
            int x = 100;
            if (x > 50)
            {
                MessageBox.Show($" {x} sí es mayor que 50");
            }
            else
            {
                MessageBox.Show($" {x} NO es mayor que 50");
            }
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            int opcionUsuario = 1;
            switch (opcionUsuario)
            {
                case 1:
                    Console.WriteLine("Es uno");
                    break;
                case 2:
                    Console.WriteLine("Es dos");
                    break;
                default:
                    Console.WriteLine("No es ni uno o dos");
                    break;

            }
        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"Vamos por: {i}");
            
            }
            */
            int[] numero = { 1, 2, 3, 4, 6, 77, 456, 345, 123 };
            foreach (int i in numero)
            {
                Console.WriteLine($"{i}");
            }

            string[] palabra = { "Hola", "como", "estas" };
            /*foreach (string x in palabra)
            {
                Console.WriteLine(x);
            }
            */

            // otra manera de hacer el de arriba
            for (int i = 0; i < palabra.Length - 1; i += 2)
            {
                Console.WriteLine(palabra[i]);
            }

            // otra manera de estructura FOR
            //for (int i = 0; i < palabra.Length -1; Console.WriteLine(palabra[i+=2])) ;

        }

        private void EstructuraDeControles_Load(object sender, EventArgs e)
        {
            dtDias.Rows.Clear(); //limpia las filas que tiene el objeto

            foreach (string dias in diasSemana)
            {
                dtDias.Rows.Add(dias); //agrega la fila al objeto
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string DiaAdd = txtAdd.Text;

            bool exist = Array.Exists(diasSemana, x => x.ToUpper() == DiaAdd.ToUpper());


            if (string.IsNullOrEmpty(DiaAdd)) // validad si esta vacio
            {
                MessageBox.Show("Debes ingresar un día para guardar");

            }
            else if (exist) // en caso que ya existe el dia
            {
                MessageBox.Show($"El día {DiaAdd} ya existe en la lista");
            }
            else
            {
                Array.Resize(ref diasSemana, diasSemana.Length + 1);
                diasSemana[diasSemana.Length - 1] = DiaAdd;
                dtDias.Rows.Add(DiaAdd);


            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {


            if (dtDias.SelectedCells[0] != null)
            {
                string diaXborrar = (string)dtDias.SelectedCells[0].Value;
                DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar el dia {dtDias.SelectedCells[0].Value}?",
                "Advertencia", MessageBoxButtons.YesNo);
                switch (opcionUsuario)
                {
                    case DialogResult.Yes:


                        if (Array.Exists(diasSemana, dia => dia == diaXborrar))
                        {
                            int index = Array.IndexOf(diasSemana, diaXborrar); Console.WriteLine(index);
                            if (index != -1)
                            {
                                for (int i = index; i < diasSemana.Length - 1; i++)
                                {

                                    diasSemana[i] = diasSemana[i + 1];

                                }
                                Array.Resize(ref diasSemana, diasSemana.Length - 1);
                            }
                        }

                        dtDias.Rows.Clear();
                        foreach (var item in diasSemana)
                        {

                            dtDias.Rows.Add(item);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string BuscarD = buscaDia.Text;


            if (string.IsNullOrEmpty(BuscarD))
            {
                MessageBox.Show("Debes ingresar un día para buscar");

            }
            else
            {
                bool existe = Array.Exists(diasSemana, x => x == BuscarD);
                if (existe)
                {
                    dtDias.Rows.Clear();
                    dtDias.Rows.Add(BuscarD);

                }
                else
                {
                    MessageBox.Show($"El día {BuscarD} NO existe");
                }
            }
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            dtDias.Rows.Clear();
            dtDias.Rows.Add(diasSemana);
        }

        
    }
}