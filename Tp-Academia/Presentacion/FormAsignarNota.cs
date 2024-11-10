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
    public partial class FormAsignarNota : Form
    {

        public Inscripcion Inscripcion { get; set; }
        public FormAsignarNota()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAsignarNota_Load(object sender, EventArgs e)
        {
            if (Inscripcion != null)
            {
                tbCondicion.Text = Inscripcion.Condicion;
                tbNota.Text = Inscripcion.Nota.ToString();
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {

            Inscripcion insNueva = new Inscripcion { Id = Inscripcion.Id, CursoId = Inscripcion.CursoId, AlumnoLegajo = Inscripcion.AlumnoLegajo, Condicion = tbCondicion.Text, Nota = int.Parse(tbNota.Text) };

            await InscripcionApiClient.UpdateAsync(insNueva);
            MessageBox.Show("Cambios guardados exitosamente.");
            this.Close();

        }
    }
}
