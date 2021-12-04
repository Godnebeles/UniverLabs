using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class MyComplex : IMyNumber<MyComplex>
    {
        private double _re;
        private double _im;

        public MyComplex(double re, double im)
        {
            _re = re;
            _im = im;
        }


        public MyComplex Add(MyComplex b)
        {
            return new MyComplex(_re + b._re, _im + b._im);
        }


        public MyComplex Divide(MyComplex b)
        {
            double div = b._im * b._im + b._re * b._re;
            if (div == 0)
            {
                throw new DivideByZeroException();
            }
            return new MyComplex((_re * b._re + _im * b._im) / div, (_im * b._re - _re * b._im) / div);
        }


        public MyComplex Multiply(MyComplex b)
        {
            return new MyComplex(_re * b._re - _im * b._im, _re * b._im + _im * b._re);
        }


        public MyComplex Substract(MyComplex b)
        {
            return new MyComplex(_re - b._re, _im - b._im);
        }
        

        public override string ToString()
        {
            return _im < 0? $"{_re}{_im}i":$"{_re}+{_im}i";
        }
    }
}
