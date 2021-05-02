using System;

namespace baek10869
{
    class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        static int Remainder(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] inputAB = input.Split();

            int A = int.Parse(inputAB[0]);
            int B = int.Parse(inputAB[1]);

            Console.WriteLine(Add(A, B));
            Console.WriteLine(Sub(A, B));
            Console.WriteLine(Mul(A, B));
            Console.WriteLine(Div(A, B));
            Console.WriteLine(Remainder(A, B));
        }
    }
}
