using System;
using System.Numerics;


namespace Lab4
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        private BigInteger _nom;
        private BigInteger _denom;

        public MyFrac(BigInteger nom, BigInteger denom)
        {
            if (denom == 0)
            {
                throw new DivideByZeroException();
            }

            BigInteger gcd = BigInteger.GreatestCommonDivisor(nom, denom);
            _nom = nom / gcd;
            _denom = denom / gcd;

            if (_denom.Sign < 0)
            {
                _nom *= -1;
                _denom *= -1;
            }

        }


        public MyFrac Add(MyFrac b)
        {
            return new MyFrac(_nom * b._denom + b._nom * _denom, _denom * b._denom);
        }


        public MyFrac Divide(MyFrac b)
        {
            if (b._nom == 0)
            {
                throw new DivideByZeroException();
            }

            return new MyFrac(_nom * b._denom, _denom * b._nom);
        }


        public MyFrac Multiply(MyFrac b)
        {
            return new MyFrac(_nom * b._nom, _denom * b._denom);
        }


        public MyFrac Substract(MyFrac b)
        {
            return new MyFrac(_nom * b._denom - _denom * b._nom, _denom * b._denom);
        }


        public override string ToString()
        {
            return _nom + "/" + _denom;
        }


        public int CompareTo(MyFrac other)
        {
            BigInteger value1 = _nom * other._denom;
            BigInteger value2 = other._nom * _denom;

            return value1.CompareTo(value2);
        }
    }
}
