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
        public int Id { get; set; }
        public int Cupo { get; set; }
        public int Anio { get; set; }

        public int ComisionId { get; set; }
        public int MateriaId { get; set; }

        public List<Inscripcion> Inscripciones { get; set; }
        
        public Comision Comision { get; set; }
        public Materia Materia { get; set; }

        public Curso() { }
        public Curso (int id, int cupo, int anio, Comision comision, Materia materia)
        {
            this.Id = id;
            this.Cupo = cupo;
            this.Anio = anio;
            Comision = comision;
            Materia = materia;
        }

        public Curso(int id, int cupo, int anio)
        {
            this.Id= id;
            this.Cupo = cupo;
            this.Anio = anio;
        }
    }
}
