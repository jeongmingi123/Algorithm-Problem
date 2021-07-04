using System;

namespace codeup1928
{
    class Program
    {

        static void PrintHailNumbersRecursive(int num)
        {
            if (num == 1)
            {
                return;
            }

            else if (num % 2 != 0)
            {
                Console.WriteLine($"{num * 3 + 1}");
                PrintHailNumbersRecursive(num * 3 + 1);
            }

            else if (num % 2 == 0)
            {
                Console.WriteLine($"{num / 2}");
                PrintHailNumbersRecursive(num / 2);
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintHailNumbersRecursive(num);
        }
    }
}
