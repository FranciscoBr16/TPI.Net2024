using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public abstract class Persona
    {
        [Key]
        public int legajo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public int tel { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }
        public string usuario { get; set; }
        public string anioIngreso { get; set; }


    }
}


