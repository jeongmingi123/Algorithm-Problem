using System;

namespace baek2439
{
    class Program
    {

        static void DrawReverseRightTriangle(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (i + j >= num + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
             
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            DrawReverseRightTriangle(num);
        }
    }
}
