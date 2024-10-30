using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Plan
    {
        public static bool ModificarPlan(Entidades.Plan plan)
        {
            PlanService dp = new PlanService();
            return dp.ModificarPlan(plan);
        }

        public static bool AgregarPlan(Entidades.Plan plan)
        {
            PlanService dp = new PlanService();
            return dp.InsertPlan(plan);
        }

        public static bool EliminarPlan(Entidades.Plan Plan)
        {
            PlanService dp = new PlanService();
            return dp.EliminarPlan(Plan);

        }

        public static Entidades.Plan GetPlanById(int id)
        {
            PlanService dp = new PlanService();
            return dp.GetPlanById(id);
        }

        public static List<Entidades.Plan> GetPlanes()
        {
            PlanService dp = new PlanService();
            return dp.GetPlanes();
        }
    }
}
