using System;

namespace Task3
{
    public class Program
    {
        public delegate void Finder(int[] number);

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 7, 14, 15, 21, 30, 42};
            int[] arr2 = { 1, 2, 3, 7, 14, 15, 21, 30, 42, 63};

            Finder finder = FindDivider;
            
            finder(arr1);

            Console.WriteLine("-----------------------------");

            finder(arr2);
        }


        private static void FindDivider(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 3 == 0 && arr[i] % 7 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }            
        }
    }
}
