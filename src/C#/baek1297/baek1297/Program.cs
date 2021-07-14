using System;

namespace baek1297
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] s = Console.ReadLine().Split();

            int x = int.Parse(s[1]);
            int y = int.Parse(s[2]);
            int z = int.Parse(s[0]);
        }
    }
}

/*
 x^2 + y^2 = 52^2
 x^2 + (9/16*x)^2 = z^2

x^2 + a*x^2

x^2*(1+a) = z^2

x^2 = z^2 / (1+a)




9 : 16 = y : x

16y = 9x

y = 9/16*x
 
 */