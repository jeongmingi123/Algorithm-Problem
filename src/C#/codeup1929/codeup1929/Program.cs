using System;

namespace codeup1929
{
    class Program
    {
        static void PrintReverseHails(int num)
        {
            if (num == 1)
            {
                return;
            }

            if (num % 2 == 0)
            {
                PrintReverseHails(num / 2);
                Console.WriteLine(num / 2);
            }

            if (num % 2 != 0)
            {
                PrintReverseHails(3 * num + 1);
                Console.WriteLine(3 * num + 1);
            }

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintReverseHails(num);
            Console.WriteLine(num);
        }
    }
}
