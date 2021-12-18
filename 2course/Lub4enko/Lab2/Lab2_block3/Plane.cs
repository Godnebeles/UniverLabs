using System;

namespace Lab2_block3
{
    public class Plane : Vehicle
    {
        public int CountPassengers { get; set; }
        public float Height { get; set; }

        public Plane(float x, float y, float z, float cost, float speed, string creationDate,
                    int countPassengers, float height)
            : base(x, y, z, cost, speed, creationDate)
        {
            CountPassengers = countPassengers;
            Height = height;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Plane: ");
            base.PrintInfo();
            Console.WriteLine($"Height: {Height}km");
            Console.WriteLine($"Count passengers: {CountPassengers}");
        }
    }
}
