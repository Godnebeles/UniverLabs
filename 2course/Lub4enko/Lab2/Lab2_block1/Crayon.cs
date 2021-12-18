using System;

namespace Lab2_block1
{
    public class Crayon : Pencil
    {
        public new void Draw(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(text);

            Console.ResetColor();
        }
    }
}
