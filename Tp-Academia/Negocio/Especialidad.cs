using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Especialidad
    {
        public static bool ModificarEspecialidad(Entidades.Especialidad per)
        {
            DataEspecialidad de = new DataEspecialidad();
            return de.ModificarEspecialidad(per);
        }

        public static bool AgregarEspecialidad(Entidades.Especialidad per)
        {
            DataEspecialidad de = new DataEspecialidad();
            return de.InsertEspecialidad(per);
        }

        public static bool EliminarEspecialidad(Entidades.Especialidad Especialidad)
        {
            DataEspecialidad de = new DataEspecialidad();
            return de.EliminarEspecialidad(Especialidad);

        }

        public static Entidades.Especialidad GetEspecialidadById(int id)
        {
            DataEspecialidad de = new DataEspecialidad();
            return de.GetEspecialidadById(id);
        }

        public static List<Entidades.Especialidad> GetEspecialidades()
        {
            DataEspecialidad de = new DataEspecialidad();
            return de.GetEspecialidades();
        }
    }
}
