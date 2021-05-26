using System;
using System.Collections.Generic;


namespace baek4948
{
    class Program
    {

        public static int SearchDecimalCount(int num1, int num2) // num1보다 크고, num2보다 작거나 같은 범위에서 소수의 개수를 반환하는 함수
        {
            int decimalCount = 0;

            for (int i = num1 + 1; i <= num2; i++)
            {
                if (i == 1)
                {
                    continue;
                }

                bool isDecimal = true;

                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        isDecimal = false;
                    }
                }

                if (isDecimal == true)
                {
                    decimalCount += 1;
                }

            }

            return decimalCount;

        }

        static void Main(string[] args)
        {
            int testCase = -1;

            List<int> decimalCounts = new List<int>();

            while (true)
            {
                testCase = int.Parse(Console.ReadLine());

                if (testCase == 0)
                {
                    break;
                }

                decimalCounts.Add(SearchDecimalCount(testCase, testCase * 2));

            }

            for (int i = 0; i < decimalCounts.Count; i++)
            {
                Console.WriteLine(decimalCounts[i]);
            }


        }
    }
}
