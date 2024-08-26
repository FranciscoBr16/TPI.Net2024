﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Inscripcion
    {
        [Key]
        public int idInscripcion { get; set; }
        public string condicion { get; set; }
        public string fecha { get; set; }
        public int nota { get; set; }

        public Alumno alumno { get; set; }
        public Curso Curso { get; set; }


        public Inscripcion(int idInscripcion, string condicion, string fecha, int nota, Alumno alumno, Curso curso)
        {
            this.idInscripcion = idInscripcion;
            this.condicion = condicion;
            this.fecha = fecha;
            this.nota = nota;
            this.alumno = alumno;
            Curso = curso;
        }

        public Inscripcion(int idInscripcion, string condicion, string fecha, int nota)
        {
            this.idInscripcion = idInscripcion;
            this.condicion = condicion;
            this.fecha = fecha;
            this.nota = nota;
        }
    }
}


