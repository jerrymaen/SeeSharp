//Introduce and initialize the variables x, y, z and b so that the program prints "Onnistui!".

using System;

class Program
{
    static void Main()
    {

        int x = 5;
        int y = 3;
        int z = 7;
        string s = "C";


        if (((x >= y) && (y < z)) || ((x > y) && (s == "A")))
        {
            if (s == "C")
            {
                Console.WriteLine("Onnistui!");
            }
            else
            {
                Console.WriteLine("Melkein!");
            }
        }
        else
        {
            Console.WriteLine("Ei iha, yritä vielä!");
        }
    }
}
