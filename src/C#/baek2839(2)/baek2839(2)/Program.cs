using System;

namespace baek2839_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int iCount = 0;
            int fiveKilogramCount = (inputNumber / 5) - iCount;
            int threeKilogramCount = ((5 * iCount) + (inputNumber % 5)) / 3;

            while (true)
            {
                if (fiveKilogramCount == -1)
                {
                    Console.WriteLine("-1");
                    break;
                }
                if ((5 * fiveKilogramCount) + (3 * threeKilogramCount) == inputNumber)
                {
                    Console.WriteLine(fiveKilogramCount + threeKilogramCount);
                    break;
                }
                else
                {
                    iCount += 1;
                    fiveKilogramCount = (inputNumber / 5) - iCount;
                    threeKilogramCount = ((5 * iCount) + (inputNumber % 5)) / 3;
                }
                
            }

        }
    }
}
