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

            if (this.dgvProfesores.Rows.Count > 0)
            {
                this.dgvProfesores.Rows[0].Selected = true;
            }
        }

        private Persona SelectedItem()
        {
            Persona per;
            if (this.dgvProfesores.SelectedRows.Count > 0)
            {
                per = (Persona)this.dgvProfesores.SelectedRows[0].DataBoundItem;

                return per;
            }
            else
            {
                return null;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            int legajo;
            if (this.SelectedItem == null)
            {
                return;
            }

            legajo = this.SelectedItem().Legajo;
            Persona per = await PersonaApiClient.GetAsync(legajo);
            if (!Profesores.Contains(per)) { Profesores.Add(per); MessageBox.Show("Profesor Agregado"); } else { MessageBox.Show("Ya agregaste a este Profesor"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
