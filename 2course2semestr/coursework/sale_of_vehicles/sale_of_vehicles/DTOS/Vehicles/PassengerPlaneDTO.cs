using System;

namespace sale_of_vehicles
{
    public class PassengerPlaneDTO
    {
        public PassengerPlaneDTO(Guid id, string name, string model, double price, int numberOfSeats, AviationFuel fuelType, PlaneFunctionality functionality)
        {
            Id = id;
            Name = name;
            Model = model;
            Price = price;
            NumberOfSeats = numberOfSeats;
            FuelType = fuelType;
            Functionality = functionality;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int NumberOfSeats { get; set; }
        public AviationFuel FuelType { get; set; }
        public PlaneFunctionality Functionality { get; set; }
    }
}