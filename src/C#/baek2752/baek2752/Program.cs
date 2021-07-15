using System;

namespace baek2752
{
    class Program
    {
        static void SortSelection(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int temp = arr[i];
                int min = arr[i+1];
                int minIndex = i+1;
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (min >= arr[j])
                    {
                        min = arr[j];
                        minIndex = j;
                    }
                }

                if (arr[i] > min)
                {
                    arr[i] = min;
                    arr[minIndex] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int[] nums = new int[3];

            for (int i = 0; i < 3; i++)
            {
                nums[i] = int.Parse(line[i]);
            }

            SortSelection(nums);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{nums[i]} ");
            }


        }
    }
}
