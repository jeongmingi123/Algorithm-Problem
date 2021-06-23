using System;

namespace baek2839_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int i = 0;
            int fiveCount = number / 5;
            int threeCount = (number % 5) % 3;

            while (true)
            {
                if (fiveCount == -1)
                {
                    Console.WriteLine("-1");
                    break;
                }
                if ((5 * fiveCount) + (3 * threeCount) == number)
                {
                    Console.WriteLine(fiveCount + threeCount);
                    break;
                }

                else
                {
                    i++;
                    fiveCount = (number / 5) - i;
                    threeCount = (5*fiveCount + ((number) % 5) % 3) + i;
                }
            }
        }
    }
}
