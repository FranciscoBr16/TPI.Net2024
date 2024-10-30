using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Curso
    {

        public static bool ModificarCurso(Entidades.Curso per)
        {
            CursoService dc = new CursoService();
            return dc.ModificarCurso(per);
        }

        public static bool AgregarCurso(Entidades.Curso per)
        {
            CursoService dc = new CursoService();
            return dc.InsertCurso(per);
        }

        public static bool EliminarCurso(Entidades.Curso Curso)
        {
            CursoService dc = new CursoService();
            return dc.EliminarCurso(Curso);

        }

        public static Entidades.Curso GetCursoById(int id)
        {
            CursoService dc = new CursoService();
            return dc.GetCursoById(id);
        }

        public static List<Entidades.Curso> GetCursos()
        {
            CursoService dc = new CursoService();
            return dc.GetCursos();
        }

        public static bool InscripcionAlumnoCurso (int legajoAlumno , int idCurso) {

            CursoService dc = new CursoService();
            return dc.InscripcionAlumnoCurso(legajoAlumno, idCurso);
        }
    }
}
