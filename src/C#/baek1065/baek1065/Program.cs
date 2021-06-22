using System;
using System.Collections.Generic;

namespace baek1065
{
    class Program
    {
        // num값이 등차수열 인지에 대한 함수
        static bool IsArithmeticSequence(int num)
        {
            string number = num.ToString();

            int numberZeroIndex = int.Parse(number[0].ToString());
            int numberFirstIndex = int.Parse(number[1].ToString());
            int numberTwoIndex = int.Parse(number[2].ToString());

            if (numberZeroIndex > numberFirstIndex && numberFirstIndex > numberTwoIndex)
            {
                if (numberZeroIndex - numberFirstIndex == numberFirstIndex - numberTwoIndex)
                {
                    return true;
                }
            }
            else if (numberZeroIndex < numberFirstIndex && numberFirstIndex < numberTwoIndex)
            {
                if (numberFirstIndex - numberZeroIndex == numberTwoIndex - numberFirstIndex)
                {
                    return true;
                }
            }
            else if (numberZeroIndex == numberFirstIndex && numberTwoIndex == numberFirstIndex)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string inputN = Console.ReadLine();

            if (inputN.Length < 3)
            {
                Console.WriteLine(inputN);
            }
            else
            {
                int hansooCount = 99;

                int inputNLength = int.Parse(inputN);

                for (int i = 100; i <= inputNLength; i++)
                {
                    if (IsArithmeticSequence(i) == true)
                    {
                        hansooCount++;
                    }
                }
                Console.WriteLine(hansooCount);
            }

        }
    }
}

