using System;

namespace Lab1_block1
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaEquation equation = new AreaEquation(3, 4, 2, 2);
            
            Console.WriteLine(equation.PrintDecussationPoint("x"));
            Console.WriteLine(equation.PrintDecussationPoint("y"));
            Console.WriteLine(equation.PrintDecussationPoint("z"));
            Console.WriteLine($"\nAx={equation[0]}, By={equation[1]}, Cz={equation[0]}, D={equation[3]}" );

            equation[0] = 5;

            equation.Output();
            equation.Input();
            equation.Output();
            
            // AreaEquation equation1 = new AreaEquation(0, 0, 0, 0);

            Console.ReadKey();
        }
    }
}
