using System;

namespace baek2420
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            long num1 = int.Parse(s[0]);
            long num2 = int.Parse(s[1]);

            Console.WriteLine(Math.Abs(num1 - num2));
        }
    }
}
