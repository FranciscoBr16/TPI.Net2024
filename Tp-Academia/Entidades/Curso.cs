using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public int Cupo { get; set; }
        public int Anio { get; set; }
        public Comision Comision { get; set; }
        public Materia Materia { get; set; }

        public Curso (int idCurso, int cupo, int anio, Comision comision, Materia materia)
        {
            IdCurso = idCurso;
            this.Cupo = cupo;
            this.Anio = anio;
            Comision = comision;
            Materia = materia;
        }

        public Curso(int idCurso, int cupo, int anio)
        {
            IdCurso = idCurso;
            this.Cupo = cupo;
            this.Anio = anio;
        }
    }
}
