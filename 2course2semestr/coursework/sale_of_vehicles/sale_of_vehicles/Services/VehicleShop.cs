using System.Collections.Generic;

namespace sale_of_vehicles
{
    public class VehiclesShop
    {
        public List<Vehicle> VehicleList { get; private set; }

        public VehiclesShop(List<Vehicle> cars)
        {
            VehicleList = cars;
        }

        public void AddCar(Vehicle car)
        {
            VehicleList.Add(car);
        }

        public void RemoveCar(Vehicle car)
        {
            VehicleList.Remove(car);
        }

        public List<Vehicle> GetFiltered(FilterCarsDelegate[] filters)
        {
            List<Vehicle> cars = new List<Vehicle>();

            foreach(var car in VehicleList)
            {
                foreach(var filter in filters)
                {
                    if(filter(car))
                    {
                        cars.Add(car);
                    }
                }
            }

            return cars;
        }


        public List<Bus> GetBuses()
        {
            List<Bus> buses = new List<Bus>();

            foreach(var vehicle in VehicleList)
            {
                if(vehicle is Bus)
                {
                    buses.Add((Bus)vehicle);
                }
            }

            return buses;
        }


        public List<Truck> GetTrucks()
        {
            List<Truck> truck = new List<Truck>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle is Truck)
                {
                    truck.Add((Truck)vehicle);
                }
            }

            return truck;
        }

    }

}
