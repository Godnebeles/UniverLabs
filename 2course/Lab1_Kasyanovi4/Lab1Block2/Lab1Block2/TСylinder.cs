using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Block2
{
    class TСylinder : TCircle
    {
        public double height
        {
            get
            {
                return height;
            }
            set
            {
                if (height < 0)
                {
                    throw new Exception("Висота не може бути менше нуля");
                }
                else
                {
                    height = value;
                }
            }
        }


        public TСylinder()
        {
            radius = 10;
            height = 10;
        }

        public TСylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;

            if (radius > 0 && height > 0)
            {
                this.radius = radius;
                this.height = height;
            }
            else
            {
                throw new Exception("Висота або радіус не можуть бути менші або рівні нулю");
            }
        }
        public TСylinder(TСylinder obj)
        {
            radius = obj.radius;
        }

        public double CylindreVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        public static bool operator ==(TСylinder obj1, TСylinder obj2)
        {
            if (obj1.radius == obj2.radius && obj1.height == obj2.height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(TСylinder obj1, TСylinder obj2)
        {
            if (obj1.radius != obj2.radius && obj1.height != obj2.height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static TСylinder operator +(TСylinder obj1, TСylinder obj2)
        {
            return new TСylinder { radius = obj1.radius + obj2.radius, height = obj1.height + obj2.height };
        }

        public static TСylinder operator -(TСylinder obj1, TСylinder obj2)
        {
            return new TСylinder { radius = obj1.radius - obj2.radius, height = obj1.height - obj2.height };
        }

        public static TСylinder operator *(TСylinder obj1, double number)
        {
            return new TСylinder { radius = obj1.radius * number, height = obj1.height * number };
        }

        public static TСylinder operator *(double number, TСylinder obj1)
        {
            return new TСylinder { radius = obj1.radius * number, height = obj1.height * number };
        }
    }
}
