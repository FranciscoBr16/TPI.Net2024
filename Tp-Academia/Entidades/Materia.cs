using System.Numerics;

namespace Entidades
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public int CantHorasSemanales { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Plan Plan { get; set; }
        private List<Curso> Cursos { get; set; }

        public Materia (int idMateria, int cantHorasSemanales, string nombre, string descripcion, Plan plan)
        {
            IdMateria = idMateria;
            CantHorasSemanales = cantHorasSemanales;
            Nombre = nombre;
            Descripcion = descripcion;
            Plan = plan;
        }

    }
}