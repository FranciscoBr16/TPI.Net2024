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
        public int Id { get; set; }
        public string Condicion { get; set; }
        public string Fecha { get; set; }
        public int Nota { get; set; }

        public Persona Alumno { get; set; }
        public Curso Curso { get; set; }


        public Inscripcion(int id, string condicion, string fecha, int nota, Persona alumno, Curso curso)
        {
            this.Id = id;
            this.Condicion = condicion;
            this.Fecha = fecha;
            this.Nota = nota;
            this.Alumno = alumno;
            Curso = curso;
        }

        public Inscripcion(int id, string condicion, string fecha, int nota)
        {
            this.Id = id;
            this.Condicion = condicion;
            this.Fecha = fecha;
            this.Nota = nota;
        }
    }
}


