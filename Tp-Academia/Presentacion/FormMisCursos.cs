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
    public partial class FormMisCursos : MiFormBase
    {
        public FormMisCursos()
        {
            InitializeComponent();
        }

        private async void btnBaja_Click(object sender, EventArgs e)
        {
            if (SelectedItem() != null) {
                var i = SelectedItem();
                Inscripcion ins = await InscripcionApiClient.GetAsync(i.Id);
                DateTime f = ins.Fecha.AddDays(15);
                if (f > DateTime.Now)
                {
                    await InscripcionApiClient.DeleteAsync(i.Id);
                    MessageBox.Show("Te has dado de baja");
                    await ListarTodosLosCursos();
                }
                else { MessageBox.Show("No puedes darte de baja de ese curso, la fecha ya expiro");
                    return;
                }
            }
        }

        private async void FormMisCursos_Load(object sender, EventArgs e)
        {
            await ListarTodosLosCursos();
        }

        private async Task ListarTodosLosCursos()
        {
            IEnumerable<Inscripcion> ins = await InscripcionApiClient.GetInscripcionesDelAlumnoAsync(Usuario.Legajo);

            if (ins == null)
            {
                MessageBox.Show("No se encontraron inscripciones para el alumno.");
                return;
            }
            var cursosParaMostrar = new List<CursoMostrado>();

            foreach (var i in ins)
            {
                var profesor = (await PersonaApiClient.GetProfesoresDelCursoAsync(i.CursoId)).FirstOrDefault();
                var curso = await CursoApiClient.GetAsync(i.CursoId);
                var materia = await MateriaApiClient.GetAsync(curso.MateriaId);
                var materiaDescripcion = materia?.Nombre ?? "Descripción de la materia no disponible";

                var comision = await ComisionApiClient.GetAsync(curso.ComisionId);
                var comisionDescripcion = comision?.Descripcion ?? "Descripcion de la comision no disponible";

                cursosParaMostrar.Add(new CursoMostrado
                {
                    Id = i.Id,
                    MateriaId = curso.MateriaId,
                    MateriaDescripcion = materiaDescripcion,
                    NombreProfesor = profesor != null ? profesor.Nombre + " " + profesor.Apellido : "Profesor no disponible",
                    ComisionDescripcion = comisionDescripcion,
                    Fecha = i.Fecha,
                    Condicion = i.Condicion,
                    Nota = i.Nota
                });
                
            }
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = cursosParaMostrar.ToList();
        }
        private CursoMostrado SelectedItem()
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                return (CursoMostrado)dgvCursos.SelectedRows[0].DataBoundItem;
            }
            return null;
        }
    }

    public class CursoMostrado
    {
        public int Id { get; set; }
        public int MateriaId { get; set; }
        public string MateriaDescripcion { get; set; }
        public string NombreProfesor {  get; set; }
        public string ComisionDescripcion {get;set; }
        public DateTime Fecha { get; set; }
        public string Condicion { get; set; }
        public int Nota { get; set; }
                   
    }
}
