using System;
using System.Collections.Generic;

namespace baek1065
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputN = Console.ReadLine();

            if (inputN.Length == 1 || inputN.Length == 2)
            {
                Console.WriteLine(inputN);
            }
            else
            {
                int count = 99;
                List<int> list = new List<int>();
                for (int i = 100; i <= int.Parse(inputN); i++)
                {
                    string number = i.ToString();

                    int inputNZeroIndex = int.Parse(number[0].ToString());
                    int inputNFirstIndex = int.Parse(number[1].ToString());
                    int inputNTwoIndex = int.Parse(number[2].ToString());

                    if (inputNZeroIndex > inputNFirstIndex && inputNFirstIndex > inputNTwoIndex)
                    {
                        if (inputNZeroIndex - inputNFirstIndex == inputNFirstIndex - inputNTwoIndex)
                        {
                            count++;
                            list.Add(i);
                        }
                    }
                    else if (inputNZeroIndex < inputNFirstIndex && inputNFirstIndex < inputNTwoIndex)
                    {
                        if (inputNFirstIndex - inputNZeroIndex == inputNTwoIndex - inputNFirstIndex)
                        {
                            count++;
                            list.Add(i);
                        }
                    }
                    else if (inputNZeroIndex == inputNFirstIndex && inputNTwoIndex == inputNFirstIndex)
                    {
                        count++;
                        list.Add(i);
                    }

                }
                

                Console.WriteLine(count);
                Console.WriteLine("------------");
                for(int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
