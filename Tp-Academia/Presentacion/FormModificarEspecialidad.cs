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
    public partial class FormModificarEspecialidad : Form
    {
        public Especialidad? Especialidad { get; set; }
        public FormModificarEspecialidad()
        {
            InitializeComponent();
        }


        public void FormModificarEspecialidad_Load(object sender, EventArgs e)
        {
            txbDescripcion.Text = Especialidad.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) { 

            Especialidad esp = new Especialidad(txbDescripcion.Name);

                 await EspecialidadApiClient.UpdateAsync(esp);

                MessageBox.Show("Cambios guardados exitosamente.");

            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbDescripcion.Text))
            {
                MessageBox.Show("Ingresa una descripcion valida");
                return false;
            }

            return true;
        }
    }
}
