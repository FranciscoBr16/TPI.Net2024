using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Plan
    {
        [Key]
        public int Id {  get; set; }
        public string Descripcion { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Persona> Alumnos { get; set; }

        public Plan(int id, string descripcion, Especialidad especialidad)
        {
            Id = id;
            Descripcion = descripcion;
            Especialidad = especialidad;
        }
        public Plan(int id, string descripcion)
        {
            Id= id;
            Descripcion = descripcion;
        }
    }
}