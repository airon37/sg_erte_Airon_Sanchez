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
    public partial class admin_Empresas : Form
    {
        public admin_Empresas()
        {
            InitializeComponent();
            dgvEmpresas.DataSource = null;
            dgvEmpresas.Refresh();
            using (bd_ertesEntities2 objBD = new bd_ertesEntities2())
            {
                var consulta = from emp in objBD.EMPRESAS
                               from sec in objBD.SECTORES
                               where emp.Sector == sec.Id_sector
                               select new
                               {
                                   emp.Nombre,
                                   sec.Descripcion,
                                   emp.Cif,
                                   emp.Domicilio
                               };
                dgvEmpresas.DataSource = consulta.ToList();
                dgvEmpresas.Columns["Domicilio"].Visible = false;
                dgvEmpresas.Refresh();
            }
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmpresas.Rows)
            {
                
                if (row.Selected)
                {
                    DataGridViewRow a = dgvEmpresas.Rows[row.Index];
                    FormModifucarEmpresa f1 = new FormModifucarEmpresa(a.Cells[2].Value.ToString(), a.Cells[0].Value.ToString(), a.Cells[3].Value.ToString(), a.Cells[1].Value.ToString());
                    f1.Show();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
