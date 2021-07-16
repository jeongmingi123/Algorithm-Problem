using System;

namespace baek1032
{
    class Program
    {
        static bool IsStrOverLab(string[] strings, int index)
        {
            bool bIsStrOverLabCheck = true;
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (strings[i][index] != strings[j][index])
                    {
                        bIsStrOverLabCheck = false;
                    }
                }
            }
            return bIsStrOverLabCheck;
        }
        static void PrintFileName(string[] strings, int index, int length)
        {
            bool bIsStrOverLabCheck = IsStrOverLab(strings, index);

            if (index == length - 1 && bIsStrOverLabCheck == false)
            {
                Console.Write($"?");
                return;
            }
            else if (index == length - 1 && bIsStrOverLabCheck == true)
            {
                Console.Write($"{strings[0][index]}");
                return;
            }

            else if (bIsStrOverLabCheck == false)
            {
                Console.Write($"?");
                PrintFileName(strings, index + 1, length);
            }

            else if (bIsStrOverLabCheck == true)
            {
                Console.Write($"{strings[0][index]}");
                PrintFileName(strings, index + 1, length);
            }

        }
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            string[] lines = new string[testCase];

            for (int i = 0; i < testCase; i++)
            {
                lines[i] = Console.ReadLine();
            }

            PrintFileName(lines, 0, lines[0].Length);
        }
    }
}
