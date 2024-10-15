using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabineteAbogadosApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formClientes = new Form1();
            formClientes.Show();
        }

        private void asuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsuntos formAsuntos = new FormAsuntos();
            formAsuntos.Show();
        }

        private void procuradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcuradores formProcuradores = new FormProcuradores();
            formProcuradores.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
