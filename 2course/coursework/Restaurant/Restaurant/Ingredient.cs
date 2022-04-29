using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Ingredient : Budget
    {
        public string Name { get; private set; }
        public Weight Weight { get; private set; }
        public override double Price { get;  set; }

        public Ingredient(string name, double price) : base(price)
        {
            Name = name;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
        
        public override string ToString()
        {
            return "Name: " + Name + " | Price: " + Price;
        }
    }
}
