using System;

namespace Lab2_block3
{
    public class Ship : Vehicle
    {
        public int CountPassengers { get; set; }
        public string Port { get; set; }

        public Ship(float x, float y, float z, float cost, float speed, string creationDate, 
                    int countPassengers, string port)
            : base(x, y, z, cost, speed, creationDate)
        {
            CountPassengers = countPassengers;
            Port = port;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Ship: ");
            base.PrintInfo();
            Console.WriteLine($"Port: {Port}");
            Console.WriteLine($"Count passengers: {CountPassengers}");
        }
    }
}
