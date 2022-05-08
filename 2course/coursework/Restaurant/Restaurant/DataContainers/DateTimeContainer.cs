using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public struct DateTimeContainer : IEquatable<DateTimeContainer>
    {
        public DateTime DateTime { get; private set; }

        public DateTimeContainer(int day, int mounth, int year)
        {
            DateTime = new DateTime(year, mounth, day);
        }

        public override int GetHashCode()
        {
            return this.DateTime.GetHashCode();
        }

        public bool Equals(DateTimeContainer other)
        {
            return this.DateTime.Day.Equals(other.DateTime.Day) &&
                   this.DateTime.Month.Equals(other.DateTime.Month) &&
                   this.DateTime.Year.Equals(other.DateTime.Year);
        }
    }
}
