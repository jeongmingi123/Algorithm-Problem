using System;

namespace baek1173
{
    class Program
    {
        static int getExerciseTime(int N, int m, int M, int T, int R, int time, int index)
        {
            if (index == N)
            {
                return m <= M ? time : -1;

            }

            else if (m + T <= M)
            {
                return getExerciseTime(N, m + T, M, T, R, time + 1, index + 1);
            }

            else if (m + T > M)
            {
                return getExerciseTime(N, m - R, M, T, R, time + 1, index);
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

            int time = getExerciseTime(N, m, M, T, R, 0, 0);
            Console.WriteLine(time);
        }
    }
}
