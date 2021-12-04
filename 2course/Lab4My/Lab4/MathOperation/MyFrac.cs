using System;
using System.Numerics;

namespace MathOperation
{
    class MyFrac : IComparable<MyFrac>
    {
        private BigInteger nom;
        private BigInteger denom;
        private double result;

        public MyFrac(int nom, int denom) 
        {
            GCD(nom, denom);
        }

        
        public MyFrac(BigInteger nom, BigInteger denom)
        {
            BigInteger divisor = BigInteger.GreatestCommonDivisor(nom, denom);

            this.nom = nom / divisor;
            this.denom = denom / divisor;

            if (denom.Sign < 0)
            {
                this.nom *= -1;
                this.denom *= -1;
            }
        }


        public MyFrac Add(MyFrac that) 
        {
            return new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);
        }

        public MyFrac Divide(MyFrac obj)
        {
            if (obj.nom == 0)
                throw new DivideByZeroException();

            return new MyFrac(nom * obj.nom, denom * obj.denom);
        }

        public MyFrac Multiply(MyFrac obj)
        {
            return new MyFrac(nom * obj.nom, denom * obj.denom);
        }



        private void GCD(int nom, int denom)
        {
            int tempNom = Math.Abs(nom),
                 tempDenom = Math.Abs(denom);

            while (tempNom != 0 && tempDenom != 0)
            {
                if (tempNom > tempDenom)
                    tempNom %= tempDenom;
                else
                    tempDenom %= tempNom;
            }
            tempNom += tempDenom;
            tempDenom = tempNom;

            this.nom = nom / tempNom;
            this.denom = denom / tempDenom;

            if(denom < 0)
            {
                this.nom *= -1;
                this.denom *= -1;
            }
        }

        public  int CompareTo(MyFrac obj) 
        {
            BigInteger nom1 = nom * obj.denom;
            BigInteger nom2 = obj.nom * denom;

            return nom1.CompareTo(nom2);
        }
    }
}
