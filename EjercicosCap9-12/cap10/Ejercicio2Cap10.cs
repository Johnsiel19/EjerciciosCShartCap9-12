using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicosCap9_12.cap10
{
    public partial class Ejercicio2Cap10 : Form
    {
        public Ejercicio2Cap10()
        {
            InitializeComponent();
        }

        public class Estudiante
        {
            public string Nombre { get; set; }
            public string Padre { get; set; }
            public string Madre { get; set; }
        }



        ArrayList array = new ArrayList();

        public Estudiante[] productos = new Estudiante[30];


        public void Limpiar()
        {
            NombreTextBox.Text = string.Empty;
            PadreTextBox.Text = string.Empty;
            MadreTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = NombreTextBox.Text;
            estudiante.Padre = PadreTextBox.Text;
            estudiante.Madre = MadreTextBox.Text;
            array.Add(productos);
            MessageBox.Show("Guardado");
        }


        private void AgregarButton_Click_1(object sender, EventArgs e)
        {

            Agregar();
            Limpiar();

        }

        private void MostrarButton_Click_1(object sender, EventArgs e)
        {
        
            Limpiar();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}


