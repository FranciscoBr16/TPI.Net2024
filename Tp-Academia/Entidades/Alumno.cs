using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        public Alumno(int legajo, string nombre, string apellido, string mail, int tel, string clave, string rol, string usuario)
        {
            this.legajo = legajo;
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



