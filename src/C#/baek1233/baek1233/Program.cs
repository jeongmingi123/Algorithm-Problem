using System;
using System.Collections.Generic;

namespace baek1233
{
    class Program
    {
        static int[] GetArrayWithSequenceValue(int num)
        {
            int[] nums = new int[num];

            for (int i = 0; i < num; i++)
            {
                nums[i] = i + 1;
            }

            return nums;
        }

        static void PrintDiceSumHappendMany(int[] num1, int[] num2, int[] num3)
        {
            int[] results = new int[num1.Length * num2.Length * num2.Length];

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    for (int k = 0; k < num3.Length; k++)
                    {
                        ++results[num1[i] + num2[j] + num3[k]];
                    }
                }
            }

            int max = results[0];
            int num = 0;
            for(int i = 0; i < results.Length; i++)
            {
                if(max < results[i])
                {
                    max = results[i];
                    num = i;
                }
            }

            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int[] S1 = GetArrayWithSequenceValue(int.Parse(line[0]));
            int[] S2 = GetArrayWithSequenceValue(int.Parse(line[1]));
            int[] S3 = GetArrayWithSequenceValue(int.Parse(line[2]));

            PrintDiceSumHappendMany(S1, S2, S3);

        }
    }
}
