using Entidades;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Persona
    {
        public static Entidades.Persona GetPersonaByLegajoYClave(int legajo, string clave)
        {
            DataPersona dp = new DataPersona();
            return dp.GetPersonaByLegajoYClave(legajo, clave);

        }

        public static bool ModificarPersona(Entidades.Persona per)
        {
            DataPersona dp = new DataPersona();
            return dp.ModificarPersona(per);
        }

        public static bool AgregarPersona(Entidades.Persona per)
        {
            DataPersona dp = new DataPersona();
            return dp.InsertPersona(per);
        }

        public static bool EliminarPersona(Entidades.Persona persona)
        {
            DataPersona dp = new DataPersona();
            return dp.EliminarPersona(persona);
            
        }

        public static Entidades.Persona GetPersonaByLegajo(int legajo)
        {
            DataPersona dp = new DataPersona();
            return dp.GetPersonaByLegajo(legajo);
        }

        public static List<Entidades.Persona> GetProfesoresDelCurso(int idCurso)
        {
            DataProfesorYCurso dpyc = new DataProfesorYCurso();
            return dpyc.GetProfesoresDelCurso(idCurso);
        }

    }
}
