using System;

namespace baek10101
{
    class Program
    {
        static void PrintTriangleType(int angle1, int angle2, int angle3)
        {
            if (angle1 == 60 && angle2 == 60 && angle3 == 60)
            {
                Console.WriteLine($"Equilateral");
            }

            else if ((angle1 + angle2 + angle3 == 180) && (angle1 == angle2 || angle2 == angle3 || angle1 == angle3))
            {
                Console.WriteLine($"Isosceles");

            }

            else if ((angle1 + angle2 + angle3 == 180) && angle1 != angle2 && angle2 != angle3 && angle1 != angle3)
            {
                Console.WriteLine($"Scalene");

            }

            else
            {
                Console.WriteLine($"Error");
            }
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            PrintTriangleType(num1, num2, num3);
        }
    }
}
