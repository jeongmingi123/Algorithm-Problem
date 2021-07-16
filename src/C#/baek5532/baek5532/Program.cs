using System;

namespace baek5532
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = new int[5];

            for (int i = 0; i < 5; i++)
            {
                line[i] = int.Parse(Console.ReadLine());
            }

            int L = line[0];
            int A = line[1];
            int B = line[2];
            int C = line[3];
            int D = line[4];

            if (A / C >= B / D)
            {
                Console.WriteLine(A % C == 0 ? L - (A / C) : L - ((A / C) + 1));
            }
            else
            {
                Console.WriteLine(B % D == 0 ? (L - (B / D)) : (L - ((B / D) + 1)));
            }
        }
    }
}
/*
L : 방학 총일수
A : 국어 총 페이지
B : 수학 총 페이지
C : 하루에 국어 최대로 풀수있는 페이지 수
D : 하루에 수학 최대로 풀수있는 페이지 수
 

l : 20 
A : 25
B : 30
C : 6
D : 8

국어 5

25 / 6 = 4
30 / 8 = 3

국어 4일, 1나머지
수학 3일
몫을 비교


 */