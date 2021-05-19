using System;
using System.Collections.Generic;

namespace baek1929
{
    class Program
    {
        static List<int> GetDemicals(int num1, int num2)
        {
            List<int> demicals = new List<int>();

            if (num2 == 2)
            {
                demicals.Add(2);
                return demicals;
            }

            for (int i = num1; i <= num2; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                bool isDemical = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isDemical = false;
                    }
                }
                if (isDemical == true)
                {
                    demicals.Add(i);
                }
            }

            return demicals;
        }

        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int num1 = int.Parse(inputs[0]);
            int num2 = int.Parse(inputs[1]);

            List<int> demicals = new List<int>(GetDemicals(num1, num2));

            for (int i = 0; i < demicals.Count; i++)
            {
                Console.WriteLine(demicals[i]);
            }


        }
    }
}
