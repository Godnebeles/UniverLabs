using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_block3
{
    public abstract class Vehicle
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Cost { get; set; }
        public float Speed { get; set; }
        public string CreationDate { get; set; }

        public Vehicle(float x, float y, float z, float cost, float speed, string creationDate)
        {
            X = x;
            Y = y;
            Z = z;
            Cost = cost;
            Speed = speed;
            CreationDate = creationDate;
        }

        public virtual void PrintInfo()
        {
            
            Console.WriteLine($"x: {X}; y: {Y}, z: {Z}");
            Console.WriteLine($"Cost: ${Cost}");
            Console.WriteLine($"Speed: {Speed}km/h");
            Console.WriteLine($"Creation Date: {CreationDate}");
            
        }
    }
}
