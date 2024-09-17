using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Especialidad
    {
        [Key]
        public int Id {  get; set; }
        public string Descripcion { get; set; }

        public List<Plan> Planes { get; set; }

        public Especialidad(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public Especialidad(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}