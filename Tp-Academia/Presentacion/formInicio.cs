using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : MiFormBase
    {
        public FormInicio()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevaPersona formNuevo = new FormNuevaPersona();
            formNuevo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.FormClosing += FormLogIn_FormClosing;
            formLogIn.ShowDialog();
        }
        private void FormLogIn_FormClosing(object? sender, FormClosingEventArgs e)
        {
            
            var formLogIn = sender as MiFormBase;
            if (formLogIn != null && formLogIn.Usuario != null)
            {

                this.Usuario = formLogIn.Usuario;


                var formContenedor = this.MdiParent as MiFormBase;
                if (formContenedor != null)
                {
                    formContenedor.Usuario = this.Usuario;
                    formContenedor.ActualizarVisibilidad();
                    this.Close(); // o quizas redirigir
                }
            }
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormNuevaPersona formNuevo = new FormNuevaPersona();
            formNuevo.ShowDialog();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            ActualizarVisibilidad();
        }

        public override void ActualizarVisibilidad()
        {
            if (this.Usuario != null)
            {

                btnCerrarSesion.Visible = true;
                btnIniciarSesion.Visible = false;
                btnRegistrarse.Visible = false;

            }
            else
            {
                btnCerrarSesion.Visible = false;
                btnIniciarSesion.Visible = true;
                btnRegistrarse.Visible = true;

            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Usuario = null;
            var mdiParent = this.MdiParent as MiFormBase;
            if(mdiParent != null)
            {
                mdiParent.Usuario = null;
                mdiParent.Usuario = null;

                foreach (Form childForm in mdiParent.MdiChildren)
                {
                    childForm.Close();
                }
            }
            
            ActualizarVisibilidad();
            this.Close(); 
        }
    }
}
