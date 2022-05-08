using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class DataLoader
    {
        private string _pathToCookingList = "";
        private string _pathToStorageIngredients = "";
        private string _pathToDishesInMenu = "";

        public DataLoader(string pathToCookingList, string pathToStorageIngredients, string pathToDishesWhatCanCook)
        {
            _pathToCookingList = pathToCookingList;
            _pathToStorageIngredients = pathToStorageIngredients;
            _pathToDishesInMenu = pathToDishesWhatCanCook;
        }
        
        public CookingPlan LoadCookingPlan()
        {
            IAdapter<CookingPlan, CookingPlanDTO> adapter = new CookingPlanAdapter();
            Serializator<CookingPlanDTO> serializator = new Serializator<CookingPlanDTO>(_pathToCookingList);

            CookingPlanDTO cookingPlanDTO = serializator.Deserialize();

            return adapter.ConvertToModel(cookingPlanDTO);
        }


        
    }
}
