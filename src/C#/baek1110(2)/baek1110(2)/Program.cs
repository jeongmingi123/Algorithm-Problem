using System;

namespace baek1110_2_
{
    class Program
    {
        static void getCycleToReturnOriginalNumberRecursive(int originalNum, int left, int right, int count)
        {
            int sum = left + right; // 8
            int result = int.Parse(string.Format($"{right}{sum % 10}"));

            if (result == originalNum)
            {
                Console.WriteLine(count);
                return;
            }

            getCycleToReturnOriginalNumberRecursive(originalNum, right, sum % 10, count + 1); // 
        }
        static void Main(string[] args)
        {
            int origin = int.Parse(Console.ReadLine());
            string temp = origin.ToString();

            int num1 = int.Parse(temp) / 10;
            int num2 = int.Parse(temp) % 10;

            getCycleToReturnOriginalNumberRecursive(origin, num1, num2, 1);
        }
    }
}