using System.Collections.Generic;

namespace sale_of_vehicles
{
    public class CarShop
    {
        public List<Car> CarList { get; private set; }

        public CarShop(List<Car> cars)
        {
            CarList = cars;
        }

        public void AddCar(Car car)
        {
            CarList.Add(car);
        }

        public void RemoveCar(Car car)
        {
            CarList.Remove(car);
        }

        public List<Car> GetFiltered(FilterCarsDelegate[] filters)
        {
            List<Car> cars = new List<Car>();

            foreach(var car in CarList)
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


        public List<Car> GetBuses()
        {
            List<Car> buses = new List<Car>();

            foreach(var bus in CarList)
            {

            }

            return buses;
        }
    }
}
