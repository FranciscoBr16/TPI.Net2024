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
    public partial class FormMdiContenedor : Form
    {
        public FormMdiContenedor()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.MdiParent = this;
            formInicio.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FormListadoAlumnos formAlumnos = new FormListadoAlumnos();
            formAlumnos.MdiParent = this;
            formAlumnos.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            FormListadoComisiones formComisiones = new FormListadoComisiones();
            formComisiones.MdiParent = this;
            formComisiones.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            FormListadoPlanes formPlanes = new FormListadoPlanes();
            formPlanes.MdiParent = this;
            formPlanes.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            FormListadoProfesores formProfes = new FormListadoProfesores();
            formProfes.MdiParent = this;
            formProfes.Show();
        }
    }
}
