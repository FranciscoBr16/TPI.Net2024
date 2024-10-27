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
    public partial class FormMdiContenedor : MiFormBase
    {

        public FormMdiContenedor()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form formInicio = IsOpen(typeof(FormInicio));
            if (formInicio == null)
            {
                MostrarInicio();
            }
            else
            {
                formInicio.BringToFront();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Form formAlumnos = IsOpen(typeof(FormListadoAlumnos));
            if (formAlumnos == null)
            {
                formAlumnos = new FormListadoAlumnos();
                formAlumnos.MdiParent = this;
                formAlumnos.Show();
            }
            else
            {
                formAlumnos.BringToFront();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Form formProfes = IsOpen(typeof(FormListadoProfesores));
            if (formProfes == null)
            {
                formProfes = new FormListadoProfesores();
                formProfes.MdiParent = this;
                formProfes.Show();
            }
            else
            {
                formProfes.BringToFront();
            }
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Form formComisiones = IsOpen(typeof(FormListadoComisiones));
            if (formComisiones == null)
            {
                formComisiones = new FormListadoComisiones();
                formComisiones.MdiParent = this;
                formComisiones.Show();
            }
            else
            {
                formComisiones.BringToFront();
            }
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            Form formPlanes = IsOpen(typeof(FormListadoPlanes));
            if (formPlanes == null)
            {
                formPlanes = new FormListadoPlanes();
                formPlanes.MdiParent = this;
                formPlanes.Show();
            }
            else
            {
                formPlanes.BringToFront();
            }
        }



        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            Form formEspecialidades = IsOpen(typeof(FormListadoEspecialidades));
            if (formEspecialidades == null)
            {
                formEspecialidades = new FormListadoEspecialidades();
                formEspecialidades.MdiParent = this;
                formEspecialidades.Show();
            }
            else
            {
                formEspecialidades.BringToFront();
            }
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            Form formListadoMaterias = IsOpen(typeof(FormListadoMaterias));
            if (formListadoMaterias == null)
            {
                FormListadoMaterias formListadoMat = new FormListadoMaterias();
                formListadoMat.MdiParent = this;
                formListadoMat.Usuario = this.Usuario;
                formListadoMat.Show();
            }
            else
            {
                formListadoMaterias.BringToFront();
            }
        }

        private void FormMdiContenedor_Load(object sender, EventArgs e)
        {
            this.ActualizarVisibilidad();
            MostrarInicio();
        }
        private void MostrarInicio()
        {
            FormInicio inicio = new FormInicio();
            inicio.MdiParent = this;
            inicio.Usuario = this.Usuario; //ok?
            inicio.FormClosing += FormInicio_FormClosing;
            inicio.Show();
        }

        public override void ActualizarVisibilidad()
        {
            if (this.Usuario != null)
            {
                if (this.Usuario.Rol == "Admin")
                {

                    toolStripLabel1.Visible = true;
                    toolStripLabel2.Visible = true;
                    toolStripLabel3.Visible = true;
                    toolStripLabel4.Visible = true;
                    toolStripLabel5.Visible = true;
                    toolStripLabel6.Visible = true;
                    toolStripLabel7.Visible = true;
                    toolStripLabel8.Visible = true;
                    toolStripLabel9.Visible = true;
                }
                else
                {
                    toolStripLabel9.Visible = true; //perfil
                }
            }
            else
            {
                toolStripLabel2.Visible = false;
                toolStripLabel3.Visible = false;
                toolStripLabel4.Visible = false;
                toolStripLabel5.Visible = false;
                toolStripLabel6.Visible = false;
                toolStripLabel7.Visible = false;
                toolStripLabel8.Visible = false;
                toolStripLabel9.Visible = false;
            }



        }

        private Form IsOpen(Type formType)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == formType)
                {
                    return form;
                }
            }
            return null;
        }

        private void FormInicio_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ActualizarVisibilidad();

        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            Form formPerfil = IsOpen(typeof(FormPerfil));
            if (formPerfil == null)
            {
                FormPerfil formPer = new FormPerfil();
                formPer.MdiParent = this;
                formPer.Usuario = this.Usuario;
                formPer.Show();
            }
            else
            {
                formPerfil.BringToFront();
            }

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Form formListado = IsOpen(typeof(FormListadoCursos));
            if (formListado == null)
            {
                FormListadoCursos formListadoC = new FormListadoCursos();
                formListadoC.MdiParent = this;
                formListadoC.Usuario = this.Usuario;
                formListadoC.Show();
            }
            else
            {
                formListado.BringToFront();
            }
        }
    }
}
