using System;

namespace codeup1902
{
    class Program
    {
        static void PrintNumber(int end, int start) // end에서 1까지 출력하는 함수
        {
            if (end == start)
            {
                Console.WriteLine($"{end}");
                return;
            }
            Console.WriteLine($"{end}");
            PrintNumber(end - 1, start);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintNumber(num, 1);
        }
    }
}
