using System;

namespace sale_of_vehicles
{
    public abstract class Car : IEquatable<Car>
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public int NumberOfSeats { get; protected set; }
        public TypesOfFuel FuelType { get; protected set; }

        protected Car(string name, double price, int numberOfSeats, TypesOfFuel fuelType)
        {
            if (name == "")
                throw new Exception("Incorrect car's name");

            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            NumberOfSeats = numberOfSeats;
            FuelType = fuelType;
        }

        public bool Equals(Car other)
        {
            if (other == null) return false;
            return Id.Equals(other.Id);
        }


        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
