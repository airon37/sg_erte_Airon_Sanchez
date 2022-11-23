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
    public partial class administrarEmpleados : Form
    {
        public administrarEmpleados()
        {
            InitializeComponent();
        }

        private void eMPLEADOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLEADOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ertesDataSet);

        }

        private void administrarEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_ertesDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOSTableAdapter.Fill(this.bd_ertesDataSet.EMPLEADOS);

        }
    }
}
