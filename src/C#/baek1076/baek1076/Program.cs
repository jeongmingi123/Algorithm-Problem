using System;
using System.Collections.Generic;

namespace baek1076
{
    class Program
    {
        static long GetTotalResistanceValue(int num1, int num2, int num3)
        {
            string temp = "";

            if (num1 == 0)
            {
                temp = string.Format($"{num2}");
            }

            else
            {
                temp = string.Format($"{num1}{num2}");

            }

            return long.Parse(temp) * num3;
        }

        static int SearchResistanceValue(string color)
        {
            Dictionary<string, int> colorAndValue = new Dictionary<string, int>();

            colorAndValue.Add("black", 0);
            colorAndValue.Add("brown", 1);
            colorAndValue.Add("red", 2);
            colorAndValue.Add("orange", 3);
            colorAndValue.Add("yellow", 4);
            colorAndValue.Add("green", 5);
            colorAndValue.Add("blue", 6);
            colorAndValue.Add("violet", 7);
            colorAndValue.Add("grey", 8);
            colorAndValue.Add("white", 9);

            return colorAndValue[color];
        }

        static int SearchResistanceMultiply(string color)
        {
            Dictionary<string, int> colorAndMultiply = new Dictionary<string, int>();

            colorAndMultiply.Add("black", 1);
            colorAndMultiply.Add("brown", 10);
            colorAndMultiply.Add("red", 100);
            colorAndMultiply.Add("orange", 1000);
            colorAndMultiply.Add("yellow", 10000);
            colorAndMultiply.Add("green", 100000);
            colorAndMultiply.Add("blue", 1000000);
            colorAndMultiply.Add("violet", 10000000);
            colorAndMultiply.Add("grey", 100000000);
            colorAndMultiply.Add("white", 1000000000);

            return colorAndMultiply[color];

        }
        static void Main(string[] args)
        {
            string[] color = new string[3];
            for (int i = 0; i < 3; i++)
            {
                color[i] = Console.ReadLine();
            }

            int num1 = SearchResistanceValue(color[0]);
            int num2 = SearchResistanceValue(color[1]);
            int num3 = SearchResistanceMultiply(color[2]);

            long result = GetTotalResistanceValue(num1, num2, num3);
            Console.WriteLine(result);
        }
    }
}
