using System;

namespace MyTimer
{
    public delegate void FixedUpdate(int value);

    public class Program
    {
        static void Main(string[] args)
        {
            MyTimer myTimer = new MyTimer(5000);

            myTimer.fixedUpdate += PrintDestoys;

            myTimer.Start();
        }

        public static void PrintDestoys(int count)
        {
            Console.WriteLine(count + " Asteroids destroyed!");
        } 
    }

    
}
