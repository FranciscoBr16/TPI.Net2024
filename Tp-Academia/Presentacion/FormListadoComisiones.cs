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
    public partial class FormListadoComisiones : Form
    {
        public FormListadoComisiones()
        {
            InitializeComponent();
        }

        private void FormListadoComisiones_Load(object sender, EventArgs e)
        {
            ListarComisiones();
        }

        public void ListarComisiones()
        {

            DataComision dataComisiones = new DataComision();

            List<Comision> listaComisiones = dataComisiones.GetComisiones();

            dgvComisiones.AutoGenerateColumns = false;

            dgvComisiones.DataSource = listaComisiones;


        }

        private void dgvComisiones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvComisiones.Columns[e.ColumnIndex].Name;

                int id = Convert.ToInt32(dgvComisiones.Rows[e.RowIndex].Cells["Id"].Value);

                DataComision dc = new DataComision();

                if (columnName == "colBtnEliminarCom")
                {
                    // Acción para eliminar
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dc.EliminarComision(dc.GetComisionById(id));
                    }
                }
                else if (columnName == "colBtnModificarCom")
                {
                    FormModificarComision formModificar = new FormModificarComision(dc.GetComisionById(id));
                    formModificar.ShowDialog();
                }
            }
        }

        private void btnNuevaComision_Click(object sender, EventArgs e)
        {
            FormNuevaComision formNuevo = new FormNuevaComision();
            formNuevo.ShowDialog();
        }
    }
}
