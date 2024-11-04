using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class InscripcionService
    {
        static public List<Inscripcion> GetInscripciones()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var inscripciones = db.Inscripciones.ToList(); ;

                return inscripciones;
            }
        }

        static public Inscripcion GetInscripcionById(int id)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Inscripcion insc = db.Inscripciones.Find(id);
                return insc;
            }
        }

        static public bool InsertInscripcion(Inscripcion insc)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Curso cur = db.Cursos.Find(insc.CursoId);
                cur.Cupo--;
                CursoService.ModificarCurso(cur);
                db.Inscripciones.Add(insc);
                db.SaveChanges();
                return true;
            }
        }

        static public bool EliminarInscripcion(Inscripcion insc)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Inscripciones.Remove(insc);
                db.SaveChanges();
                return true;
            }
        }

        static public bool ModificarInscripcion(Inscripcion insc)
        {
            using (var context = new AcademiaContext())
            {
                Inscripcion inscripcionOriginal = GetInscripcionById(insc.Id);
                if (inscripcionOriginal != null)
                {

                    inscripcionOriginal.Condicion = insc.Condicion;
                    inscripcionOriginal.Fecha = insc.Fecha;
                    inscripcionOriginal.Nota = insc.Nota;
                    
                    context.Entry(inscripcionOriginal).State = EntityState.Modified;

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
