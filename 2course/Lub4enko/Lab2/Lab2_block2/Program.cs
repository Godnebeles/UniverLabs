using System;

namespace Lab2_block2
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group(new GoodStudent(), new ExcellentStudent(),
                                    new GoodStudent(), new BadStudent());

            group.PrintInfo();

            Console.ReadKey();
        }
    }
}
