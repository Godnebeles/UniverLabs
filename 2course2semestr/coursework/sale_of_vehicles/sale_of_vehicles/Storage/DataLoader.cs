using System.Collections.Generic;

namespace sale_of_vehicles
{
    public class DataLoader : IDataLoader
    {
        private string _pathFuelList = "";
        private string _pathToVehicleStorage = "";

        public DataLoader(string pathFuelList, string pathToVehicle)
        {
            _pathFuelList = pathFuelList;
            _pathToVehicleStorage = pathToVehicle;
        }

        public List<FuelType> LoadFuelData()
        {
            return new List<FuelType>() 
            {
                new CarFuel("Diesel"),
                new CarFuel("Gasoline"),
                new CarFuel("Electricity"),
                new AviationFuel("Gasoline"),
                new AviationFuel("Jet Fuel"),
            };
        }

        public List<Vehicle> LoadVehiclesData()
        {
            try
            {
                List<Vehicle> vehicles = new List<Vehicle>();
                Serializator<VehicleStorageDTO> serializator = new Serializator<VehicleStorageDTO>(_pathToVehicleStorage);
                VehicleStorageDTO vehicleStorage = serializator.Deserialize();

                IDataConvertor<Bus, BusDTO> busAdapter = new BusDataConvertor();
                IDataConvertor<Truck, TruckDTO> truckAdapter = new TruckDataConvertor();
                IDataConvertor<PassengerPlane, PassengerPlaneDTO> passengerPlaneAdapter = new PassengerDataConvertor();
                IDataConvertor<TransportPlane, TransportPlaneDTO> transportPlaneAdapter = new TransportDataConvertor();

                foreach (var bus in vehicleStorage.Buses)
                {
                    vehicles.Add(busAdapter.ConvertToModel(bus));
                }

                foreach (var truck in vehicleStorage.Trucks)
                {
                    vehicles.Add(truckAdapter.ConvertToModel(truck));
                }

                foreach (var plane in vehicleStorage.PassengerPlanes)
                {
                    vehicles.Add(passengerPlaneAdapter.ConvertToModel(plane));
                }

                foreach (var plane in vehicleStorage.TransportPlanes)
                {
                    vehicles.Add(transportPlaneAdapter.ConvertToModel(plane));
                }

                return vehicles;
            }
            catch (System.Exception)
            {
                return new List<Vehicle>();
            }
        }

        public void SaveFuelData(List<FuelType> fuelTypes)
        {
            throw new System.NotImplementedException();
        }

        public void SaveVehiclesData(List<Vehicle> vehicles)
        {            
            VehicleStorageDTO vehicleStorage = new VehicleStorageDTO();

            foreach (var vehicle in vehicles)
            {
                vehicleStorage.AddVehicle(vehicle);
            }

            Serializator<VehicleStorageDTO> serializator = new Serializator<VehicleStorageDTO>(_pathToVehicleStorage);

            serializator.Serialize(vehicleStorage);
        }
    }
}
