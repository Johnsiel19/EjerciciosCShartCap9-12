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

namespace EjercicosCap9_12
{
    public partial class Ejerciocio1Cap9 : Form
    {
        public Ejerciocio1Cap9()
        {
            InitializeComponent();
            array = new ArrayList();
        }

        
        ArrayList array;

        public void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;

        }

        public class Product
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public string Cantidad { get; set; }

        }

        public void Agregar()
        {
            Product n = new Product();
            n.Codigo = txtCodigo.Text;
            n.Nombre = txtNombre.Text;
            n.Precio = txtPrecio.Text;
            n.Cantidad = txtCantidad.Text;
            array.Add(n);
            MessageBox.Show("Guardado...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
          
                Agregar();
                Limpiar();
            


        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();

        }

   
    }



}
