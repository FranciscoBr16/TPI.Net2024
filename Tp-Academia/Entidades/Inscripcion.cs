using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Inscripcion
    {
        public int idInscripcion { get; set; }
        public string condicion { get; set; }
        public string fecha { get; set; }
        public int nota { get; set; }

        public Alumno alumno { get; set; }
        public Curso Curso { get; set; }


        public Inscripcion(int idInscripcion, string condicion, string fecha, int nota, Alumno alumno, Curso curso)
        {
            idInscripcion = idInscripcion;
            this.condicion = condicion;
            this.fecha = fecha;
            this.nota = nota;
            Alumno = alumno;
            Curso = curso;
        }
    }
}


