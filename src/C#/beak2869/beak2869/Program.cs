using System;

/*

A = 낮에 올라갈 수있는 m 길이
B = 미끄러지는 m 길이
V = 높이(m)

달팽이가 나무 막대를 모두 올라가려면, 며칠이 걸리는지 구하는 프로그램을 작성하시오.

하루만에 올라가면 day = 1

A = 2
B = 1 
V = 5

4일 걸림

1일째 2m 올라감 // 2
2일째 1m 미끄러지고, 2m 올라감 // 2+1
3일째 1m 미끄러지고, 2m 올라감 // 2+1+1
4일째 1m 미끄러지고, 2m 올라감 // 2+1+1+1 << 높이

1일째 5m 올라감 // 5
2일째 5m 올라가고 1m 내려감 

 */



namespace beak2869
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split();
            int climb = int.Parse(inputs[0]);
            int slide = int.Parse(inputs[1]);
            int mountainHeight = int.Parse(inputs[2]);

            int currentHeight = climb;
            int day = 1;

            while (true)
            {
                if (currentHeight == mountainHeight)
                {
                    Console.WriteLine(day);
                    break;
                }
                else
                {
                    currentHeight = currentHeight + climb - slide;
                    day++;
                }
            }

        }
    }
}
