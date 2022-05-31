using System;

namespace sale_of_vehicles
{
    public class Bus : Car
    {
        public Bus(string name, string model, double price, int numberOfSeats, FuelType fuelType, int maxCapacityOfPeople, IFunctionality functionality)
                    : base(name,model, price, numberOfSeats, fuelType, functionality)
        {
            MaxCapacityOfPeople = maxCapacityOfPeople;
        }

        public int MaxCapacityOfPeople { get; private set; }
    }
}