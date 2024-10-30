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
    public partial class FormListadoAlumnos : Form
    {
        public FormListadoAlumnos()
        {
            InitializeComponent();
        }

        private void FormListadoAlumnos_Load(object sender, EventArgs e)
        {
            ListarAlumnos();
        }

        public void ListarAlumnos()
        {

            PersonaService dataAlumnos = new PersonaService();

            List<Persona> listaAlumnos = dataAlumnos.GetAlumnos();

            dgvAlumnos.AutoGenerateColumns = false;

            dgvAlumnos.DataSource = listaAlumnos;


        }

        private void dgvAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvAlumnos.Columns[e.ColumnIndex].Name;

                int legajo = Convert.ToInt32(dgvAlumnos.Rows[e.RowIndex].Cells["colLegajo"].Value);

                PersonaService dp = new PersonaService();

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
                    formModificar.FormClosing += formModificar_FormClosing;
                    formModificar.ShowDialog();
                }
            }
        }

        private void formModificar_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ListarAlumnos();
        }
    }
}
