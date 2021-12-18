using System;

namespace Lab4
{
    interface IMyNumber<T> where T : IMyNumber<T>
    {
        T Add(T b);
        T Substract(T b);
        T Multiply(T b);
        T Divide(T b);
        public void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
