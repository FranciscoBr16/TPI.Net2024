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
    public partial class formNuevaPersona : Form
    {
        public formNuevaPersona()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                DateTime fechaHoy = DateTime.Now.Date;

                if (radiobAlumno.Checked)
                {
                    string rol = "Alumno";
                    

                    Persona alumnoNuevo = new Persona(txbNombre.Text, txbApellido.Text, txbCorreo.Text, txbTelefono.Text, txbClave.Text, rol, txbUsuario.Text, txbDireccion.Text, txbDni.Text, dtpFechaNac.Value , fechaHoy);

                    DataPersona dp = new DataPersona();

                    dp.insertPersona(alumnoNuevo);

                    MessageBox.Show("Registrado como Alumno");
                }
                else if (radiobProfesor.Checked)
                {
                    string rol = "Profesor";


                    Persona profesorNuevo = new Persona(txbNombre.Text, txbApellido.Text, txbCorreo.Text, txbTelefono.Text, txbClave.Text, rol, txbUsuario.Text, txbDireccion.Text, txbDni.Text, dtpFechaNac.Value, fechaHoy);

                    DataPersona dp = new DataPersona();

                    dp.insertPersona(profesorNuevo);

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

      
    }


}
