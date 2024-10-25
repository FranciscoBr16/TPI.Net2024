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
    public partial class FormListadoPlanes : Form
    {
        public FormListadoPlanes()
        {
            InitializeComponent();
        }

        public void ListarPlanes()
        {

            DataPlan dataPlanes = new DataPlan();

            List<Plan> listaPlanes = dataPlanes.GetPlanes();

            dgvPlanes.AutoGenerateColumns = false;

            dgvPlanes.DataSource = listaPlanes;


        }

        private void FormListadoPlanes_Load(object sender, EventArgs e)
        {
            ListarPlanes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoPlan formNuevo = new FormNuevoPlan();
            formNuevo.FormClosing += FormNuevoPlan_FormClosing;
            formNuevo.ShowDialog();
        }

        private void FormNuevoPlan_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ListarPlanes();

        }
        private void FormModificarPlan_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ListarPlanes();

        }
        private void dgvPlanes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvPlanes.Columns[e.ColumnIndex].Name;

                int id = Convert.ToInt32(dgvPlanes.Rows[e.RowIndex].Cells["colId"].Value);

              

                if (columnName == "colBtnEliminarPlan")
                {
                    // Acción para eliminar
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Negocio.Plan.EliminarPlan(Negocio.Plan.GetPlanById(id));
                        ListarPlanes();
                    }
                }
                else if (columnName == "colBtnModificarPlan")
                {
                    FormModificarPlan formModificar = new FormModificarPlan(Negocio.Plan.GetPlanById(id));
                    formModificar.FormClosing += FormModificarPlan_FormClosing;
                    formModificar.ShowDialog();
                }
            }
        }

    }
}
