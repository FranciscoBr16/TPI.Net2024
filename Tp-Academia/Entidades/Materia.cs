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
        public Plan Plan { get; set; }
        private List<Curso> Cursos { get; set; }

        public Materia (int id, int cantHorasSemanales, string nombre, string descripcion, Plan plan)
        {
            Id = id;
            CantHorasSemanales = cantHorasSemanales;
            Nombre = nombre;
            Descripcion = descripcion;
            Plan = plan;
        }
        public Materia(int id, int cantHorasSemanales, string nombre, string descripcion)
        {
            Id = id;
            CantHorasSemanales = cantHorasSemanales;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}