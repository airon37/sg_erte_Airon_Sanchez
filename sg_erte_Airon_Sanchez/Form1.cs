using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sg_erte_Airon_Sanchez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarInformes f2 = new AdministrarInformes();
            f2.MdiParent = this;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void ertesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administrarErtes f2 = new administrarErtes();
            f2.MdiParent = this;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_Empresas f2 = new admin_Empresas();
            f2.MdiParent = this;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administrarEmpleados f2 = new administrarEmpleados();
            f2.MdiParent = this;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }
    }
}
