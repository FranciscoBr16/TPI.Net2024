using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public int Cupo { get; set; }
        public int Anio { get; set; }
        public Comision Comision { get; set; }
        public Profesor Profesor { get; set; }
        public Materia Materia { get; set; }

        public Curso (int idCurso, int cupo, int anio, Comision comision, Profesor profesor, Materia materia)
        {
            IdCurso = idCurso;
            this.Cupo = cupo;
            this.Anio = anio;
            Comision = comision;
            Profesor = profesor;
            Materia = materia;
        }
    }
}
