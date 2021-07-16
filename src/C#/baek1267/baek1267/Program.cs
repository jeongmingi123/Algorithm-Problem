using System;

namespace baek1267
{
    class Program
    {
        static int GetCellPhoneBillRecursive(int[] talkTimes, int seconds, int perSecondsPrice, int index)
        {
            if (index == talkTimes.Length)
            {
                return 0;
            }

            int price = talkTimes[index] / seconds * perSecondsPrice + perSecondsPrice;

            return price + GetCellPhoneBillRecursive(talkTimes, seconds, perSecondsPrice, index + 1);

        }

        static void Main(string[] args)
        {
            int callsCount = int.Parse(Console.ReadLine());

            string[] line = Console.ReadLine().Split();

            int[] callsTimes = new int[callsCount];

            for (int i = 0; i < callsCount; i++)
            {
                callsTimes[i] = int.Parse(line[i]);
            }

            int youngsikPrice = GetCellPhoneBillRecursive(callsTimes, 30, 10, 0);
            int minsikPrice = GetCellPhoneBillRecursive(callsTimes, 60, 15, 0);

            if (youngsikPrice == minsikPrice)
            {
                Console.WriteLine($"Y M {youngsikPrice}");
            }
            else if (youngsikPrice > minsikPrice)
            {
                Console.WriteLine($"M {minsikPrice}");
            }
            else
            {
                Console.WriteLine($"Y {youngsikPrice}");
            }
        }
    }
}