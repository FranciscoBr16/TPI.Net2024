﻿using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataPlan
    {
        public List<Plan> GetPlanes()
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                var planes = db.Planes.ToList();

                return planes;
            }
        }

        public Plan GetPlanById(int id)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                Plan p = db.Planes.Find(id);
                return p;
            }
        }

        public bool InsertPlan(Plan plan)
        {
            using (AcademiaContext db = new AcademiaContext())
            {

                db.Planes.Add(plan);
                db.SaveChanges();
                // Verificar si esto puede fallar
                return true;
            }
        }

        public bool EliminarPlan(Plan plan)
        {
            using (AcademiaContext db = new AcademiaContext())
            {
                db.Planes.Remove(plan);
                db.SaveChanges();
                return true;
            }
        }

        public bool ModificarPlan(Plan plan)
        {
            using (var context = new AcademiaContext())
            {
                Plan planOriginal = GetPlanById(plan.Id);
                if (planOriginal != null)
                {
                    planOriginal.Descripcion = plan.Descripcion;
                    // por ahora solo se podra modificar la descripcion
                    

                    // Marca el estado de la entidad como modificado
                    context.Entry(planOriginal).State = EntityState.Modified;

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
