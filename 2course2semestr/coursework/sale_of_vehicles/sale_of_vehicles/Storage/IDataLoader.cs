using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sale_of_vehicles
{
    public interface IDataLoader
    {
        void SaveFuelData(List<FuelType> fuelTypes);
        List<FuelType> LoadFuelData();

        void SaveVehiclesData(List<Vehicle> vehicles);
        List<Vehicle> LoadVehiclesData(); 

    }
}
