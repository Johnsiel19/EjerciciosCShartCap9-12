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
    public partial class Ejercicio1cap10 : Form
    {
        public Ejercicio1cap10()
        {
            InitializeComponent();
        }

        public class InventarioTienda
        {
            public string ProductoId { get; set; }
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public string Cantidad { get; set; }
            public DateTime FechaVencimiento { get; set; }
        }


        ArrayList arrayList = new ArrayList();

        public InventarioTienda[] producto = new InventarioTienda[30];


        public void Limpiar()
        {
            IdNumericUpDown.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            InventarioTienda inventario = new InventarioTienda();
            inventario.Precio = PrecioTextBox.Text;
            inventario.Nombre = DescripcionTextBox.Text;
            inventario.Precio = PrecioTextBox.Text;
            inventario.Cantidad = CantidadTextBox.Text;
            inventario.ProductoId = IdNumericUpDown.Text;

            arrayList.Add(producto);
            MessageBox.Show(" Guardado...");
        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();

        }


        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();

        }
    }



}
