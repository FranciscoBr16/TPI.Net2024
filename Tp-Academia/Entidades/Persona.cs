
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public class Persona
    {
        [Key]
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public int Tel { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
        public string Usuario { get; set; }
        public string AnioIngreso { get; set; }
        public List<Inscripcion> Inscripcioens { get; set; }
        public List<Curso> Cursos { get; set; }

        public Persona( int legajo, string nombre, string apellido, string mail, int tel, string clave, string rol, string usuario)
        {
            this.Legajo = legajo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Tel = tel;
            this.Clave = clave;
            this.Rol = rol;
            this.Usuario = usuario;
        }
    }

}



