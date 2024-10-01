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
    public partial class FormNuevoPlan : Form
    {
        public FormNuevoPlan()
        {
            InitializeComponent();
        }

        private void FormNuevoPlan_Load(object sender, EventArgs e)
        {
            DataEspecialidad de = new DataEspecialidad();
            List<Especialidad> especialidades = de.GetEspecialidades();
            foreach (var unaEspecialidad in especialidades)
            {
<<<<<<< HEAD
                
                cbEspecialidades.Items.Add(unaEspecialidad);
                cbEspecialidades.DisplayMember = "Descripcion";
                cbEspecialidades.ValueMember = "Id";


=======
                cbEspecialidades.Items.Add(unaEspecialidad);
>>>>>>> f137153eb6b554db6db99fe70be28c13dcd4785b
            }
            cbEspecialidades.DisplayMember = "Descripcion";
            cbEspecialidades.ValueMember = "Id";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                DataEspecialidad de = new DataEspecialidad();
<<<<<<< HEAD

                Plan planNuevo = new Plan { Descripcion= txbDescripcion.Text , EspecialidadId = ((Especialidad)cbEspecialidades.SelectedItem).Id }; // VER

=======
                Plan planNuevo = new Plan { Descripcion = txbDescripcion.Text, EspecialidadId = ((Especialidad)cbEspecialidades.SelectedItem).Id };
>>>>>>> f137153eb6b554db6db99fe70be28c13dcd4785b
                DataPlan dp = new DataPlan();

                dp.InsertPlan(planNuevo);

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

