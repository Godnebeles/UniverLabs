using System;

namespace Lab2_block1
{
    class Program
    {
        static void Main(string[] args)
        {
            var crayon = new Crayon();
            Pencil pencil = crayon; // implicit cast

            crayon.Draw("Crayon");
            pencil.Draw("Pencil");

            Console.ReadKey();
        }
    }
}
