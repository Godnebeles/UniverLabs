using System;

namespace Lab2_block2
{
    public class GoodStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine("Good Study...");
        }

        public override void Program()
        {
            Console.WriteLine("Good Program...");
        }

        public override void PlayFootball()
        {
            Console.WriteLine("Good Play Football...");
        }
    }
}
