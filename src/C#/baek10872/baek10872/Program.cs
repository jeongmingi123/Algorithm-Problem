/*

9*8*7*6*.....*1

f(n) = 1*2*3*4* .... *n
f(n) = f(n-1)*n


 */

using System;

namespace baek10872
{
    class Program
    {
        static int getFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            if (num == 1)
            {
                return 1; 
            }

            return num * getFactorial(num - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(getFactorial(n));

        }
    }
}
