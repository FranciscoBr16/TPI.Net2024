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
            DataPlan dp = new DataPlan();
            return dp.ModificarPlan(plan);
        }

        public static bool AgregarPlan(Entidades.Plan plan)
        {
            DataPlan dp = new DataPlan();
            return dp.InsertPlan(plan);
        }

        public static bool EliminarPlan(Entidades.Plan Plan)
        {
            DataPlan dp = new DataPlan();
            return dp.EliminarPlan(Plan);

        }

        public static Entidades.Plan GetPlanById(int id)
        {
            DataPlan dp = new DataPlan();
            return dp.GetPlanById(id);
        }

        public static List<Entidades.Plan> GetPlanes()
        {
            DataPlan dp = new DataPlan();
            return dp.GetPlanes();
        }
    }
}
