namespace sale_of_vehicles
{
    public class PassengerPlane : Plane
    {
        public PassengerPlane(string name, string model, double price, int numberOfSeats, FuelType fuelType, IFunctionality functionality) : 
                                base(name, model, price, numberOfSeats, fuelType, functionality)
        {

        }


    }
}
