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
    public class PersonaService
    {
        static public List<Persona> GetProfesores()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var profesores = db.Personas
                            .Where(p => p.Rol == "Profesor")
                            .ToList();

                return profesores;
            }
        }
        static public List<Persona> GetPersonas()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                return db.Personas.ToList();
            }
        }
        static public Persona GetPersonaByLegajoYClave(Persona per)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var persona = db.Personas.FirstOrDefault(p => p.Legajo == per.Legajo && p.Clave == per.Clave);

                return persona;  
            }

        }
        static public List<Persona> GetAlumnos() { 
        using (AcademiaContext db= new AcademiaContext())
            {

                var alumnos = db.Personas
                            .Where(p => p.Rol == "Alumno")
                            .ToList();

                return alumnos;
            }
        }

        static public Persona GetPersonaByLegajo(int legajo)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                var persona = db.Personas.FirstOrDefault(p => p.Legajo == legajo);
                return persona;
            }
        }

        static public bool InsertPersona(Persona persona) {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Personas.Add(persona);
                db.SaveChanges();
                return true;
            }
        }

        static public bool EliminarPersona(Persona persona)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Personas.Remove(persona);
                db.SaveChanges();
                return true;
            }
        }

        static public bool ModificarPersona(Persona per)
        {
            using (var context = new AcademiaContext())
            {
                Persona personaOriginal = GetPersonaByLegajo(per.Legajo);
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

