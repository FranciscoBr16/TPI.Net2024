using Entidades;
using Presentacion.ApiClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAgregarProfesor : Form
    {
        public List<Persona> Profesores { get; set; }

        public FormAgregarProfesor()
        {
            InitializeComponent();
        }

        private async void FormAgregarProfesor_Load(object sender, EventArgs e)
        {
            dgvProfesores.DataSource = null;
            dgvProfesores.AutoGenerateColumns = false;

            dgvProfesores.DataSource = await PersonaApiClient.GetProfesoresAsync();

            if (dgvProfesores.Rows.Count > 0)
            {
                dgvProfesores.Rows[0].Selected = true;
            }
        }

        private Persona SelectedItem()
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                return (Persona)dgvProfesores.SelectedRows[0].DataBoundItem;
            }
            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var profesorSeleccionado = SelectedItem();

            if (profesorSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un profesor para agregar.");
                return;
            }

            if (Profesores.Any(p => p.Legajo == profesorSeleccionado.Legajo))
            {
                MessageBox.Show("Ya agregaste a este Profesor");
            }
            else
            {
                Profesores.Add(profesorSeleccionado);
                MessageBox.Show("Profesor Agregado");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var profesorSeleccionado = SelectedItem();

            if (profesorSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un profesor para quitar.");
                return;
            }

            if (Profesores.Any(p => p.Legajo == profesorSeleccionado.Legajo))
            {
                Profesores.Remove(profesorSeleccionado);
                MessageBox.Show("Se quitó el profesor del curso");
            }
            else
            {
                MessageBox.Show("Este profesor no se encontraba en el curso");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
