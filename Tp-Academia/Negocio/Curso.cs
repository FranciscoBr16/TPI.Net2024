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
            DataCurso dc = new DataCurso();
            return dc.ModificarCurso(per);
        }

        public static bool AgregarCurso(Entidades.Curso per)
        {
            DataCurso dc = new DataCurso();
            return dc.InsertCurso(per);
        }

        public static bool EliminarCurso(Entidades.Curso Curso)
        {
            DataCurso dc = new DataCurso();
            return dc.EliminarCurso(Curso);

        }

        public static Entidades.Curso GetCursoById(int id)
        {
            DataCurso dc = new DataCurso();
            return dc.GetCursoById(id);
        }

        public static List<Entidades.Curso> GetCursos()
        {
            DataCurso dc = new DataCurso();
            return dc.GetCursos();
        }

        public static bool InscripcionAlumnoCurso (int legajoAlumno , int idCurso) {

            DataCurso dc = new DataCurso();
            return dc.InscripcionAlumnoCurso(legajoAlumno, idCurso);
        }
    }
}
