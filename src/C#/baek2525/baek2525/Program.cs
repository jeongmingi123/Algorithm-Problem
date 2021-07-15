using System;

namespace baek2525
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int addingMinute = int.Parse(Console.ReadLine());

            int clock = int.Parse(s[0]);
            int minute = int.Parse(s[1]);

            minute += addingMinute;
            int addingClock = minute / 60;


            if (minute >= 60)
            {
                clock += addingClock;
                minute -= 60 * addingClock;
            }

            clock = (clock >= 24) ? (clock -= 24) : (clock);

            Console.WriteLine($"{clock} {minute}");

        }
    }
}
