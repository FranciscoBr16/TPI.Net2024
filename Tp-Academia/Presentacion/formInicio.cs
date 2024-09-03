using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }



        public void ListarAlumnos()
        {

            DataPersona dataAlumnos = new DataPersona();

            List<Persona> listaAlumnos = dataAlumnos.GetAlumnos();

            dgvAlumnos.AutoGenerateColumns = false;

            dgvAlumnos.DataSource = listaAlumnos;


        }

        public void ListarComisiones()
        {

            DataComision dataComisiones = new DataComision();

            List<Comision> listaComisiones = dataComisiones.GetComisiones();

            dgvComisiones.AutoGenerateColumns = false;

            dgvComisiones.DataSource = listaComisiones;


        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            ListarAlumnos();
        }

        private void tabComisiones_Enter(object sender, EventArgs e)
        {
            ListarComisiones();
        }

        private void dgvAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvAlumnos.Columns[e.ColumnIndex].Name;

                int legajo = Convert.ToInt32(dgvAlumnos.Rows[e.RowIndex].Cells["colLegajo"].Value);

                DataPersona dp = new DataPersona();

                if (columnName == "colBtnEliminar")
                {
                    // Acción para eliminar
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dp.EliminarPersona(dp.GetPersonaByLegajo(legajo));
                    }
                }
                else if (columnName == "colBtnModificar")
                {
                    FormModificarPersona formModificar = new FormModificarPersona(dp.GetPersonaByLegajo(legajo));
                    formModificar.ShowDialog();
                }
            }
        }

        private void dgvComisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevaPersona formNuevo = new FormNuevaPersona();
            formNuevo.ShowDialog();
        }
    }
}
