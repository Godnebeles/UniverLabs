using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public struct Weight
    {
        public double Value { get; private set; }

        public Weight(double weight)
        {
            Value = weight;
        }
    }
}
