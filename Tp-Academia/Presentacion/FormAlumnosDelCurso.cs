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
    public partial class FormAlumnosDelCurso : Form
    {
        public int IdCurso { get; set; }
        public FormAlumnosDelCurso()
        {
            InitializeComponent();
        }

        private void FormAlumnosDelCurso_Load(object sender, EventArgs e)
        {
            ListarAlumnos();
        }

        private async void ListarAlumnos()
        {
            IEnumerable<Inscripcion> ins = await InscripcionApiClient.GetInscripcionesDelCurso(IdCurso);

            var alumnosDelCurso = new List<object>();

            foreach (var i in ins)
            {

                var persona = await PersonaApiClient.GetAsync(i.AlumnoLegajo);


                alumnosDelCurso.Add(new
                {
                    Id = i.Id,
                    persona.Legajo,
                    persona.Nombre,
                    persona.Apellido,
                    persona.Mail,
                    i.Nota,
                    i.Condicion
                });
            }

            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.DataSource = alumnosDelCurso.ToList();
        }

        private async void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre de la columna en la que se hizo clic
                string columnName = dgvAlumnos.Columns[e.ColumnIndex].Name;

                int id = Convert.ToInt32(dgvAlumnos.Rows[e.RowIndex].Cells["IdInscripcion"].Value);

                if (columnName == "colBtnModificar")
                {
                    FormAsignarNota formModificar = new FormAsignarNota { Inscripcion = await InscripcionApiClient.GetAsync(id) };
                    formModificar.FormClosing += FormModificarCurso_FormClosing;
                    formModificar.ShowDialog();
                }
             
                }
            }

        private void FormModificarCurso_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ListarAlumnos();
        }
    }
}
