using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numerot = new List<int>(); // List-esittely

        int syote;
        while (true)
        {
            Console.Write("Syötä numero: ");
            syote = int.Parse(Console.ReadLine());
            if (syote < 0)
                break;
            // Elementtien lisäys listalle
            numerot.Add(syote);
        }

        Console.Write("Syöttämäsi numerot: ");
        foreach (int numero in numerot)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
