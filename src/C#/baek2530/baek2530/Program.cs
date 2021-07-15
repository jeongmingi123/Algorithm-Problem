using System;

namespace baek2530
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            int clock = int.Parse(line[0]);
            int minute = int.Parse(line[1]);
            int seconds = int.Parse(line[2]);

            int addingSeconds = int.Parse(Console.ReadLine());

            seconds += addingSeconds;

            int addingMinute = seconds / 60;

            seconds = seconds >= 60 ? seconds % 60 : seconds;

            minute += addingMinute;

            int addingClock = minute / 60;

            minute = minute >= 60 ? minute % 60 : minute;

            clock += addingClock;
            clock = clock >= 24 ? clock % 24 : clock;

            Console.WriteLine($"{clock} {minute} {seconds}");
        }
    }
}
