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
    public partial class FormListadoEspecialidades : Form
    {
        public FormListadoEspecialidades()
        {
            InitializeComponent();
        }

        private void btnNuevaEspecialidad_Click(object sender, EventArgs e)
        {
            FormNuevaEspecialidad formNuevo = new FormNuevaEspecialidad();
            formNuevo.FormClosing += formModificar_FormClosing;
            formNuevo.ShowDialog();
        }

        private void FormListadoEspecialidades_Load(object sender, EventArgs e)
        {
            ListarEspecialidades();
        }

        public async void ListarEspecialidades()
        {

            dgvEspecialidades.DataSource = null;

            dgvEspecialidades.AutoGenerateColumns = false;

            dgvEspecialidades.DataSource = await EspecialidadApiClient.GetAllAsync();


        }

        private async void dgvEspecialidades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string columnName = dgvEspecialidades.Columns[e.ColumnIndex].Name;
                int id = Convert.ToInt32(dgvEspecialidades.Rows[e.RowIndex].Cells["Id"].Value);

                var cellValue = dgvEspecialidades.Rows[e.RowIndex].Cells["Id"].Value;
                    if (id != 0) { 
                    if (columnName == "colBtnEliminarEsp")
                    {
                        // Acción para eliminar
                        DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                           await EspecialidadApiClient.DeleteAsync(id);
                            ListarEspecialidades();
                        }
                    }
                    else if (columnName == "colBtnModificarEsp")
                    {
                        FormModificarEspecialidad formModificar = new FormModificarEspecialidad { Especialidad = await EspecialidadApiClient.GetAsync(id)};
                        formModificar.FormClosing += formModificar_FormClosing; 
                        formModificar.ShowDialog();
                    }
            }
        }
        }

        private void formModificar_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ListarEspecialidades();
        }
    }
}
