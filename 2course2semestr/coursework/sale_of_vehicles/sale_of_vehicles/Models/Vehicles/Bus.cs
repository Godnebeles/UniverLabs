using System;

namespace sale_of_vehicles
{
    public class Bus : Car
    {
        public Bus(Guid id, string name, string model, double price, int numberOfSeats, FuelType fuelType, IFunctionality functionality, int maxCapacityOfPeople)
                    : base(id, name, model, price, numberOfSeats, fuelType, functionality)
        {
            MaxCapacityOfPeople = maxCapacityOfPeople;
        }

        public int MaxCapacityOfPeople { get; private set; }
    }
}