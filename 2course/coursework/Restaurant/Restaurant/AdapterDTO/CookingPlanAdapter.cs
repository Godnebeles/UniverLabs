using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class CookingPlanAdapter : IAdapter<CookingPlan, CookingPlanDTO>
    {
        public CookingPlanDTO ConvertToDTO(CookingPlan model)
        {
            throw new NotImplementedException();
        }

        public CookingPlan ConvertToModel(CookingPlanDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
