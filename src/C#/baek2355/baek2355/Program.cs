using System;

namespace baek2355
{
    class Program
    {
        static long GetSigmaValue(long start, long end)
        {
            if ((end - start + 1) % 2 == 0)
            {
                return (end + start) * ((end - start + 1) / 2);
            }

            return (end + start) * ((end - start) + 1) / 2;

        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            long start = int.Parse(line[0]);

            long end = int.Parse(line[1]);

            long total = GetSigmaValue(start, end);
            Console.WriteLine(total);
        }
    }
}
