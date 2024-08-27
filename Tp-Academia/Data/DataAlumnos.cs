using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataAlumnos
    {
        public List<Persona> getAlumnos() { 
        using (AcademiaContext db= new AcademiaContext())
            {

            var Alumnos = db.Personas.ToList(); ;

            return Alumnos;
            }
        }

        public Persona getPersonaByLegajo(int legajo)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Persona a = db.Personas.Find(legajo);
                return a;
            }
        }
    }
}
