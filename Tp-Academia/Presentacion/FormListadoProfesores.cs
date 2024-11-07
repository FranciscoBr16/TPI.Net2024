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
    public partial class FormListadoProfesores : Form
    {
        public FormListadoProfesores()
        {
            InitializeComponent();
        }

        private async void dgvProfesores_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvProfesores.Columns[e.ColumnIndex].Name;

                int legajo = Convert.ToInt32(dgvProfesores.Rows[e.RowIndex].Cells["colLegajo"].Value);


                if (columnName == "colBtnEliminar")
                {
                    // Acción para eliminar
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        await PersonaApiClient.DeleteAsync(legajo);
                        ListarProfesores();
                    }
                }
                else if (columnName == "colBtnModificar")
                {
                    FormModificarPersona formModificar = new FormModificarPersona { PersonaForm = await PersonaApiClient.GetAsync(legajo)};
                    formModificar.FormClosing += formModificar_FormClosing;
                    formModificar.ShowDialog();
                }
            }
        }

        private void formModificar_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ListarProfesores();
        }

        private void FormListadoProfesores_Load(object sender, EventArgs e)
        {
           ListarProfesores();
        }

        public async void ListarProfesores()
        {


            dgvProfesores.DataSource = null;

            dgvProfesores.AutoGenerateColumns = false;

            dgvProfesores.DataSource = await PersonaApiClient.GetProfesoresAsync();

        }

    }

}
