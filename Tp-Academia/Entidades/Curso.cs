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
        public DateTime Fecha_Vencimiento_Inscripcion { get; set; }

        public int ComisionId { get; set; }
        public int MateriaId { get; set; }

        public List<Inscripcion> Inscripciones { get; set; }
        
        public Comision Comision { get; set; }
        public Materia Materia { get; set; }

        public Curso() { }
    }
}
