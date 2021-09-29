using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_block2
{
    class TSphere : TCircle
    {
        public TSphere()
        {
            radius = 10;
        }

        public TSphere(double radius)
        {
            this.radius = radius;
        }

        public double VolumeBall()
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        }

        public override double CircleArea()
        {
            return 2 * Math.PI * Math.Pow( radius, 2) * radius;
        }

        //Площадь поверхности шара равна четырем его радиусам в 
        //    квадрате умноженным на число π.Площадь поверхности 
        //    шара равна квадрату его диаметра умноженного на число π.
        public override double CircleLength()
        {
            return Math.PI * Math.Pow(radius * 4, 2);
        }

        public override double CircleSectorArea(double angle)
        {
            return (4 * Math.PI * Math.Pow(radius, 2) * angle) / 360;
        }

        public static TSphere operator +(TSphere obj1, TSphere obj2)
        {
            return new TSphere { radius = obj1.radius + obj2.radius };
        }

    }
}
