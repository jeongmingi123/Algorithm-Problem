using System;

namespace baek2440
{
    class Program
    {

        static void PrintReverseRightTriangle(int num)
        {
            for (int i = num; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintReverseRightTriangle(num);
        }
    }
}
