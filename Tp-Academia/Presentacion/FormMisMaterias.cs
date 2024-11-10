using ApiClients;
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
    public partial class FormMisMaterias : MiFormBase
    {
        public FormMisMaterias()
        {
            InitializeComponent();
        }


        private void dgvCursos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvCursos.Columns[e.ColumnIndex].Name;

                int id = Convert.ToInt32(dgvCursos.Rows[e.RowIndex].Cells["Id"].Value);


                if (columnName == "colBtnAlumnos")
                {
                    FormAlumnosDelCurso formAlumnosDelCurso = new FormAlumnosDelCurso();
                    formAlumnosDelCurso.IdCurso = id;
                    formAlumnosDelCurso.ShowDialog();
                }

            }
        }

        private void FormMisMaterias_Load(object sender, EventArgs e)
        {
            ListarCursos();
        }

        private async void ListarCursos()
        {
            dgvCursos.DataSource = null;

            IEnumerable<Curso> listaCursos= await CursoApiClient.GetCursosDelProfesorAsync(Usuario.Legajo);

            var cursosAMostrar = new List<object>();

            foreach (var i in listaCursos)
            {

                var materia = await MateriaApiClient.GetAsync(i.MateriaId);
                var comision = await ComisionApiClient.GetAsync(i.ComisionId);
                var inscripciones = await InscripcionApiClient.GetInscripcionesDelCurso(i.Id);
                int contador = inscripciones.Count();

               cursosAMostrar.Add(new
                {
                   i.Id,
                   i.Cupo,
                   i.Fecha_Vencimiento_Inscripcion,
                   contador,
                   i.MateriaId,
                   MateriaDescripcion = materia.Nombre,
                   ComisionDescripcion = comision.Descripcion
                });
            }

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = cursosAMostrar;


        }
    }
}
