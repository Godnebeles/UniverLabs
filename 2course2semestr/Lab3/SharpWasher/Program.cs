using System;

namespace SharpWasher
{
    public delegate void CarWasherDelegate(Car car);
    public class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            CarWasher carWasher = new CarWasher();
            CarWasherDelegate carWasherDelegate = new CarWasherDelegate(carWasher.Wash);

            garage.AddCar(new Car("Lamborgini"));
            garage.AddCar(new Car("Ferrari"));
            garage.AddCar(new Car("Strange Machina"));
            garage.AddCar(new Car("Imba Machina"));     

            foreach(var car in garage.Cars)
            {
                carWasherDelegate(car);
            }

        }
    }
}
