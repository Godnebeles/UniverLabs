namespace sale_of_vehicles
{ 
    public class TransportPlane : Plane
    {
        public TransportPlane(string name, double price, int numberOfSeats, FuelType fuelType, IFunctionality functionality) 
                              : base(name, price, numberOfSeats, fuelType, functionality)
        {

        }
    }
}
