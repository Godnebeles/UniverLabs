using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class StorageAdapter : IAdapter<Storage, StorageDTO>
    {
        public StorageDTO ConvertToDTO(Storage model)
        {
            IAdapter<Ingredient, IngredientDTO> dishAdapter = new IngredientAdapter();
            IAdapter<Weight, WeightDTO> weightAdapter = new WeightAdapter();

            StorageDTO storageDTO = new StorageDTO();

            foreach (var item in model.Ingredients)
            {
                storageDTO.Ingredients.Add(dishAdapter.ConvertToDTO(item.Key), weightAdapter.ConvertToDTO(item.Value));
            }

            return storageDTO;
        }

        public Storage ConvertToModel(StorageDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
