using System;

namespace BLock2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTime time = new MyTime(10, 10, -10);
            Console.WriteLine(time);

            //Console.WriteLine($"Start time: {time}");
            //Console.WriteLine($"{time} is {time.WhatLesson()}");
            //MyTime backTime = new MyTime(-10);
            //Console.WriteLine($"backTime(-10sec): {backTime}");
            //time.AddSeconds(10);
            //Console.WriteLine($"time + 10 sec: {time}");

            //MyTime timeFromSec = new MyTime(61);
            //Console.WriteLine($"TimeFromSec: {timeFromSec}");

        }
    }
}
