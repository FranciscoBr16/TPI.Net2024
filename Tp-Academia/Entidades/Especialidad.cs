using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad {  get; set; }
        public string Descripcion { get; set; }

        public List<Plan> Planes { get; set; }

        public Especialidad(int idEspecialidad, string descripcion)
        {
            IdEspecialidad = idEspecialidad;
            Descripcion = descripcion;
        }
    }
}