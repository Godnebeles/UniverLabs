using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public enum UnitOfWeight
    {
        G,
        Kg
    }

    public struct Weight
    {
        public double Value { get; private set; }
        public UnitOfWeight Unit { get; private set; }

        public Weight(double weight, UnitOfWeight unit)
        {
            Value = weight;
            Unit = unit;
        }

        
    }
}
