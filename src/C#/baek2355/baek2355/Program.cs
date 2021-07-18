using System;

namespace baek2355
{
    class Program
    {
        static int GetSigmaValue(int start, int end)
        {
            if ((end - start + 1) % 2 == 0)
            {
                return (end + start) * (end / start) / 2;
            }

            return (end + start) * (end / start - 1) / 2 + (end + start) / 2;

        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            int start = int.Parse(line[0]);

            int end = int.Parse(line[1]);

            int total = GetSigmaValue(start, end);
            Console.WriteLine(total);
        }
    }
}
