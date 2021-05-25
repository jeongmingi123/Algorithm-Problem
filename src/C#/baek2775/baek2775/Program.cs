/*
 
부녀회장의 조건 

a층의 b호를 살려면 (a-1)층의 1호부터 b까지 사람들의 합만큼 데려와야됨

k층의 n호에는 몇명이 살고있는가?


4층의 3호 -> 3층의 1호 + 2호 + 3호

2층의 3호 -> 1층의 1호 + 2층의 2호 + 2층의 3호
2층의 2호 -> 1층의 1호 + 1층의 2호
2층의 1호 -> 1층의 1호

1층 1호 -> 0층 1호
1층 2호 -> 0층 1호 + 2호 = 1층의 1호 + 0층의 2호
1층 3호 -> 0층 1호 + 2호 + 3호 = 1층의 2호 + 0층의 3호

n층 j호 -> n층 j-1호 + n-1층 j호


0층 1호 -> 1명
0층 2호 -> 2명
0층 3호 -> 3명


첫째줄 testCase
두번째 k층
세번째 n층



 */


using System;
using System.Collections.Generic;

namespace baek2775
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> results = new List<int>();

            int testCase = int.Parse(Console.ReadLine());



            for (int i = 0; i < testCase; i++)
            {
                int layer = int.Parse(Console.ReadLine());
                int number = int.Parse(Console.ReadLine());

                int[,] peopleCount = new int[layer+1, 15];

                for (int j = 0; j < 15; j++)
                {
                    peopleCount[0, j] = j ;
                }

                for (int j = 0; j <= layer; j++)
                {
                    peopleCount[j, 1] = 1;
                }

                if (layer == 0)
                {
                    results.Add(peopleCount[layer, number]);
                    break;
                }

                for (int j = 1; j <= layer; j++) // 1층부터 layer 층까지
                {
                    for (int k = 2; k < 15; k++) 
                    {
                        peopleCount[j, k] = peopleCount[j, k - 1] + peopleCount[j - 1, k];
                    }
                }
              
                results.Add(peopleCount[layer, number]);

            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }

        }
    }
}
