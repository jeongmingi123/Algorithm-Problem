/*

1층 1, 0개
2층 2~7, 6개
3층 8~19, 12개
4층 20~37      18개 

3->3
4->6
5->10

next = 1

while(true)
 previous = next
 next = previous+6*n
 if(number>=previous && number<=next)
 {
  return n+1;
 }
 n++;

https://sihyungyou.github.io/baekjoon-2292/ 풀이 참조할것

 */

using System;

namespace baek2292
{
    class Program
    {
        static int SearchMinimalRoom(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            int max = 1;
            int min = 0;
            
            int count = 0;

            while (true)
            {
                min = max;
                max = min + 6 * count;

                if (num >= min && num <= max)
                {
                    return count + 1;
                }
                count++;
            }

        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(SearchMinimalRoom(num));

        }
    }
}
