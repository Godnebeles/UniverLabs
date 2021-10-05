using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_block2
{
    class TCircle
    {
        public double radius { get; set; }

        public TCircle()
        {
            radius = 10.0;
        }

        public TCircle(double radius)
        {
            this.radius = radius;
        }      

        public virtual double CircleArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public virtual double CircleLength()
        {
            return 2 * Math.PI * radius;
        }

        public virtual double CircleSectorArea(double angle)
        {
            return (Math.PI * Math.Pow(radius, 2) * angle) / 360;
        }

        public static bool operator true(TCircle obj1)
        {
            return obj1.radius > 0;
        }

        public static bool operator false(TCircle obj1)
        {
            return obj1.radius <= 0;
        }

        //overides
        public static bool operator !=(TCircle obj1, TCircle obj2)
        {
            return !(obj1.radius == obj2.radius);
        }

        public static bool operator ==(TCircle obj1, TCircle obj2)
        {
            return obj1.radius == obj2.radius;
        }

        public static TCircle operator +(TCircle obj1, TCircle obj2)
        {
            return new TCircle { radius = obj1.radius + obj2.radius };
        }

        public static TCircle operator -(TCircle obj1, TCircle obj2)
        {
            return new TCircle { radius = Math.Abs(obj1.radius - obj2.radius) };
        }

        public static TCircle operator *(TCircle obj1, double value)
        {
            return new TCircle { radius = obj1.radius * value };
        }

        public static TCircle operator *(double value, TCircle obj1)
        {
            return new TCircle { radius = obj1.radius * value };
        }

        public static TCircle operator *(TCircle obj1, TCircle obj2)
        {
            return new TCircle { radius = obj1.radius * obj2.radius };
        }

        override public string ToString()
        {
            return "Radius = " + radius;
        }
    }
}
