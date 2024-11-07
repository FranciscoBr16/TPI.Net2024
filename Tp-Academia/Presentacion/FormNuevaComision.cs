using Entidades;
using ApiClients;
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
    public partial class FormNuevaComision : Form
    {
        public FormNuevaComision()
        {
            InitializeComponent();
        }

        private async void btnAceptar_MouseClick(object sender, MouseEventArgs e)
        {
            if (ValidarCampos())
            {

                Comision comNueva = new Comision(txbDescripcion.Text, txbTurno.Text);

                await ComisionApiClient.AddAsync(comNueva); 
                MessageBox.Show("Nueva Comision Registrada");
                this.Close();

            }
            else { return; }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txbTurno.Text))
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
