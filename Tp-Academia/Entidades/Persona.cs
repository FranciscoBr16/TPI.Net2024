using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Persona
    {
        public int legajo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public int tel { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }
        public string usuario { get; set; }

        public Persona(int legajo, string nombre, string apellido, string mail, int tel, string clave, string rol, string usuario)
        {
            legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.tel = tel;
            this.clave = clave;
            this.rol = rol;
            this.usuario = usuario;
        }
    }
}


