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
        static public List<Curso> GetCursos()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var Cursos = db.Cursos.ToList(); ;

                return Cursos;
            }
        }

        static public Curso GetCursoById(int id)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Curso curso = db.Cursos.Find(id);
                return curso;
            }
        }

        static public bool InsertCurso(Curso curso)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Cursos.Add(curso);
                db.SaveChanges();
                return true;
            }
        }

        static public bool EliminarCurso(Curso curso)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Cursos.Remove(curso);
                db.SaveChanges();
                return true;
            }
        }

        static public bool ModificarCurso(Curso curso)
        {
            using (var context = new AcademiaContext())
            {
                Curso cursoOriginal = GetCursoById(curso.Id);
                if (cursoOriginal != null)
                {

                    cursoOriginal.Fecha_Vencimiento_Inscripcion = curso.Fecha_Vencimiento_Inscripcion;
                    cursoOriginal.MateriaId = curso.MateriaId;
                    cursoOriginal.ComisionId = curso.ComisionId;   
                    cursoOriginal.Cupo = curso.Cupo;

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

        static public bool InscripcionAlumnoCurso(int legajoAlumno, int idCurso)
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

        public static IEnumerable<Curso> GetCursosDisponiblesParaAlumno(int legajoAlumno)
        {
            using (var context = new AcademiaContext())
            {
                var alumno = context.Personas.Find(legajoAlumno);
                if (alumno == null)
                {
                    throw new ArgumentException("El alumno no existe.");
                }
                var idPlanAlumno = alumno.PlanId;

                var cursosInscritos = context.Inscripciones
                    .Where(insc => insc.AlumnoLegajo == legajoAlumno)
                    .Select(insc => insc.CursoId);

                var cursosDisponibles = context.Cursos
                    .Where(curso =>
                        !cursosInscritos.Contains(curso.Id) &&         
                        curso.Cupo > 0 &&                               
                        curso.Materia.PlanId == idPlanAlumno             
                    )
                    .ToList();

                return cursosDisponibles;
            }
        }

    }
}
