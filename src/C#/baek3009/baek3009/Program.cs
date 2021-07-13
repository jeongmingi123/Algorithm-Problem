using System;

namespace baek3009
{
    class Program
    {
        static void search4thPoint(int[] arr)
        {
            for(int i = 0; i < 3; i++)
            {
                int temp = arr[i];
                int count = 0;

                for(int j = 0; j < arr.Length; j++)
                {
                    if (temp == arr[j])
                    {
                        ++count;
                    }
                }

                if (count == 1)
                {
                    arr[3] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] x = new int[4];
            int[] y = new int[4];

            for(int i = 0; i < 3; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                x[i] = int.Parse(line[0]);
                y[i] = int.Parse(line[1]);
            }

            search4thPoint(x);
            search4thPoint(y);

            Console.Write($"{x[3]} {y[3]}");

        }
    }
}
