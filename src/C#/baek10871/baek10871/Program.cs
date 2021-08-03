using System;

namespace baek10871
{
    class Program
    {
        static void PrintNumsUnderX(int[] nums, int index, int X)
        {
            if (index == nums.Length)
            {
                return;
            }

            else if (nums[index] < X)
            {
                Console.Write($"{nums[index]} ");
            }

            PrintNumsUnderX(nums, index + 1, X);
        }
        static void Main(string[] args)
        {

            string[] line1 = Console.ReadLine().Split(" ");

            int N = int.Parse(line1[0]);
            int X = int.Parse(line1[1]);

            string[] lines2 = Console.ReadLine().Split(" ");

            int[] nums = new int[N];

            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(lines2[i]);
            }

            PrintNumsUnderX(nums, 0, X);

        }
    }
}

/*
 
N : 정수 N개로 이루어진
X : X보다 작은 수
A : 수열 

입력
10 5

10 : N
5 : X

10개로 이루어진 수열 A에 대해서, 5보다 작은 값들을 찾아라


 */