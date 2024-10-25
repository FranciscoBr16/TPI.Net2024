using Data;
using Entidades;
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
    public partial class FormModificarPlan : Form
    {
        public Plan PlanPropio{ get; set; }

        /*public FormModificarPlan()
        {
            InitializeComponent();
        }*/

        public FormModificarPlan(Plan plan)
        {
            PlanPropio = plan;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validar que los campos no sean nulos
            Plan plan = new Plan { Id=PlanPropio.Id , Descripcion= txbDescripcion.Text, EspecialidadId = ((Especialidad)cbEspecialidades.SelectedItem).Id };
            if (Negocio.Plan.ModificarPlan(plan))
            {
                MessageBox.Show("Cambios guardados exitosamente.");
            }
            else { MessageBox.Show("Ups! Ocurrio un error"); }

        }

        private void FormModificarPlan_Load(object sender, EventArgs e)
        {
            
            txbDescripcion.Text = PlanPropio.Descripcion;
            cbEspecialidades.DataSource = Negocio.Especialidad.GetEspecialidades();
            cbEspecialidades.DisplayMember = "Descripcion";
            cbEspecialidades.ValueMember = "Id";

            cbEspecialidades.SelectedValue = PlanPropio.EspecialidadId;
        }

       
    }
}
