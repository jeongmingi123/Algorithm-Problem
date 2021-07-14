using System;

namespace baek2480
{
    class Program
    {
        static int GetEyes(int[] num)
        {
            if (num[0] == num[1] && num[1] == num[2] && num[0] == num[2])
            {
                return num[0];
            }

            else if (num[0] != num[1] && num[1] != num[2] && num[0] != num[2])
            {
                int max = num[0];

                for (int i = 0; i < 3; i++)
                {
                    if (max < num[i])
                    {
                        max = num[i];
                    }
                }

                return max;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = i + 1; j < num.Length; j++)
                    {
                        if (num[i] == num[j])
                        {
                            return num[i];
                        }
                    }
                }

            }
            return 0;
        }
        static int GetEyesCount(int[] num)
        {
            int max = 0;

            for (int i = 0; i < 2; i++)
            {
                int count = 0;

                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        ++count;
                    }
                }
                if (count > max)
                {
                    max = count;
                }
            }

            return max + 1;
        }

        static int CalculateReware(int eyesCount, int eyes)
        {
            if (eyesCount == 3)
            {
                return 10000 + eyes * 1000;
            }

            else if (eyesCount == 2)
            {
                return 1000 + eyes * 100;
            }

            return eyes * 100;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            int[] eyesArray = new int[3];

            for (int i = 0; i < 3; i++)
            {
                eyesArray[i] = int.Parse(s[i]);
            }

            int eyesCount = GetEyesCount(eyesArray);
            int eyes = GetEyes(eyesArray);

            Console.WriteLine(CalculateReware(eyesCount, eyes));

        }
    }
}
