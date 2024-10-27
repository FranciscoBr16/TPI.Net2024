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
    public partial class FormPerfil : MiFormBase
    {
        public FormPerfil()
        {
            InitializeComponent();
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        public void CargarDatos()
        {
            txbTelefono.Text = Usuario.Tel;
            txbDni.Text = Usuario.DNI;
            lblApellido.Text = Usuario.Apellido;
            txbFechaNac.Text = Convert.ToString(Usuario.Fecha_nac);
            lblNombre.Text = Usuario.Nombre;
            txbCorreo.Text = Usuario.Mail;
            txbUsuario.Text = Usuario.Usuario;
            txbDireccion.Text = Usuario.Direccion;
            txbPlan.Text = Convert.ToString(Usuario.PlanId);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarPersona modificar = new FormModificarPersona(this.Usuario);
            modificar.FormClosing += FormInicio_FormClosing;
            modificar.Show();
        }

        private void FormInicio_FormClosing(object? sender, FormClosingEventArgs e)
        {
            CargarDatos();
        }
    }
}
