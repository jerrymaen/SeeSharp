// Write a C# program that asks the user for integers until they sum to at least 200. You must use the while statement.

using System;

namespace sumTo200
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int input;

            while (sum < 200)
            {
                Console.Write("Summa on nyt " + sum + ". Syöte: ");
                input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine("Saavutettiin 200. Summa oli " + sum + ".");

        }
    }
}
