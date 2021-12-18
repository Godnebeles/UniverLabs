using Xunit;


namespace Lab4.Tests
{
    public class MyFracTests
    {
        private MyFrac frac1 = new MyFrac(1, 3);
        private MyFrac frac2 = new MyFrac(1, 6);

        [Fact]
        public void Add__APlusBSquare()
        {
            MyFrac result1 = frac1.Add(frac2);
            result1 = result1.Multiply(result1);

            MyFrac result2 = frac1.Multiply(frac1).Add(frac1.Multiply(frac2).Multiply(new MyFrac(2, 1))).Add(frac2.Multiply(frac2));

            Assert.Equal(result1.ToString(), result2.ToString());
        }

        [Fact]
        public void Substract__SquaresDifference()
        {
            MyFrac result1 = frac1.Substract(frac2);

            MyFrac result2 = (frac1.Multiply(frac1).Substract(frac2.Multiply(frac2))).Divide(frac1.Add(frac2));

            Assert.Equal(result1.ToString(), result2.ToString());
        }
    }
}
