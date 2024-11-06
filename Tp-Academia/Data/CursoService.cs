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

        static public Curso InsertCurso(Curso curso)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Cursos.Add(curso);
                db.SaveChanges();
                return curso;
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

                var materiasInscritas = context.Inscripciones
                .Where(insc => insc.AlumnoLegajo == legajoAlumno)
                .Select(insc => insc.Curso.MateriaId)
                .Distinct() 
                .ToList();

                var cursosDisponibles = context.Cursos
                    .Where(curso =>
                        !materiasInscritas.Contains(curso.MateriaId) &&         
                        curso.Cupo > 0 &&                               
                        curso.Materia.PlanId == idPlanAlumno             
                    )
                    .ToList();

                return cursosDisponibles;
            }
        }

        
    }
    
}
