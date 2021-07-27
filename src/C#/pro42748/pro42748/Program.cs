using System;

namespace pro42748
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            int[] result = Solution.solution(array, commands);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{result[i]} ");
            }
        }
    }
}
