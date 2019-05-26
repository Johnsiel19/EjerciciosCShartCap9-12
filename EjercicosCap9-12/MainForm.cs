using System;
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
    }
}
