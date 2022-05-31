namespace sale_of_vehicles
{ 
    public class TransportPlane : Plane
    {
        public TransportPlane(string name, string model, double price, int numberOfSeats, FuelType fuelType, IFunctionality functionality) 
                              : base(name, model, price, numberOfSeats, fuelType, functionality)
        {

        }
    }
}
