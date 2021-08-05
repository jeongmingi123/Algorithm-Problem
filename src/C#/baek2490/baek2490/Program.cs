using System;
using System.Text;

namespace baek2490
{
    class Program
    {
        static void PlayYut(StringBuilder sb1, int count)
        {
            if (count == 0)
            {
                sb1.AppendLine("E");
            }

            else if (count == 1)
            {
                sb1.AppendLine("A");
            }

            else if (count == 2)
            {
                sb1.AppendLine("B");
            }

            else if (count == 3)
            {
                sb1.AppendLine("C");
            }

            else if (count == 4)
            {
                sb1.AppendLine("D");
            }
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                string line = Console.ReadLine();

                string[] bars = line.Split(" ");

                int count = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (int.Parse(bars[j]) == 0)
                    {
                        ++count;
                    }
                }

                PlayYut(sb, count);

            }

            string result = sb.ToString();

            Console.WriteLine(result);
        }
    }
}
