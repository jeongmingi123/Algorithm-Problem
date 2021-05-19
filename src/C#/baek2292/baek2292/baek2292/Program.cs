

/*
요구조건

* 입력 받은 함수가 몇층인지 아는 함수
* 층 마다의 최솟값을 구하는 함수
* 층 마다의 최대값을 구하는 함수
* 
* 최소 방의 개수를 반환 하는 함수 

1층 1, 0개
2층 2~7, 6개
3층 8~19, 12개
4층 20~37      18개 

30 -> 4층


2층 
3층 6*1+2 6*3+1
4층 6*3+2 6*6+1
5층       6*10+1


3->3
4->6
5->10
n층, 최솟값은 2+6*(n-2) 최대값은 1+6*(n-1) 개수 : 6*(n-1)

2+6*(n-2)<=number<=1+6*n

next = 1

while(true)
 previous = next
 next = previous+6*n
 if(number>=previous && number<=next)
 {
  return n+1;
 }
 n++;

2+6(n-2)<=7<=1+6*(n-1)


8<=8<=
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
