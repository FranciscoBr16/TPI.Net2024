using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    [Table("Persona")]
    public abstract class Persona
    {
        [Key]
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public int Tel { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
        public string Usuario { get; set; }
        public string AnioIngreso { get; set; }


    }
}


