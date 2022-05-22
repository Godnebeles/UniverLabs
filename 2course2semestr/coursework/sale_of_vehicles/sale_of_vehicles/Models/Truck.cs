

using System;

namespace sale_of_vehicles
{
    public class Truck : Car
    {
        
        public Truck(string name, double price, int numberOfSeats, TypesOfFuel fuelType, double maxWeightOfCargo, TypeOfCargo cargoType) 
                    : base(name, price, numberOfSeats, fuelType)
        {
            MaxWeightOfCargo = maxWeightOfCargo;
            CargoType = cargoType;
        }
        public double MaxWeightOfCargo { get; private set; }
        public TypeOfCargo CargoType { get; private set; }

    }
}
