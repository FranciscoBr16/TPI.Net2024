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
        public DbSet<Alumno> getAlumnos() { 
        using (AcademiaContext db= new AcademiaContext())
            {

            var Alumnos = db.Alumnos;

            return Alumnos;
            }
        }

        public Alumno getAlumnoByLegajo(int legajo)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Alumno a = db.Alumnos.Find(legajo);
                return a;
            }
        }
    }
}
