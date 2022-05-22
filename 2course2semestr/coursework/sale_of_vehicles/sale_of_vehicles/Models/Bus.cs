using System;

namespace sale_of_vehicles
{
    public class Bus : Car
    {
        public Bus(string name, double price, int numberOfSeats, TypesOfFuel fuelType, int maxCapacityOfPeople)
                    : base(name, price, numberOfSeats, fuelType)
        {
            MaxCapacityOfPeople = maxCapacityOfPeople;
        }

        public int MaxCapacityOfPeople { get; private set; }
    }
}