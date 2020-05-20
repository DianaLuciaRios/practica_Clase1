using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_Clase1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void NóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomina formulario = new frmNomina();
            formulario.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            frmNomina formulario = new frmNomina();
            formulario.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmEmpleado formulario = new frmEmpleado();
            formulario.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
