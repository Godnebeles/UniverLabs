using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public struct DateTimeContainer
    {
        public DateTime DateTime { get; private set; }

        public DateTimeContainer(int minutes, int hours, int day, int mounth, int year)
        {
            DateTime = new DateTime(year, mounth, day, hours, minutes, 0);
        }

    }
}
