using System;
using Xunit;

namespace Lab4.Tests
{
    public class MyComplexTests
    {
        private MyComplex complex1;
        private MyComplex complex2;

        public MyComplexTests()
        {
            complex1 = new MyComplex(1, 3);
            complex2 = new MyComplex(1, 6);
        }

        [Fact]
        public void Add__APlusBSquare()
        {
            MyComplex result1 = complex1.Add(complex2);
            result1 = result1.Multiply(result1);

            MyComplex temp = complex1.Multiply(complex2);
            temp = temp.Add(temp);

            MyComplex result2 = complex1.Multiply(complex1).Add(temp).Add(complex2.Multiply(complex2));

            Assert.Equal(result1.ToString(), result2.ToString());
        }

        [Fact]
        public void Substract__SquaresDifference()
        {
            MyComplex result1 = complex1.Substract(complex2);

            MyComplex result2 = (complex1.Multiply(complex1).Substract(complex2.Multiply(complex2))).Divide(complex1.Add(complex2));

            Assert.Equal(result1.ToString(), result2.ToString());
        }
    }
}
