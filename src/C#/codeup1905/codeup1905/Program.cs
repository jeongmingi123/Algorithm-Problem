using System;

namespace codeup1905
{
    class Program
    {
        static int SumRecursive(int start, int end)
        {
            if (start == end)
            {
                return start;
            }

            return start + SumRecursive(start + 1, end);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = SumRecursive(1, num);
            Console.WriteLine(total);
        }
    }
}
