using Data;
using Entidades;
using Presentacion.ApiClients;
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
    public partial class FormListadoCursos : MiFormBase
    {
        public FormListadoCursos()
        {
            InitializeComponent();
        }


        private async void FormListadoCursos_Load(object sender, EventArgs e)
        {
            
            if (Usuario != null && Usuario.Rol == "Admin")
            {
                await ListarCursos();
                btnNuevoCurso.Visible = true;
                dgvCursos.Columns["colBtnModificar"].Visible = true;
                dgvCursos.Columns["colBtnEliminar"].Visible = true;
                dgvCursos.Columns["ColBtnInscripcion"].Visible = true;

            }
            else if (Usuario != null && Usuario.Rol == "Alumno")
            {
                btnNuevoCurso.Visible = false;
                dgvCursos.Columns["colBtnModificar"].Visible = false;
                dgvCursos.Columns["colBtnEliminar"].Visible = false;
                dgvCursos.Columns["ColBtnInscripcion"].Visible = true;
            }
        }

        public async Task ListarCursos()
        {
            IEnumerable<Curso> cursos = await CursoApiClient.GetAllAsync();

            var cursosParaMostrar = new List<object>();

            foreach (var curso in cursos)
            {
                var profesor = (await PersonaApiClient.GetProfesoresDelCursoAsync(curso.Id)).FirstOrDefault();

                var materia = await MateriaApiClient.GetAsync(curso.MateriaId);
                var materiaDescripcion = materia?.Nombre ?? "Descripción de la materia no disponible";

                var comision = await ComisionApiClient.GetAsync(curso.ComisionId);
                var comisionDescripcion = comision?.Descripcion ?? "Descripcion de la comision no disponible";


                cursosParaMostrar.Add(new
                {
                    curso.Id,
                    MateriaDescripcion = materiaDescripcion,
                    curso.Fecha_Vencimiento_Inscripcion,
                    curso.Cupo,
                    curso.ComisionId,
                    curso.MateriaId,
                    NombreProfesorTeoria = profesor != null ? profesor.Nombre + " " + profesor.Apellido : "Profesor no disponible",
                    ComisionDescripcion = comisionDescripcion
                });
            }

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = cursosParaMostrar.ToList();
        }



        public async Task ListarCursosDisponibles()
        {
            List<Curso> cursos = (await CursoApiClient.GetAllAsync())
                                 .Where(c => c.Cupo > 0)
                                 .ToList();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = cursos;
            // Podrian faltar mas filtros
        }


        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            FormNuevoCurso form = new FormNuevoCurso();
            form.FormClosing += FormNuevoCurso_FormClosing;
            form.ShowDialog();
        }

        private void FormNuevoCurso_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ListarCursos();
        }

        private async void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvCursos.Columns[e.ColumnIndex].Name;

                int id = Convert.ToInt32(dgvCursos.Rows[e.RowIndex].Cells["Id"].Value);



                if (columnName == "colBtnEliminar")
                {
                    // Acción para eliminar
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        await CursoApiClient.DeleteAsync((id));
                        ListarCursos();
                    }
                }
                else if (columnName == "colBtnModificar")
                {
                    FormModificarCurso formModificar = new FormModificarCurso { Curso = await CursoApiClient.GetAsync(id)};
                    formModificar.FormClosing += FormModificarCurso_FormClosing;
                    formModificar.ShowDialog();
                } else if (columnName == "colBtnInscripcion")
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que quiere inscribirse a este curso?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Inscripcion ins = new Inscripcion { AlumnoLegajo = Usuario.Legajo, CursoId = id, Fecha = DateTime.Now };
                        await CursoApiClient.InscripcionAsync(ins);
                        
                    }
                }
            }
        }

        private void FormModificarCurso_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ListarCursos() ;
        }
    }

}
