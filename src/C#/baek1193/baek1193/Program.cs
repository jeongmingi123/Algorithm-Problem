using System;

namespace baek1193
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int inpuutCase = int.Parse(Console.ReadLine());

            int count = 1;

            int deno = 1; // 분모
            int mol = 1; // 분자
            while (true)
            {
                if (count == inpuutCase)
                {
                    Console.WriteLine($"{mol}/{deno}");
                    break;
                }

                if (i == 1)
                {
                    i++;
                    count++;
                    continue;
                }

                if (i % 2 == 1)
                {
                    mol = i;
                    deno = 1;
                    for (int j = 0; j < i; j++)
                    {
                        mol -= 1;
                        deno += 1;
                        if (count == inpuutCase)
                        {
                            Console.WriteLine($"{mol}/{deno}");
                            break;
                        }
                        count += 1;
                    }
                    i++;
                }

                else if (i % 2 == 0)
                {
                    mol = 1;
                    deno = i;
                    for (int j = 0; j < i; j++)
                    {
                        mol += 1;
                        deno -= 1;
                        if (count == inpuutCase)
                        {
                            Console.WriteLine($"{mol}/{deno}");
                            break;
                        }
                        count += 1;

                    }
                    i++;
                }
            }
        }
    }
}
