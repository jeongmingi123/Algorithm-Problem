using System;

namespace codeup1904
{
    class Program
    {
        static void PrintOddNumber(int start, int end)
        {
            if (start == end && start % 2 != 0)
            {
                Console.Write($"{start} ");
                return;
            }

            if (start == end && start % 2 == 0)
            {
                return;
            }

            if (start % 2 != 0)
            {
                Console.Write($"{start} ");
            }

            PrintOddNumber(start + 1, end);

        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);

            PrintOddNumber(a, b);
        }
    }
}
