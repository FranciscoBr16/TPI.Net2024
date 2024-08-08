using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comision
    {
        public int IdComision { get; set; }
        public string Descripcion { get; set; }
        public string Turno { get; set; }


        public Comision(int id, string descripcion, string turn)
        {
            IdComision = id;
            Descripcion = descripcion;
            Turno = turn;

        }

    }
}
