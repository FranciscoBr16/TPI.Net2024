﻿using Entidades;
using ApiClients;
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

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbUsuario.Text, out int legajo))
            {
                string clave = tbClave.Text;
                // ok ?
                Persona per = new Persona { Legajo = legajo, Clave = clave };
                Persona persona = await PersonaApiClient.LogInAsync(per);

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
            else
            {
                MessageBox.Show("El legajo debe ser un valor numerico");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

