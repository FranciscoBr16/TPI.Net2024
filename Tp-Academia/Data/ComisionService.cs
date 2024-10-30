using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ComisionService
    {
        public static List<Comision> GetComisiones()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var Comisiones = db.Comisiones.ToList(); ;

                return Comisiones;
            }
        }

        public static Comision GetComisionById(int id)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                return db.Comisiones.Find(id);
               
            }
        }

        public static bool InsertComision(Comision com)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Comisiones.Add(com);
                db.SaveChanges();
                return true;
            }
        }

        public static bool EliminarComision(Comision com)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Comisiones.Remove(com);
                db.SaveChanges();
                return true;
            }
        }

        public static bool ModificarComision(Comision com)
        {
            using (var context = new AcademiaContext())
            {
                Comision comOriginal = GetComisionById(com.Id);
                if (comOriginal != null) { 
             
                    comOriginal.Descripcion = com.Descripcion;
                    comOriginal.Turno = com.Turno;
                    

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
