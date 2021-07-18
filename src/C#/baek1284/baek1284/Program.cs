using System;
using System.Text;

namespace baek1284
{
    class Program
    {
        static int GetWhiteSpaceBetweenNumbers(string num)
        {
            if (num.Length == 1)
            {
                return 0;
            }

            else if (num.Length == 2)
            {
                return 1;
            }

            else if (num.Length == 3)
            {
                return 2;
            }

            else
            {
                return 3;
            }
        }

        static int GetSumTotalLengthByNumberRecursive(string num, int index)
        {
            if (index == num.Length)
            {
                return 0;
            }

            if (num[index] == '0')
            {
                return 4 + GetSumTotalLengthByNumberRecursive(num, index + 1);
            }

            else if (num[index] == '1')
            {
                return 2 + GetSumTotalLengthByNumberRecursive(num, index + 1);
            }

            else
            {
                return 3 + GetSumTotalLengthByNumberRecursive(num, index + 1);
            }
        }

        const int WHITE_SPACE_WITH_LEFT_AND_RIGHT = 2;

        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            while (true)
            {
                string num = Console.ReadLine();
                int total = 0;

                if (num == "0")
                {
                    break;
                }

                else
                {
                    total += GetSumTotalLengthByNumberRecursive(num, 0);
                    total += GetWhiteSpaceBetweenNumbers(num);
                    total += WHITE_SPACE_WITH_LEFT_AND_RIGHT;

                    result.AppendLine(total.ToString());
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
