using System;

namespace baek1837
{
    class Program
    {

        static string JudgePassword(int P, int p, int q, int qTemp, int K)
        {
            if ((p * q > P) && ((p + 1) * qTemp <= P))
            {
                return JudgePassword(P, p + 1, qTemp, qTemp, K);

            }

            if (p * q == P)
            {
                if (p <= K || q <= K)
                {
                    if (p >= q)
                    {
                        return $"BAD {q}";
                    }
                    else
                    {
                        return $"BAD {p}";
                    }
                }
                return "GOOD";
            }

            return JudgePassword(P, p, q + 1, qTemp, K);

        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int P = int.Parse(line[0]);
            int K = int.Parse(line[1]);

            Console.WriteLine(JudgePassword(P, 2, 2, 2, K));
        }
    }
}
