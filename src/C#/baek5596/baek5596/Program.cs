using System;

namespace baek5596
{
    class Program
    {
        static int getTotalScore(int[] nums, int index)
        {
            if (index == nums.Length)
            {
                return 0;
            }

            return nums[index] + getTotalScore(nums, index + 1);

        }

        static void Main(string[] args)
        {
            int[] minGookScores = new int[4];
            int[] jungboScores = new int[4];

            for (int i = 0; i < 2; i++)
            {
                string[] lines = Console.ReadLine().Split();

                if (i == 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        minGookScores[j] = int.Parse(lines[j]);
                    }
                }

                else if (i == 1)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        jungboScores[j] = int.Parse(lines[j]);
                    }
                }

            }

            int minGookTotalScore = getTotalScore(minGookScores, 0);
            int jungboTotalScore = getTotalScore(jungboScores, 0);

            if (minGookTotalScore >= jungboTotalScore)
            {
                Console.WriteLine(minGookTotalScore);
            }

            else
            {
                Console.WriteLine(jungboTotalScore);
            }

        }
    }
}
