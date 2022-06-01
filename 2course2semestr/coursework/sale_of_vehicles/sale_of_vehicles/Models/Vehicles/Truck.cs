using System;

namespace sale_of_vehicles
{
    public class Truck : Car
    {
        
        public Truck(Guid id, string name, string model, double price, int numberOfSeats, FuelType fuelType, 
                    IFunctionality functionality, double maxWeightOfCargo, TypeOfCargo cargoType) 
                    : base(id, name, model,price, numberOfSeats, fuelType, functionality)
        {
            MaxWeightOfCargo = maxWeightOfCargo;
            CargoType = cargoType;
        }

        public double MaxWeightOfCargo { get; private set; }
        public TypeOfCargo CargoType { get; private set; }
    }
}
