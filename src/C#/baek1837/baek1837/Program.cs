using System;

namespace baek1837
{
    class Program
    {
        static bool IsSosu(int num)
        {
            if (num == 1)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static string JudgePassword(int P, int p, int q, int qTemp)
        {
            if (p * q > P)
            {
                if ((p + 1) * qTemp <= P)
                {
                    return JudgePassword(P, p + 1, qTemp, qTemp);
                }

                else
                {
                    return "BAD";
                }
            }

            if (IsSosu(p) == true && IsSosu(q) == true && p * q == P)
            {
                return "GOOD";
            }

            return JudgePassword(P, p, q + 1, qTemp);

        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int P = int.Parse(line[0]);
            int K = int.Parse(line[1]);

            Console.WriteLine(JudgePassword(P, K, K, K));
        }
    }
}
