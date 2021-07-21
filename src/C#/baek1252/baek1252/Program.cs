using System;

namespace baek1252
{
    class Program
    {
        static int[] getArrayByLength(int num1, int num2)
        {
            int[] lengths = new int[2];

            int num1Length = num1.ToString().Length;
            int num2Length = num1.ToString().Length;


            if (num1Length >= num2Length)
            {
                lengths[0] = num1;
                lengths[1] = num2;

                return lengths;
            }

            lengths[0] = num2;
            lengths[1] = num1;

            return lengths;
        }
        static string AddFrontZeroShortNum(int longgerNum, int shortNum, int longgerNumLength, int shortNumLength)
        {
            if (shortNumLength == longgerNumLength)
            {
                return shortNum.ToString();
            }

            return "0" + AddFrontZeroShortNum(longgerNum, shortNum, longgerNumLength, shortNumLength + 1);

        }

        static int AddBinary(int num1, int num2)
        {
            int[] lengths = getArrayByLength(num1, num2);

            int longgerNum = lengths[0];
            int shortNum = lengths[1];

            int longgerNumLength = longgerNum.ToString().Length;
            int shortNumNumLength = shortNum.ToString().Length;

            shortNum = int.Parse(AddFrontZeroShortNum(longgerNum, shortNum, longgerNumLength, shortNumNumLength));

            int result = longgerNum + shortNum;


            return result;
        }

        static int abc(int length, int index, int result)
        {
            string temp = result.ToString();

            if (index == length)
            {

            }

            if (temp[index] == '2')
            {
                temp[index] = '0';
            }
        }

        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int num1 = int.Parse(line[0]);
            int num2 = int.Parse(line[1]);

            int result = AddBinary(num1, num2);

            Console.WriteLine(result);

        }
    }
}
