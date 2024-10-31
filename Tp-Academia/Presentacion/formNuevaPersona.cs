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
    public partial class FormNuevaPersona : Form
    {
        public FormNuevaPersona()
        {
            InitializeComponent();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                DateTime fechaHoy = DateTime.Now.Date;

                if (radiobAlumno.Checked)
                {
                    string rol = "Alumno";

                    Persona alumnoNuevo = new Persona
                    {
                        Nombre = txbNombre.Text,
                        Apellido = txbApellido.Text,
                        Mail = txbCorreo.Text,
                        Tel = txbTelefono.Text,
                        Clave = txbClave.Text,
                        Rol = rol,
                        Usuario = txbUsuario.Text,
                        Direccion = txbDireccion.Text,
                        DNI = txbDni.Text,
                        Fecha_nac = dtpFechaNac.Value,
                        Fecha_ingreso = fechaHoy,
                        PlanId = 1 // Ver este tema
                    };

                    await PersonaApiClient.AddAsync(alumnoNuevo);
                            
                    MessageBox.Show("Registrado como Alumno");
                }
                else if (radiobProfesor.Checked)
                {
                    string rol = "Profesor";

                    Persona profesorNuevo = new Persona
                    {
                        Nombre = txbNombre.Text,
                        Apellido = txbApellido.Text,
                        Mail = txbCorreo.Text,
                        Tel = txbTelefono.Text,
                        Clave = txbClave.Text,
                        Rol = rol,
                        Usuario = txbUsuario.Text,
                        Direccion = txbDireccion.Text,
                        DNI = txbDni.Text,
                        Fecha_nac = dtpFechaNac.Value,
                        Fecha_ingreso = fechaHoy
                    };
                    await PersonaApiClient.AddAsync(profesorNuevo);

                    MessageBox.Show("Registrado como Profesor");
                }
            }
            else { return; }


        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbNombre.Text) ||
                string.IsNullOrWhiteSpace(txbApellido.Text) ||
                string.IsNullOrWhiteSpace(txbTelefono.Text) ||
                string.IsNullOrWhiteSpace(txbCorreo.Text) ||
                string.IsNullOrWhiteSpace(txbClave.Text) ||
                string.IsNullOrWhiteSpace(txbUsuario.Text))
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return false;
            }



            if (!radiobAlumno.Checked && !radiobProfesor.Checked)
            {
                MessageBox.Show("Por favor, seleccione si es Alumno o Profesor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
