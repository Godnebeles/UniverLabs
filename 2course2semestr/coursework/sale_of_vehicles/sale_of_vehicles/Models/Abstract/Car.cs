using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sale_of_vehicles
{
    public class Car : Vehicle
    {
        public Car(string name, double price, int numberOfSeats, FuelType fuelType, IFunctionality functionality) 
                   : base(name, price, numberOfSeats, fuelType, functionality)
        {

        }


        public string Model { get; private set; } = string.Empty;

        public override bool CheckFunctionality()
        {
            return Functionality.IsNormalFunctionality();
        }
    }
}
