using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
namespace Entidades
{
    public class Plan
    {
        [Key]
        public int Id {  get; set; }
        public string Descripcion { get; set; }
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Persona> Alumnos { get; set; }

     
        public Plan(int id, string descripcion, int espId )
        {
            Id = id;
            Descripcion = descripcion;
            EspecialidadId = espId;
        }

    

        public Plan(string descripcion, int id)
        {
            Descripcion = descripcion;
            EspecialidadId = id;
        } 
       

        public Plan() { }

    }
}