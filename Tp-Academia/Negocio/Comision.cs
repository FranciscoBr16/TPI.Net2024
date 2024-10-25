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
            DataComision dc = new DataComision();
            return dc.ModificarComision(Comision);
        }

        public static bool AgregarComision(Entidades.Comision Comision)
        {
            DataComision dc = new DataComision();
            return dc.InsertComision(Comision);
        }

        public static bool EliminarComision(Entidades.Comision Comision)
        {
            DataComision dc = new DataComision();
            return dc.EliminarComision(Comision);

        }

        public static Entidades.Comision GetComisionById(int id)
        {
            DataComision dc = new DataComision();
            return dc.GetComisionById(id);
        }

        public static List<Entidades.Comision> GetComisiones()
        {
            DataComision dc = new DataComision();
            return dc.GetComisiones();
        }
    }
}
