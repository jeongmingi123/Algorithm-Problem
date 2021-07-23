using System;

namespace baek1964
{
    class Program
    {
        static long GetDotTotal(int N, int index)
        {
            if (N == 1)
            {
                return 5;
            }

            else if (index == 1)
            {
                return 5 + GetDotTotal(N, index + 1);
            }

            else if (index == N)
            {
                return index * 3 + 1;
            }

            return index * 3 + 1 + GetDotTotal(N, index + 1);
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(GetDotTotal(N, 1) % 45678);
        }
    }
}
