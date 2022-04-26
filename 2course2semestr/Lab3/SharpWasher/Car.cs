using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    public class Car
    {
        public string Name { get; private set; }

        public Car(string name)
        {
            Name = name;
        }
    }
}
