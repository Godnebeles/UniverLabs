using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sale_of_vehicles.Models
{
    internal class PassengerPlane : Plane
    {
        public PassengerPlane(string name, double price, int numberOfSeats, TypesOfFuel fuelType) : base(name, price, numberOfSeats, fuelType)
        {
        }
    }
}
