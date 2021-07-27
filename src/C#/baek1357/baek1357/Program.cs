using System;

namespace baek1357
{
    class Program
    {
        static string ReverseNum(string num, int index)
        {
            if (num.Length - 1 == index)
            {
                return $"{num[index]}";
            }

            return ReverseNum(num, index + 1) + $"{num[index]}";
        }

        static string AddFrontZero(string longLengthNum, string shortLengthNum)
        {
            for (int i = 1; i <= longLengthNum.Length - shortLengthNum.Length + 1; ++i)
            {
                shortLengthNum = $"0" + shortLengthNum;
            }

            return shortLengthNum;
        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            string X = line[0];
            string Y = line[1];

            //if (X.Length > Y.Length)
            //{
            //    Y = AddFrontZero(X, Y);
            //}

            //else if (X.Length < Y.Length)
            //{
            //    X = AddFrontZero(Y, X);
            //}

            string ReverseX = ReverseNum(X, 0);
            string ReverseY = ReverseNum(Y, 0);

            string sum = (int.Parse(ReverseX) + int.Parse(ReverseY)).ToString();
            string result = ReverseNum(sum, 0);
            int Iresult = int.Parse(result);

            //Console.WriteLine($"X : {X}");
            //Console.WriteLine($"Y : {Y}");
            //Console.WriteLine($"ReverseX : {ReverseX}");
            //Console.WriteLine($"ReverseY : {ReverseY}");
            //Console.WriteLine($"sum : {sum}");
            Console.WriteLine($"result {Iresult}");
        }
    }
}
