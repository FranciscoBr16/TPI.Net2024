﻿using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormLogIn : MiFormBase
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(tbUsuario.Text);
            string clave = tbClave.Text;

            DataPersona dp = new DataPersona();
            Persona persona = dp.GetPersonaByLegajoYClave(legajo, clave);

            
            if (persona != null)
            {

                this.Usuario = persona;
                MessageBox.Show("Login exitoso");
                this.Close();

                
            }
            else
            {
                MessageBox.Show("Legajo o clave incorrectos.");
            }
        }
    }
}
