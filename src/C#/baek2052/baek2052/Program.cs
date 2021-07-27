using System;

namespace baek2052
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(2, -N));
        }
    }
}

/*
 
N==1
1/2

N=2
1/4

N=3
1/8

N==4
1/16

N==5

1/32






 */