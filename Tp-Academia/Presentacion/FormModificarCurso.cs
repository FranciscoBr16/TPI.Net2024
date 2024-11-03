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
    public partial class FormModificarCurso : Form
    {
        internal Entidades.Curso Curso { get; set; }
        internal List<Persona> Profesores { get; set; }
        public FormModificarCurso()
        {
            InitializeComponent();
        }

        private async void FormModificarCurso_Load(object sender, EventArgs e)
        {
            await CargarComisionesAsync();
            await CargarMateriasAsync();
            Profesores = (await CursoApiClient.GetProfesDelCursoAsync(Curso.Id)).ToList();
            tbCupo.Text = Curso.Cupo.ToString();
            dtpFecha.Value = Curso.Fecha_Vencimiento_Inscripcion;
            cbComision.SelectedValue = Curso.ComisionId;
            cbMateria.SelectedValue = Curso.MateriaId;
            

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

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            FormAgregarProfesor form = new FormAgregarProfesor();
            form.FormClosing += FormAgregarProfesor_FormClosing;
            form.Profesores = this.Profesores;
            form.ShowDialog();
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
                try
                {
                    Curso cursoNuevo = new Curso
                    {
                        Id = Curso.Id,
                        Cupo = int.Parse(tbCupo.Text),
                        Fecha_Vencimiento_Inscripcion = dtpFecha.Value,
                        ComisionId = (int)cbComision.SelectedValue,
                        MateriaId = (int)cbMateria.SelectedValue
                    };
                    await CursoApiClient.UpdateAsync(cursoNuevo);
                   

                    var profesAntiguos = (await CursoApiClient.GetProfesDelCursoAsync(Curso.Id)).ToList();
                    var profesoresAEliminar = profesAntiguos.Except(Profesores).ToList();
                    var profesoresAAgregar = Profesores.Except(profesAntiguos).ToList();

                    foreach (var profesor in profesoresAEliminar)
                    {
                        await CursoApiClient.DeleteProfeyCursoAsync(Curso.Id, profesor.Legajo);
                    }

                    foreach (var profesor in profesoresAAgregar)
                    {
                        Docente_curso dc = new Docente_curso
                        {
                            DocenteId = profesor.Legajo,
                            CursoId = Curso.Id,
                            Fecha = DateTime.Now
                        };
                        await CursoApiClient.AddProfesAsync(dc);
                    }

                    MessageBox.Show("Curso Modificado con exito");

                }
                catch (Exception ex) { MessageBox.Show($"Error al modificar el curso: {ex.Message}"); }
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            int cupo;

            if (string.IsNullOrWhiteSpace(tbCupo.Text) || !int.TryParse(tbCupo.Text, out cupo))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el cupo.");
                return false;
            }

            if (Profesores.Count == 0)
            {
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
