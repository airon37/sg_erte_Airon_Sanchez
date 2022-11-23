﻿using System;
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

    public partial class FormModifucarEmpresa : Form
    {
        private void rellenarEstilos()
        {
            using (bd_ertesEntities2 objBD = new bd_ertesEntities2())
            {
                var qEstilos = from e in objBD.SECTORES
                               orderby e.Descripcion ascending
                               select new { e.Descripcion };
                var listaEst = qEstilos.ToList();
                foreach (var est in listaEst)
                {
                    cbSector.Items.Add(est.Descripcion);
                }
            }
        }
        public FormModifucarEmpresa(String cif,String nombre,String domicilio, String sector)
        {
            InitializeComponent();
            rellenarEstilos();
            txtCif.Text = cif;
            txtNombre.Text = nombre;
            txtDomicilio.Text = domicilio;
            cbSector.Text = sector;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities2 objBD = new bd_ertesEntities2())
            {
                var modificar = objBD.EMPRESAS;
                foreach (var est in modificar)
                {
                    var consulta = from sec in objBD.SECTORES
                                   where sec.Descripcion == cbSector.Text
                                   select new
                                   {
                                       sec.Id_sector
                                   };
                    if (est.Cif == txtCif.Text)
                    {
                        est.Cif = txtCif.Text;
                        est.Nombre = txtNombre.Text;
                        est.Domicilio = txtDomicilio.Text;
                        est.Sector = consulta.First().Id_sector;
                    }
                }
                objBD.SaveChanges();
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
