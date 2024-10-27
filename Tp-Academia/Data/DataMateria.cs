using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataMateria
    {
        public List<Materia> GetMaterias()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var Materias = db.Materias.ToList(); ;

                return Materias;
            }
        }

        public Materia GetMateriaById(int id)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Materia mat = db.Materias.Find(id);
                return mat;
            }
        }

        public bool InsertMateria(Materia mat)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Materias.Add(mat);
                db.SaveChanges();
                // Verificar si esto puede fallar
                return true;
            }
        }

        public bool EliminarMateria(Materia mat)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Materias.Remove(mat);
                db.SaveChanges();
                return true;
            }
        }

        public bool ModificarMateria(Materia mat)
        {
            using (var context = new AcademiaContext())
            {
                Materia matOriginal = GetMateriaById(mat.Id);
                if (matOriginal != null)
                {

                    matOriginal.Descripcion = mat.Descripcion;
                    matOriginal.CantHorasSemanales = mat.CantHorasSemanales;
                    matOriginal.Nombre = mat.Nombre;
                    matOriginal.Anio = mat.Anio;
                    matOriginal.Plan = mat.Plan;


                    // Marca el estado de la entidad como modificado
                    context.Entry(matOriginal).State = EntityState.Modified;

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
