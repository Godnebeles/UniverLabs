using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Block2
{
    class TCircle
    {
        public double radius
        {
            get
            {

                return radius;
            }
            set
            {
                if (radius < 0)
                {
                    throw new Exception("Радіус не може бути менше нуля");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public TCircle()
        {
            radius = 10;
        }

        public TCircle(double radius)
        {
            this.radius = radius;
        }
        public TCircle(TCircle obj)
        {
            radius = obj.radius;
        }

        public double CircleArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double CircleLength()
        {
            return 2 * Math.PI * radius;
        }

        //Operators
        public static bool operator ==(TCircle obj1, TCircle obj2)
        {
            if (obj1.radius == obj2.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(TCircle obj1, TCircle obj2)
        {
            if (obj1.radius != obj2.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static TCircle operator +(TCircle obj1, TCircle obj2)
        {
            return new TCircle { radius = obj1.radius + obj2.radius };
        }

        public static TCircle operator -(TCircle obj1, TCircle obj2)
        {
            return new TCircle { radius = obj1.radius - obj2.radius };
        }

        public static TCircle operator *(TCircle obj1, double number)
        {
            return new TCircle { radius = obj1.radius * number };
        }

        public static TCircle operator *(double number, TCircle obj1)
        {
            return new TCircle { radius = obj1.radius * number };
        }
    }
}
