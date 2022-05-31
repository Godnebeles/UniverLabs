

namespace sale_of_vehicles
{
    public class Truck : Car
    {
        
        public Truck(string name, string model, double price, int numberOfSeats, FuelType fuelType, double maxWeightOfCargo, 
                        TypeOfCargo cargoType, IFunctionality functionality) 
                    : base(name, model,price, numberOfSeats, fuelType, functionality)
        {
            MaxWeightOfCargo = maxWeightOfCargo;
            CargoType = cargoType;
        }

        public double MaxWeightOfCargo { get; private set; }
        public TypeOfCargo CargoType { get; private set; }
    }
}
