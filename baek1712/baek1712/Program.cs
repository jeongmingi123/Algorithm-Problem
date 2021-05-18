using System;
using System.IO;
namespace baek1712
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ");

            int fixedCost = int.Parse(inputs[0]);
            int variableCost = int.Parse(inputs[1]);
            int notebookPrice = int.Parse(inputs[2]);


            if (variableCost > notebookPrice)
            {
                Console.WriteLine("-1");
            }

            int breakEvenPoint = fixedCost / (notebookPrice - variableCost);

            Console.WriteLine(breakEvenPoint + 1);





        }
    }
}
