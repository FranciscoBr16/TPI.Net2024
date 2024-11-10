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
    public partial class FormListadoMaterias : MiFormBase
    {
        private FormClosingEventHandler formModificar_FormClosing;

        public FormListadoMaterias()
        {
            InitializeComponent();
        }

        private void btnNuevaMateria_Click(object sender, EventArgs e)
        {
            FormNuevaMateria formNuevo = new FormNuevaMateria();
            ListarMaterias();
            formNuevo.ShowDialog();
        }

        private void FormListadoMaterias_Load(object sender, EventArgs e)
        {
            ListarMaterias();

            if (Usuario != null && Usuario.Rol == "Admin")
            {
                dgvMaterias.Columns["colBtnModificar"].Visible = true;
                dgvMaterias.Columns["colBtnEliminar"].Visible = true;
            }
            else
            {
                dgvMaterias.Columns["colBtnModificar"].Visible = false;
                dgvMaterias.Columns["colBtnEliminar"].Visible = false;
            }
        }

        public async void ListarMaterias()
        {

            dgvMaterias.DataSource = null;

            dgvMaterias.AutoGenerateColumns = false;

            dgvMaterias.DataSource = await MateriaApiClient.GetAllAsync();
        }

        private async void dgvMaterias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvMaterias.Columns[e.ColumnIndex].Name;
                int id = Convert.ToInt32(dgvMaterias.Rows[e.RowIndex].Cells["Id"].Value);

                var cellValue = dgvMaterias.Rows[e.RowIndex].Cells["Id"].Value;
                if (id != 0)
                {
                    if (columnName == "colBtnEliminar")
                    {
                        // Acción para eliminar
                        DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            await MateriaApiClient.DeleteAsync(id);
                            ListarMaterias();
                        }
                    }
                    else if (columnName == "colBtnModificar")
                    {
                        // Acción para modificar
                        FormModificarMateria formModificar = new FormModificarMateria { Materia = await MateriaApiClient.GetAsync(id) };
                        formModificar.FormClosing += formModificar_FormClosing;
                        formModificar.ShowDialog();
                    }
                }   
            }
        }



    }
}
