using System;
using System.Collections.Generic;

namespace sale_of_vehicles
{
    public class VehiclesShop
    {
        private List<Vehicle> _vehicleList;     

        public VehiclesShop(List<Vehicle> cars)
        {
            if (cars == null)
                throw new Exception("Car list can't be a null");

            _vehicleList = cars;
        }

        public List<Vehicle> VehicleList
        {
            get
            {
                return _vehicleList;
            }
            private set
            {
                _vehicleList = value;
            }
        }

        public void AddVehicle(Vehicle car)
        {
            VehicleList.Add(car);
        }

        public void RemoveVehicle(Vehicle car)
        {
            VehicleList.Remove(car);
        }

        public List<Bus> GetBuses()
        {
            List<Bus> buses = new List<Bus>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle.CheckFunctionality() && vehicle is Bus)
                {
                    buses.Add((Bus)vehicle);
                }
            }

            return buses;
        }

        public List<Plane> GetPlanes()
        {
            List<Plane> buses = new List<Plane>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle.CheckFunctionality() && vehicle is Plane)
                {
                    buses.Add((Plane)vehicle);
                }
            }

            return buses;
        }

        public List<Truck> GetTrucks()
        {
            List<Truck> truck = new List<Truck>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle.CheckFunctionality() && vehicle is Truck)
                {
                    truck.Add((Truck)vehicle);
                }
            }

            return truck;
        }

    }

}
