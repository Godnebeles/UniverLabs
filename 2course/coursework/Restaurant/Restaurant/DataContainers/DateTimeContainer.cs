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

        public DateTimeContainer(int day, int mounth, int year)
        {
            DateTime = new DateTime(year, mounth, day);
        }

        public override bool Equals(object obj)
        {
            var otherContainer = (DateTimeContainer)obj;

            return this.DateTime.Day.Equals(otherContainer.DateTime.Day) &&
                   this.DateTime.Month.Equals(otherContainer.DateTime.Month) &&
                   this.DateTime.Year.Equals(otherContainer.DateTime.Year);
        }

        public override int GetHashCode()
        {
            return this.DateTime.GetHashCode();
        }
    }
}
