using System;

namespace baek4344
{
    class Program
    {
        static double getAverage(double studentCount, double[] scores)
        {
            double total = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }

            double average = total / studentCount;

            return average;

        }

        static double getStudentPercentOverAverage(double studentCount, double[] scores, double average)
        {
            double StudentCountOverAverage = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > average)
                {
                    StudentCountOverAverage++;
                }
            }

            return StudentCountOverAverage / studentCount * 100;

        }
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            double[] results = new double[testCase];
            double[] averages = new double[testCase];

            for (int i = 0; i < testCase; i++)
            {
                string[] lines = Console.ReadLine().Split(" ");

                double studentCount = double.Parse(lines[0]);

                double[] scores = new double[lines.Length - 1];

                for (int j = 0; j < scores.Length; j++)
                {
                    scores[j] = double.Parse(lines[j + 1]);
                }

                double average = getAverage(studentCount, scores);

                averages[i] = average;

                results[i] = getStudentPercentOverAverage(studentCount, scores, average);

            }

            for (int i = 0; i < testCase; i++)
            {
                Console.WriteLine("{0:F3}%", results[i]);
            }
        }
    }
}


