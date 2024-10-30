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
            PersonaService dp = new PersonaService();
            return dp.GetPersonaByLegajoYClave(legajo, clave);

        }

        public static bool ModificarPersona(Entidades.Persona per)
        {
            PersonaService dp = new PersonaService();
            return dp.ModificarPersona(per);
        }

        public static bool AgregarPersona(Entidades.Persona per)
        {
            PersonaService dp = new PersonaService();
            return dp.InsertPersona(per);
        }

        public static bool EliminarPersona(Entidades.Persona persona)
        {
            PersonaService dp = new PersonaService();
            return dp.EliminarPersona(persona);
            
        }

        public static Entidades.Persona GetPersonaByLegajo(int legajo)
        {
            PersonaService dp = new PersonaService();
            return dp.GetPersonaByLegajo(legajo);
        }

        public static List<Entidades.Persona> GetProfesoresDelCurso(int idCurso)
        {
            ProfesorYCursoService dpyc = new ProfesorYCursoService();
            return dpyc.GetProfesoresDelCurso(idCurso);
        }

    }
}
