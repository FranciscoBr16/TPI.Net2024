using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProfesorYCursoService
    {
        static public List<Docente_curso> GetProfesoresYCursos()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var profeycurso = db.Docente_curso.ToList();

                return profeycurso;
            }
        }

        static public List<Persona> GetProfesoresDelCurso(int idCurso)
        {
            List<Persona> profes = new List<Persona>();
            using (AcademiaContext db = new AcademiaContext())
            {
                List<Docente_curso> profedelcurso = db.Docente_curso.Where(p => p.CursoId == idCurso).ToList();
               
                    foreach (Docente_curso docentecurso in profedelcurso){

                    Persona unprofe = PersonaService.GetPersonaByLegajo(docentecurso.DocenteId);
                    if (unprofe != null) { profes.Add(unprofe); }
                    }
            }

            return profes;
            }
        }
    }

