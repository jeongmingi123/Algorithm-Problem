using System;

namespace baek2438_2_
{
    class Program
    {
        static void DrawRightTriangle(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            DrawRightTriangle(num);
        }
    }
}
