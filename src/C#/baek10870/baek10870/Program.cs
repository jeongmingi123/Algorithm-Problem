/*
 
10을 넣으면


f(n) = f(n-1) + f(n-2)

9) f(9) = f(8) + f(7)
8) f(8) = f(7) + f(6)

......

2) f(3) = f(2) + f(1) 
1) f(2) = f(1) + f(0) 
 
 */

using System;

namespace baek10870
{
    class Program
    {
        static int searchFibonacciValue(int sequence) // sequence번째의 순서까지 피보나치의 규칙에 따라 값을 반환하는 함수
        {
            if (sequence == 1)
            {
                return 1;
            }

            if (sequence == 0)
            {
                return 0;
            }



            return searchFibonacciValue(sequence - 1) + (sequence - 2);
        }

        static void Main(string[] args)
        {
            int sequence = int.Parse(Console.ReadLine());
            Console.WriteLine(searchFibonacciValue(sequence));
        }
    }
}
