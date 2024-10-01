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
    public partial class FormModificarEspecialidad : Form
    {
        private Especialidad Especialidad { get; set; }
        public FormModificarEspecialidad()
        {
            InitializeComponent();
        }

        public FormModificarEspecialidad(Especialidad especialidad)
        {
            InitializeComponent();
            Especialidad = especialidad;

        }

        public void FormModificarEspecialidad_Load(object sender, EventArgs e)
        {
            txbDescripcion.Text = Especialidad.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //VALIDAR LOS CAMPOS

            Especialidad esp = new Especialidad(txbDescripcion.Name);
            DataEspecialidad dEsp = new DataEspecialidad();
            if (dEsp.ModificarEspecialidad(esp))
            {
                MessageBox.Show("Cambios guardados exitosamente.");
            }
            else { MessageBox.Show("Ups! Ocurrio un error"); }
        }
    }
}
