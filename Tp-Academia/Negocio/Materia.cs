using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Materia
    {
        public static bool ModificarMateria(Entidades.Materia mate)
        {
            DataMateria dm = new DataMateria();
            return dm.ModificarMateria(mate);
        }

        public static bool AgregarMateria(Entidades.Materia mate)
        {
            DataMateria dm = new DataMateria();
            return dm.InsertMateria(mate);
        }

        public static bool EliminarMateria(Entidades.Materia Materia)
        {
            DataMateria dm = new DataMateria();
            return dm.EliminarMateria(Materia);

        }

        public static Entidades.Materia GetMateriaById(int id)
        {
            DataMateria dm= new DataMateria();
            return dm.GetMateriaById(id);
        }

        public static List<Entidades.Materia> GetMaterias()
        {
            DataMateria dm= new DataMateria();
            return dm.GetMaterias();
        }
    }
}
