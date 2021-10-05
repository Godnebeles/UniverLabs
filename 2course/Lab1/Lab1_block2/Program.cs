using System;

namespace Lab1_block2
{
    class Program
    {
        static void Main(string[] args)
        {
            TCircle circle1 = new TCircle(15);
            TCircle circle2 = new TCircle(25);

            TSphere sphere1 = new TSphere(17);
            TSphere sphere2 = new TSphere(27);

            Console.WriteLine($"Площа круга = {circle1.CircleArea()}");
            Console.WriteLine($"Длинна круга = {circle1.CircleLength()}");
            Console.WriteLine($"Площа сектора круга = {circle1.CircleSectorArea(40)}");

            Console.WriteLine($"Площа сферичного сегмента = {sphere1.CircleArea()}");
            Console.WriteLine($"Длинна сферичного сегмента = {sphere1.CircleLength()}");
            Console.WriteLine($"Площа сектора сферичного сегмента = {sphere1.CircleSectorArea(40)}");
            Console.WriteLine($"Площа сферичного сегмента = {sphere1.VolumeBall()}");

            Console.WriteLine($"Сравнение двух кругов {circle1.radius} == {circle2.radius} -> { circle1 == circle2}");
            Console.WriteLine($"Сравнение двух сфер {sphere1.radius} == {sphere2.radius} -> { sphere1 == sphere2}");

            Console.WriteLine($"Сума двух кругов {circle1.radius} + {circle2.radius} -> { circle1 + circle2 }");
            Console.WriteLine($"Сума двух сфер {sphere1.radius} + {sphere2.radius} -> { sphere1 + sphere2 }");

            Console.WriteLine($"Разница двух кругов {circle1.radius} - {circle2.radius} -> { circle1 - circle2 }");
            Console.WriteLine($"Разница двух сфер {sphere1.radius} - {sphere2.radius} -> { sphere1 - sphere2 }");

            Console.WriteLine($"Умножение двух кругов {circle1.radius} * {circle2.radius} -> { circle1 * circle2 }");
            Console.WriteLine($"Умножение двух сфер {sphere1.radius} * {sphere2.radius} -> { sphere1 * sphere2 }");

            Console.WriteLine($"Умножение число * круг {2} * {circle2.radius} -> { 2 * circle2 }");
            Console.WriteLine($"Умножение число * сфера {2} * {sphere2.radius} -> { 2 * sphere2 }");

            Console.WriteLine($"Умножение круг * число {circle1.radius} * {2} -> { circle1 * 2 }");
            Console.WriteLine($"Умножение сфера * число {sphere1.radius} * {2} -> { sphere1 * 2 }");

            circle1 += circle2;

            //sphere1 += sphere2;
            Console.ReadKey();
        }
    }
}
