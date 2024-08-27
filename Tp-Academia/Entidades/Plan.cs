using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Plan
    {
        [Key]
        public int IdPlan {  get; set; }
        public string Descripcion { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Materia> Materias { get; set; }

        public Plan(int idPlan, string descripcion, Especialidad especialidad)
        {
            IdPlan = idPlan;
            Descripcion = descripcion;
            Especialidad = especialidad;
        }
        public Plan(int idPlan, string descripcion)
        {
            IdPlan = idPlan;
            Descripcion = descripcion;
        }
    }
}