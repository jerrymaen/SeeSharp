using System;

class Program
{
    static void Main()
    {
        Console.Write("Syötä ikäsi, ole hyvä: ");
        int ikä = Convert.ToInt32(Console.ReadLine());

        if (ikä >= 18)
        {
            Console.WriteLine("Voit äänestää!");
        }
        Console.ReadLine();
    }
}