using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente_curso
    {
        public Persona Docente { get; set; }
        public int DocenteId { get; set; } // Clave foránea para Persona
        public Curso Curso { get; set; }
        public int CursoId { get; set; } // Clave foránea para Curso
        public string Cargo {  get; set; }
        public DateTime Fecha { get; set; }

        public Docente_curso(Persona docente, Curso curso, string cargo, DateTime fecha)
        {
            Docente = docente;
            Curso = curso;
            Cargo = cargo;
            Fecha = fecha;
        }
        public Docente_curso()
        {
        }
    }
}
