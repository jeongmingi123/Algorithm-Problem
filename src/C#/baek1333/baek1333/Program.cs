using System;

namespace baek1333
{
    class Program
    {
        static void GetTime(int start, int end, int D)
        {
            if()
            for (int i = start; i <= end; i++)
            {
                if (i % D == 0)
                {
                    Console.WriteLine(i);
                    return;
                }

                start += start + 6;
                end += end + 6;

                GetTime(start, end, D);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
