namespace Entidades
{
    public class Especialidad
    {
        public int IdEspecialidad {  get; set; }
        public string Descripcion { get; set; }

        public Especialidad(int idEspecialidad, string descripcion)
        {
            IdEspecialidad = idEspecialidad;
            Descripcion = descripcion;
        }
    }
}