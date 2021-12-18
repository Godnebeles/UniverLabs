using System;

namespace Lab2_block2
{
    public class BadStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine("Bad Study...");
        }

        public override void Program()
        {
            Console.WriteLine("Bad Program...");
        }

        public override void PlayFootball()
        {
            Console.WriteLine("Bad Play Football...");
        }
    }
}
