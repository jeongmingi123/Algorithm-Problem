using System;

namespace prog음양더하기
{
    class Program
    {
        public int Solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;
            for (int i = 0; i < absolutes.Length; i++)
            {
                if (!signs[i])
                {
                    answer -= absolutes[i];
                }
                else
                {
                    answer += absolutes[i];
                }
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
