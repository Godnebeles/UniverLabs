using System;

namespace sale_of_vehicles
{
    public class PassengerPlane : Plane
    {
        public PassengerPlane(Guid id, string name, string model, double price, int numberOfSeats, FuelType fuelType, IFunctionality functionality) :
                                base(id, name, model, price, numberOfSeats, fuelType, functionality)
        {

        }
    }
}
