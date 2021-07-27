using System;
using System.Collections.Generic;

namespace baek2501
{
    class Program
    {

        static List<int> GetDivisors(int num)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }


        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            int N = int.Parse(line[0]);
            int K = int.Parse(line[1]);

            List<int> divisors = GetDivisors(N);

            if (divisors.Count < K)
            {
                Console.WriteLine("0");
            }

            else
            {
                Console.WriteLine(divisors[K-1]);
            }

        }
    }
}
