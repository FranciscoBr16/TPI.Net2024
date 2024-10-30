using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Comision
    {
        public static bool ModificarComision(Entidades.Comision Comision)
        {
            ComisionService dc = new ComisionService();
            return dc.ModificarComision(Comision);
        }

        public static bool AgregarComision(Entidades.Comision Comision)
        {
            ComisionService dc = new ComisionService();
            return dc.InsertComision(Comision);
        }

        public static bool EliminarComision(Entidades.Comision Comision)
        {
            ComisionService dc = new ComisionService();
            return dc.EliminarComision(Comision);

        }

        public static Entidades.Comision GetComisionById(int id)
        {
            ComisionService dc = new ComisionService();
            return dc.GetComisionById(id);
        }

        public static List<Entidades.Comision> GetComisiones()
        {
            ComisionService dc = new ComisionService();
            return dc.GetComisiones();
        }
    }
}
