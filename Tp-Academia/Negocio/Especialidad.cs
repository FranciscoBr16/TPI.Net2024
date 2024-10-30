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
            EspecialidadService de = new EspecialidadService();
            return de.ModificarEspecialidad(per);
        }

        public static bool AgregarEspecialidad(Entidades.Especialidad per)
        {
            EspecialidadService de = new EspecialidadService();
            return de.InsertEspecialidad(per);
        }

        public static bool EliminarEspecialidad(Entidades.Especialidad Especialidad)
        {
            EspecialidadService de = new EspecialidadService();
            return de.EliminarEspecialidad(Especialidad);

        }

        public static Entidades.Especialidad GetEspecialidadById(int id)
        {
            EspecialidadService de = new EspecialidadService();
            return de.GetEspecialidadById(id);
        }

        public static List<Entidades.Especialidad> GetEspecialidades()
        {
            EspecialidadService de = new EspecialidadService();
            return de.GetEspecialidades();
        }
    }
}
