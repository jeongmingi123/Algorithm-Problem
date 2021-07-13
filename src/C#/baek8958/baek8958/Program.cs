using System;

namespace baek8958
{
    class Program
    {
        static int GetScore(string s)
        {
            int score = 0;
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'O')
                {
                    ++score;
                    total += score;
                }

                else if (s[i] == 'X')
                {
                    score = 0;
                }
            }

            return total;
        }

        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            int[] results = new int[testCase];

            for (int i = 0; i < testCase; i++)
            {
                string line = Console.ReadLine();
                results[i] = GetScore(line);
            }

            foreach (int result in results)
            {
                Console.WriteLine(result);
            }

        }
    }
}
