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
    public partial class FormListadoEspecialidades : Form
    {
        public FormListadoEspecialidades()
        {
            InitializeComponent();
        }

        private void btnNuevaEspecialidad_Click(object sender, EventArgs e)
        {
            FormNuevaEspecialidad formNuevo = new FormNuevaEspecialidad();
            formNuevo.ShowDialog();
        }

        private void FormListadoEspecialidades_Load(object sender, EventArgs e)
        {
            ListarEspecialidades();
        }

        public void ListarEspecialidades()
        {

            List<Especialidad> listaEsp = Negocio.Especialidad.GetEspecialidades();

            dgvEspecialidades.AutoGenerateColumns = false;

            dgvEspecialidades.DataSource = listaEsp;


        }

        private void dgvEspecialidades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvEspecialidades.Columns[e.ColumnIndex].Name;

                // Validar que el valor de la celda no sea nulo antes de convertir
                var cellValue = dgvEspecialidades.Rows[e.RowIndex].Cells["Id"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idEsp))
                {
                    

                    if (columnName == "colBtnEliminarEsp")
                    {
                        // Acción para eliminar
                        DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Negocio.Especialidad.EliminarEspecialidad(Negocio.Especialidad.GetEspecialidadById(idEsp)); 
                        }
                    }
                    else if (columnName == "colBtnModificarEsp")
                    {
                        FormModificarEspecialidad formModificar = new FormModificarEspecialidad(Negocio.Especialidad.GetEspecialidadById(idEsp)); 
                        formModificar.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("El valor de la celda 'id' no es válido.", "Error de conversión");
                }
            }
        }
    }
}
