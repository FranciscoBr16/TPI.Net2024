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
            MateriaService dm = new MateriaService();
            return dm.ModificarMateria(mate);
        }

        public static bool AgregarMateria(Entidades.Materia mate)
        {
            MateriaService dm = new MateriaService();
            return dm.InsertMateria(mate);
        }

        public static bool EliminarMateria(Entidades.Materia Materia)
        {
            MateriaService dm = new MateriaService();
            return dm.EliminarMateria(Materia);

        }

        public static Entidades.Materia GetMateriaById(int id)
        {
            MateriaService dm= new MateriaService();
            return dm.GetMateriaById(id);
        }

        public static List<Entidades.Materia> GetMaterias()
        {
            MateriaService dm= new MateriaService();
            return dm.GetMaterias();
        }
    }
}
