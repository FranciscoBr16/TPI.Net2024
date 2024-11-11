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

        public async void CargarDatos()
        {
            txbTelefono.Text = Usuario.Tel;
            txbDni.Text = Usuario.DNI;
            lblApellido.Text = Usuario.Apellido;
            txbFechaNac.Text = Convert.ToString(Usuario.Fecha_nac);
            lblNombre.Text = Usuario.Nombre;
            txbCorreo.Text = Usuario.Mail;
            txbUsuario.Text = Usuario.Usuario;
            txbDireccion.Text = Usuario.Direccion;
            if (Usuario != null && Usuario.PlanId.HasValue)
            {
                txbPlan.Text = (await PlanApiClient.GetAsync(Usuario.PlanId.Value)).Descripcion;
            }
            else
            {
                txbPlan.Text = "N/A";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarPersona modificar = new FormModificarPersona { PersonaForm = this.Usuario };
            modificar.FormClosing += FormInicio_FormClosing;
            modificar.Show();
        }

        private async void FormInicio_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (Usuario != null)
            {
                int legajo = Usuario.Legajo;
                var usuarioActualizado = await PersonaApiClient.GetAsync(legajo);
                if (usuarioActualizado != null)
                {
                    Usuario = usuarioActualizado;
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la información del usuario.");
                }
            }
        }



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Usuario = null;
            var mdiParent = this.MdiParent as MiFormBase;
            if (mdiParent != null)
            {
                mdiParent.Usuario = null;
                mdiParent.Usuario = null;

                foreach (Form childForm in mdiParent.MdiChildren)
                {
                    childForm.Close();
                }
            }
            this.Close();
        }


    }
}
