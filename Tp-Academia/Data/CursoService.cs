using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CursoService
    {
        public List<Curso> GetCursos()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var Cursos = db.Cursos.ToList(); ;

                return Cursos;
            }
        }

        public Curso GetCursoById(int id)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Curso curso = db.Cursos.Find(id);
                return curso;
            }
        }

        public bool InsertCurso(Curso curso)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Cursos.Add(curso);
                db.SaveChanges();
                return true;
            }
        }

        public bool EliminarCurso(Curso curso)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Cursos.Remove(curso);
                db.SaveChanges();
                return true;
            }
        }

        public bool ModificarCurso(Curso curso)
        {
            using (var context = new AcademiaContext())
            {
                Curso cursoOriginal = GetCursoById(curso.Id);
                if (cursoOriginal != null)
                {

                    cursoOriginal.Anio = curso.Anio;
                    // VER COMO HACER PARA MODIFICAR LOS PORFESORES, LA MATERIA Y LA COMISION


                    // Marca el estado de la entidad como modificado
                    context.Entry(cursoOriginal).State = EntityState.Modified;

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

        public bool InscripcionAlumnoCurso(int legajoAlumno, int idCurso)
        {
            Curso curso = GetCursoById(idCurso);
            using (AcademiaContext db = new AcademiaContext())
            {
                if (curso != null)
                {

                    curso.Cupo--;

                    Inscripcion inscripcion = new Inscripcion {CursoId = idCurso, AlumnoLegajo = legajoAlumno, Fecha = DateTime.Now, Condicion = "Inscripto" };
                    db.Inscripciones.Add(inscripcion);

                    db.Entry(curso).State = EntityState.Modified;

                    try
                    {
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }

                
                db.SaveChanges();
                return true;
            }
        }
    }
}
