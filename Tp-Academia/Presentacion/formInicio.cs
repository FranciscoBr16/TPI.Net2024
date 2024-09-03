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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }



        public void Listar()
        {

            DataPersona dataAlumnos = new DataPersona();

            List<Persona> listaAlumnos = dataAlumnos.getAlumnos();

            dgvAlumnos.AutoGenerateColumns = false;

            dgvAlumnos.DataSource = listaAlumnos;


        }


        private void dgvAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvAlumnos_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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
                        dp.eliminarPersona(dp.getPersonaByLegajo(legajo));
                    }
                }
                else if (columnName == "colBtnModificar")
                {
                    FormModificarPersona formModificar = new FormModificarPersona(dp.getPersonaByLegajo(legajo));
                    formModificar.ShowDialog();
                }
            }
        }
    }
}
