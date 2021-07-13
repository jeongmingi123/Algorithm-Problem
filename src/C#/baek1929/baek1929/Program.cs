using System;

namespace baek1929
{
    class Program
    {

        static bool IsSosu(int num)
        {

            if (num == 1)
            {
                return false;
            }

            for (int i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        static void PrintSosu(int start, int end)
        {
            if(start == 1 && end == 1)
            {
                return;
            }

            else if (start == end && IsSosu(start) == true)
            {
                Console.WriteLine(start);
                return;
            }

            else if(start == end && IsSosu(start) == false)
            {
                return;
            }

            else if(IsSosu(start) == false)
            {
                PrintSosu(start + 1, end);
            }

            else
            {
                Console.WriteLine(start);
                PrintSosu(start + 1, end);
            }

        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ");

            int start = int.Parse(line[0]);
            int end = int.Parse(line[1]);

            PrintSosu(start, end);
        }
    }
}
