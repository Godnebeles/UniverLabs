namespace sale_of_vehicles
{
    public class Plane : Vehicle
    {
        public Plane(string name,  string model, double price, int numberOfSeats, FuelType fuelType, IFunctionality functionality) 
                     : base(name, model, price, numberOfSeats, fuelType, functionality)
        {

        }

        public override bool CheckFunctionality()
        {
            return Functionality.IsNormalFunctionality();
        }
    }
}
