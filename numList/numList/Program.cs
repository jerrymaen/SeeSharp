/* Write a program that asks the user to enter integers until the program receives a negative number as input.
 * The input numbers should be added to a list of type int (List) called numbers. */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        int syote;
        List<int> numerot = new List<int>();
        do
        {
            Console.Write("Syötä numero: ");
            syote = int.Parse(Console.ReadLine());

            if (syote >= 0)
            {
                numerot.Add(syote);
            }
        } while (syote >= 0);

        Console.Write("Syöttämäsi numerot: ");
        foreach (int numero in numerot)
        {
            Console.Write(numero + " ");
        }
    }
}
