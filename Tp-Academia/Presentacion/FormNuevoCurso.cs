using Entidades;
using ApiClients;
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
    public partial class FormNuevoCurso : Form
    {
        public List<Persona> Profesores {  get; set; }
        public FormNuevoCurso()
        {
            InitializeComponent();
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            FormAgregarProfesor formAgregar = new FormAgregarProfesor{Profesores = this.Profesores};
            formAgregar.FormClosing += FormAgregarProfesor_FormClosing;
            formAgregar.ShowDialog();
        }

        private void FormAgregarProfesor_FormClosing(object? sender, FormClosingEventArgs e)
        {
            var formAgregar = sender as FormAgregarProfesor;
            this.Profesores = formAgregar.Profesores;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Curso cursoNuevo = new Curso
                {
                    Cupo = int.Parse(tbCupo.Text),
                    Fecha_Vencimiento_Inscripcion = dtpFecha.Value,
                    ComisionId = (int)cbComision.SelectedValue,
                    MateriaId = (int)cbMateria.SelectedValue
                };
                int idCursoCreado = await CursoApiClient.AddAsync(cursoNuevo);

                foreach (Persona unProfe in Profesores)
                {
                    Docente_curso dc = new Docente_curso { DocenteId= unProfe.Legajo , CursoId = idCursoCreado, Fecha= DateTime.Now };
                    await CursoApiClient.AddProfesAsync(dc);
                }
                MessageBox.Show("Nuevo Curso Registrado");

            }
            this.Close();
        }

        private bool ValidarCampos()
        {
            int cupo;

            if (string.IsNullOrWhiteSpace(tbCupo.Text) || !int.TryParse(tbCupo.Text, out cupo))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el cupo.");
                return false;
            }

            if (Profesores.Count == 0) {
                MessageBox.Show("Debe asignar un profesor");
                return false;
            }

            if (!dtpFecha.Checked)
            {
                MessageBox.Show("Seleccione una fecha de vencimiento.");
                return false;
            }

            if (cbComision.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una comisión.");
                return false;
            }

            if (cbMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una materia.");
                return false;
            }

            return true;
        }

        private async void FormNuevoCurso_Load(object sender, EventArgs e)
        {
            await CargarComisionesAsync();
            await CargarMateriasAsync();
            Profesores = new List<Persona>();
        }

        private async Task CargarComisionesAsync()
        {
            var comisiones = await ComisionApiClient.GetAllAsync(); 

            cbComision.DataSource = comisiones;
            cbComision.DisplayMember = "Descripcion";
            cbComision.ValueMember = "Id"; 
        }

        private async Task CargarMateriasAsync()
        {

            var materias = await MateriaApiClient.GetAllAsync(); 

            cbMateria.DataSource = materias;
            cbMateria.DisplayMember = "Nombre"; 
            cbMateria.ValueMember = "Id"; 
        }

    }
}
