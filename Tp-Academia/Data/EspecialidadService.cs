using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EspecialidadService
    {
        public List<Especialidad> GetEspecialidades()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var esp = db.Especialidades.ToList();

                return esp;
            }
        }

        public Especialidad GetEspecialidadById(int id)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Especialidad e = db.Especialidades.Find(id);
                return e;
            }
        }

        public bool InsertEspecialidad(Especialidad esp)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Especialidades.Add(esp);
                db.SaveChanges();
                // Verificar si esto puede fallar
                return true;
            }
        }

        public bool EliminarEspecialidad(Especialidad esp)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Especialidades.Remove(esp);
                db.SaveChanges();
                return true;
            }
        }

        public bool ModificarEspecialidad(Especialidad esp)
        {
            using (var context = new AcademiaContext())
            {
                Especialidad espOriginal = GetEspecialidadById(esp.Id);
                if (espOriginal != null)
                {
                    espOriginal.Descripcion = esp.Descripcion;
                    // por ahora solo se podra modificar la descripcion


                    // Marca el estado de la entidad como modificado
                    context.Entry(espOriginal).State = EntityState.Modified;

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
