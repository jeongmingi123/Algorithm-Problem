using System;

namespace baek10757
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            string num1 = inputs[0];
            string num2 = inputs[1];

            if (num1.Length > num2.Length)
            {
                while (true)
                {
                    if (num1.Length == num2.Length)
                    {
                        break;
                    }
                    num2 = "0" + num2;
                }
            }
            else if (num1.Length < num2.Length)
            {
                while (true)
                {
                    if (num1.Length == num2.Length)
                    {
                        break;
                    }
                    num1 = "0" + num1;
                }
            }

            int num1Length = num1.Length;
            string result = ((int)(num1[num1Length]) + (int)num2[num1Length]).ToString();
            int temp = 0;
            while (true)
            {
                if (num1Length == 0)
                {
                    break;
                }

                temp = (int)(num1[num1Length]) + (int)num2[num1Length] + (int)result[0];

                if (temp > 10)
                {
                    result = "1" + result;
                }
            }
        }
    }
}
