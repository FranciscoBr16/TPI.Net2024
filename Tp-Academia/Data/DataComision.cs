using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataComision
    {
        public List<Comision> GetComisiones()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var Comisiones = db.Comisiones.ToList(); ;

                return Comisiones;
            }
        }

        public Comision GetComisionById(int id)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Comision c = db.Comisiones.Find(id);
                return c;
            }
        }

        public bool InsertComision(Comision com)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Comisiones.Add(com);
                db.SaveChanges();
                // Verificar si esto puede fallar
                return true;
            }
        }

        public bool EliminarComision(Comision com)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Comisiones.Remove(com);
                db.SaveChanges();
                return true;
            }
        }

        public bool ModificarComision(Comision com)
        {
            using (var context = new AcademiaContext())
            {
                Comision comOriginal = GetComisionById(com.Id);
                if (comOriginal != null) { 
             
                    comOriginal.Descripcion = com.Descripcion;
                    comOriginal.Turno = com.Turno;
                    

                    // Marca el estado de la entidad como modificado
                    context.Entry(comOriginal).State = EntityState.Modified;

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
