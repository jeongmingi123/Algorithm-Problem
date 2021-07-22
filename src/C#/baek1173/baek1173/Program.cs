using System;

namespace baek1173
{
    class Program
    {
        static int getExerciseTimeRecursive(int N, int X, int M, int T, int R, int m, int minTime, int exerciseTime)
        {
            if (M - m < T)
            {
                return -1;
            }

            else if (m > X)
            {
                return getExerciseTimeRecursive(N, m, M, T, R, m, minTime, exerciseTime);
            }

            else if (exerciseTime == N)
            {
                return X <= M ? minTime : -1;

            }

            else if (X + T <= M)
            {
                return getExerciseTimeRecursive(N, X + T, M, T, R, m, ++minTime, ++exerciseTime);
            }

            else if (X + T > M)
            {
                return getExerciseTimeRecursive(N, X - R, M, T, R, m, ++minTime, exerciseTime);
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

            int time = getExerciseTimeRecursive(N, m, M, T, R, m, 0, 0);
            Console.WriteLine(time);
        }
    }
}
