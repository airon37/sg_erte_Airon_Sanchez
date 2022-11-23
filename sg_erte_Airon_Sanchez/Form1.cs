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
            DialogResult rs2 = MessageBox.Show("¿Desea cerrar la aplicacion?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs2 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarInformes f2 = new AdministrarInformes();
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs2 = MessageBox.Show("¿Desea cerrar la ventana actual?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs2 == DialogResult.Yes)
                {
                    f2.MdiParent = this;
                    f2.Dock = DockStyle.Fill;
                    f2.Show();
                }
            }
            else
            {
                f2.MdiParent = this;
                f2.Dock = DockStyle.Fill;
                f2.Show();
            }
        }

        private void ertesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administrarErtes f2 = new administrarErtes();
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs2 = MessageBox.Show("¿Desea cerrar la ventana actual?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs2 == DialogResult.Yes)
                {
                    f2.MdiParent = this;
                    f2.Dock = DockStyle.Fill;
                    f2.Show();
                }
            }
            else
            {
                f2.MdiParent = this;
                f2.Dock = DockStyle.Fill;
                f2.Show();
            }
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_Empresas f2 = new admin_Empresas();
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs2 = MessageBox.Show("¿Desea cerrar la ventana actual?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs2 == DialogResult.Yes)
                {
                    f2.MdiParent = this;
                    f2.Dock = DockStyle.Fill;
                    f2.Show();
                }
            }
            else
            {
                f2.MdiParent = this;
                f2.Dock = DockStyle.Fill;
                f2.Show();
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administrarEmpleados f2 = new administrarEmpleados();
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs2 = MessageBox.Show("¿Desea cerrar la ventana actual?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs2 == DialogResult.Yes)
                {
                    f2.MdiParent = this;
                    f2.Dock = DockStyle.Fill;
                    f2.Show();
                }
            }
            else
            {
                f2.MdiParent = this;
                f2.Dock = DockStyle.Fill;
                f2.Show();
            }
        }
    }
}
