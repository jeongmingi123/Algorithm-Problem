using System;

namespace baek1225
{
    class Program
    {
        static long GetOddMuliplyResult(string A, string B, int ALength, int BLength)
        {
            long Atemp = 0;
            for (int i = 0; i < ALength; i++)
            {
                Atemp += (A[i] - 48);
            }

            long Btemp = 0;
            for (int i = 0; i < BLength; i++)
            {
                Btemp += (B[i] - 48);
            }

            return Atemp * Btemp;


        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            long result = result = GetOddMuliplyResult(line[0], line[1], line[0].Length, line[1].Length);

            Console.WriteLine(result);

        }
    }
}
