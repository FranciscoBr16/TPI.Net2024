using System;
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
        public int IdInscripcion { get; set; }
        public string Condicion { get; set; }
        public string Fecha { get; set; }
        public int Nota { get; set; }

        public Alumno Alumno { get; set; }
        public Curso Curso { get; set; }


        public Inscripcion(int idInscripcion, string condicion, string fecha, int nota, Alumno alumno, Curso curso)
        {
            this.IdInscripcion = idInscripcion;
            this.Condicion = condicion;
            this.Fecha = fecha;
            this.Nota = nota;
            this.Alumno = alumno;
            Curso = curso;
        }

        public Inscripcion(int idInscripcion, string condicion, string fecha, int nota)
        {
            this.IdInscripcion = idInscripcion;
            this.Condicion = condicion;
            this.Fecha = fecha;
            this.Nota = nota;
        }
    }
}


