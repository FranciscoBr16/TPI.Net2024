
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public class Profesor : Persona
    {
        public string cargo {  get; set; }

        public Profesor(string cargo, int legajo, string nombre, string apellido, string mail, int tel, string clave, string rol, string usuario)
        {
            this.Legajo = legajo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Tel = tel;
            this.Clave = clave;
            this.Rol = rol;
            this.Usuario = usuario;
            this.cargo = cargo;
        }
    }

}



