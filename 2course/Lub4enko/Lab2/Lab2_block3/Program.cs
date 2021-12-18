using System;

namespace Lab2_block3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(1,2,3,650000, 300,"22/02/2012");
            Vehicle ship = new Ship(1,2,3,650000, 300,"22/02/2012", 40, "Rich Port");
            Vehicle plane = new Plane(1,2,3,650000, 300,"22/02/2012", 55, 177);

            car.PrintInfo();
            Console.WriteLine("===========");
            ship.PrintInfo();
            Console.WriteLine("===========");
            plane.PrintInfo();

            Console.ReadKey();
        }
    }
}
