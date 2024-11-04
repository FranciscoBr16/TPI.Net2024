using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Entidades
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }
        public int CantHorasSemanales { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Anio { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        public List<Curso> Cursos { get; set; }

        public Materia() { }

    }
}