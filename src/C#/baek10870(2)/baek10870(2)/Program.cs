using System;

namespace baek10870_2_
{
    class Program
    {
        static int GetFibonacciRecursive(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            if (num == 1)
            {
                return 1;
            }

            return GetFibonacciRecursive(num - 1) + GetFibonacciRecursive(num - 2);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciRecursive(num));
         }
    }
}
