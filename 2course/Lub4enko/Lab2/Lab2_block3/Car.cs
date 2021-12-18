using System;

namespace Lab2_block3
{
    public class Car : Vehicle
    {
        public Car(float x, float y, float z, float cost, float speed, string creationDate) 
            : base(x, y, z, cost, speed, creationDate)
        {

        }

        public override void PrintInfo()
        {
            Console.WriteLine("Car: ");
            base.PrintInfo();
        }
    }
}
