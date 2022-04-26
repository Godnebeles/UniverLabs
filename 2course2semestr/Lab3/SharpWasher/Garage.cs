using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    public class Garage
    {
        public List<Car> Cars { get; private set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
    }
}
