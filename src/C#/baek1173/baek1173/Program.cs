using System;

namespace baek1173
{
    class Program
    {
        static int getExerciseTimeRecursive(int N, int X, int M, int T, int R, int minTime, int exerciseTime, int m)
        {
            if (M - m < T)
            {
                return -1;
            }

            else if (m > X)
            {
                return getExerciseTimeRecursive(N, m, M, T, R, minTime, exerciseTime, m);
            }

            else if (exerciseTime == N)
            {
                return X <= M ? minTime : -1;

            }

            else if (X + T <= M)
            {
                return getExerciseTimeRecursive(N, X + T, M, T, R, ++minTime, ++exerciseTime, m);
            }

            else if (X + T > M)
            {
                return getExerciseTimeRecursive(N, X - R, M, T, R, ++minTime, exerciseTime, m);
            }

            return -1;
        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            int N = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            int M = int.Parse(line[2]);
            int T = int.Parse(line[3]);
            int R = int.Parse(line[4]);

            int time = getExerciseTimeRecursive(N, m, M, T, R, 0, 0, m);
            Console.WriteLine(time);
        }
    }
}
