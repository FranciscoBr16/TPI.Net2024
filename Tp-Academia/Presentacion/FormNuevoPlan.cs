using Data;
using Entidades;
using Presentacion.ApiClients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormNuevoPlan : Form
    {
        public FormNuevoPlan()
        {
            InitializeComponent();
        }

        private async void FormNuevoPlan_Load(object sender, EventArgs e)
        {

            cbEspecialidades.DataSource = await PlanApiClient.GetAllAsync() ;
               
            cbEspecialidades.DisplayMember = "Descripcion";

            cbEspecialidades.ValueMember = "Id";
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                Plan planNuevo = new Plan { Descripcion= txbDescripcion.Text , EspecialidadId = ((Especialidad)cbEspecialidades.SelectedItem).Id, Fecha= dtpFecha.Value }; 

                await PlanApiClient.AddAsync(planNuevo);

                MessageBox.Show("Nuevo Plan registrado");

                this.Close();
            }
            else { return; }

        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbDescripcion.Text) ||
                cbEspecialidades.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

