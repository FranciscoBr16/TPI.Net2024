using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Data
{
    public class DataPersona
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

        public bool insertPersona(Persona persona) {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Personas.Add(persona);
                db.SaveChanges();
                // Verificar si esto puede fallar
                return true;
            }
        }

        public bool eliminarPersona(Persona persona)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Personas.Remove(persona);
                db.SaveChanges();
                return true;
            }
        }

        public bool modificarPersona(Persona per)
        {
            using (var context = new AcademiaContext())
            {
                Persona personaOriginal = getPersonaByLegajo(per.Legajo);
                if (personaOriginal != null)
                {
                    personaOriginal.Nombre = per.Nombre;
                    personaOriginal.Apellido = per.Apellido;
                    personaOriginal.Mail = per.Mail;
                    personaOriginal.Fecha_nac = per.Fecha_nac;
                    personaOriginal.Tel = per.Tel;
                    personaOriginal.Clave = per.Clave;
                    personaOriginal.Usuario = per.Usuario;
                    personaOriginal.Direccion = per.Direccion;
                    personaOriginal.DNI = per.DNI;
                   
                    // Marca el estado de la entidad como modificado
                    context.Entry(personaOriginal).State = EntityState.Modified;

                    try
                    {
                        context.SaveChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

    }
    }

