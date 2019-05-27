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

namespace EjercicosCap9_12.Cap9
{
    public partial class Ejercicio3cap9 : Form
    {
        public Ejercicio3cap9()
        {
            InitializeComponent();
        }


        ArrayList array = new ArrayList();

        public struct DueñoMascota
        {
            public string NombreD { get; set; }
            public string edadD { get; set; }
            public string sexoD { get; set; }
            public string NombreMascota { get; set; }
            public string DueñoMascot { get; set; }
            public string sexoMascota { get; set; }
        }

        public void Limpiar()
        {
            NombreDTextBox.Text = string.Empty;
            EdadTextBox.Text = string.Empty;
            SexoDTextBox.Text = string.Empty;
            NombreMTextBox.Text = string.Empty;
            DuenoTextBox.Text = string.Empty;
            SexoTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            DueñoMascota dueño = new DueñoMascota();
            dueño.NombreD = NombreDTextBox.Text;
            dueño.edadD = EdadTextBox.Text;
            dueño.sexoD = SexoDTextBox.Text;
            dueño.NombreMascota = NombreMTextBox.Text;
            dueño.DueñoMascot = DuenoTextBox.Text;
            dueño.sexoMascota = SexoTextBox.Text;

            array.Add(dueño);
            MessageBox.Show("Guardado...");
        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
         
            Limpiar();
        }


    }
}
