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
    public partial class FormNuevaEspecialidad : Form
    {
        public FormNuevaEspecialidad()
        {
            InitializeComponent();
        }

        private void btnAceptar_MouseClick(object sender, MouseEventArgs e)
        {

            if (ValidarCampos())
            {

                Especialidad EspNueva = new Especialidad(txbDescripcion.Text);
                Negocio.Especialidad.AgregarEspecialidad(EspNueva); 
                MessageBox.Show("Nueva Especialidad Registrada");

            }
            else { return; }

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbDescripcion.Text) )
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
