using System;

namespace baek1173
{
    class Program
    {
        static int getExerciseTime(int N, int X, int M, int T, int R, int time, int tempN, int m)
        {
            if (m > X)
            {
                return getExerciseTime(N, m, M, T, R, ++time, tempN, m);
            }

            if (tempN == N)
            {
                return X <= M ? time : -1;

            }

            else if (X + T <= M)
            {
                return getExerciseTime(N, X + T, M, T, R, ++time, ++tempN, m);
            }

            else if (X + T > M)
            {
                return getExerciseTime(N, X - R, M, T, R, ++time, tempN, m);
            }

            return 0;
        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            int N = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            int M = int.Parse(line[2]);
            int T = int.Parse(line[3]);
            int R = int.Parse(line[4]);

            int time = getExerciseTime(N, m, M, T, R, 0, 0, m);
            Console.WriteLine(time);
        }
    }
}
