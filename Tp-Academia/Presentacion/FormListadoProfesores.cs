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
    public partial class FormListadoProfesores : Form
    {
        public FormListadoProfesores()
        {
            InitializeComponent();
        }

        private void dgvProfesores_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvProfesores.Columns[e.ColumnIndex].Name;

                int legajo = Convert.ToInt32(dgvProfesores.Rows[e.RowIndex].Cells["colLegajo"].Value);

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

        private void FormListadoProfesores_Load(object sender, EventArgs e)
        {
           ListarProfesores();
        }

        public void ListarProfesores()
        {

            DataPersona dataProfesores = new DataPersona();

            List<Persona> listaProfesores = dataProfesores.GetProfesores();

            dgvProfesores.AutoGenerateColumns = false;

            dgvProfesores.DataSource = listaProfesores;


        }


    }
    

}
