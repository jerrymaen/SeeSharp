//Program that asks the user to enter two integers and tells which of the numbers was larger, or if they were equal.


using System;

class Program
{
    static void Main()
    {
        //Pyydetään käyttäjää syöttämään kaksi lukua
        Console.Write("Syötä ensimmäinen numero: \n");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Syötä toinen numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        //Jos ensimmäinen numero on isompi kuin toinen, tulostuu "Numero 1 on suurempi kuin numero 1."
        if (numero1 > numero2)
        {
            Console.WriteLine("Numero 1 on suurempi kuin numero 2.");
        }
        //Jos toinen numero on isompi kuin ensimmäinen, tulostuu "Numero 2 on suurempi kuin numero 1."
        else if (numero1 < numero2)
        {
            Console.WriteLine("Numero 2 on suurempi kuin numero 1.");
        }
        //Jos numerot ovat yhtä suuret, tulostuu "Numerot ovat yhtä suuret."
        else
        {
            Console.WriteLine("Numerot ovat yhtä suuret.");
        }
    }
}