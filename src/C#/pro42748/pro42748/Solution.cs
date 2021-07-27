using System;
using System.Collections.Generic;
using System.Text;

namespace pro42748
{
    using System;

    public class Solution
    {
        public static int GetNumberKth(int[] array, int start, int end, int k)
        {
            int length = end - start + 1;

            int[] cuttedNums = new int[length];

            for (int i = 0; i < length; i++)
            {
                cuttedNums[i] = array[start - 1];
                ++start;
            }

            Array.Sort(cuttedNums);
            return cuttedNums[k - 1];

        }

        public static int[] solution(int[] array, int[,] commands)
        {

            int[] answer = new int[commands.GetLength(0)];

            int start = 0;
            int end = 0;
            int k = 0;

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                for (int j = 0; j < commands.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        start = commands[i, 0];
                    }
                    else if (j == 1)
                    {
                        end = commands[i, 1];
                    }
                    else if (j == 2)
                    {
                        k = commands[i, 2];
                    }
                }
                answer[i] = GetNumberKth(array, start, end, k);
            }

            return answer;
        }
    }
}
