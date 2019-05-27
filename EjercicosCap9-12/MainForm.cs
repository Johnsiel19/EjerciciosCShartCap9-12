using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicosCap9_12.Cap9;
using EjercicosCap9_12.cap10;

namespace EjercicosCap9_12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Ejer1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejerciocio1Cap9 frm = new Ejerciocio1Cap9();
            frm.Show();

        }

        private void Ejer2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3cap9 frm = new Ejercicio3cap9();
            frm.Show();
        }

        private void EjerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1cap10 frm = new Ejercicio1cap10();
            frm.Show();
        }

        private void Ejer2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio2Cap10 frm = new Ejercicio2Cap10();
            frm.Show();
        }
    }
}
