using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static int SearchRangeDemicals(int num1, int num2)
        {
            List<int> demicals = new List<int>();

            for (int i = num1; i <= num2; i++)
            {
                bool isDemical = true;
                for (int j = 2; j <= i - 1; j++)
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

            return 0;
        }

        static int SearchMinimal(int[] demicals)
        {
            return 0;
        }

        static void Main(string[] args)
        {
            List<int> demicals = new List<int>();

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 1)
            {
                Console.WriteLine("-1");
            }
            else if(num2 == 2)
            {
                Console.WriteLine("2");
                Console.WriteLine("2");

            }
            else
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i == 1)
                    {
                        continue;
                    }
                    bool isDemical = true;
                    for (int j = 2; j <= i - 1; j++)
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

                int demicalsSum = 0;
                if (demicals.Count == 0)
                {
                    Console.WriteLine("-1");

                }
                else if (demicals.Count > 0)
                {
                    for (int i = 0; i < demicals.Count; i++)
                    {
                        demicalsSum += demicals[i];
                    }

                    Console.WriteLine(demicalsSum);
                    Console.WriteLine(demicals[0]);
                }
            }


        }
    }
}
