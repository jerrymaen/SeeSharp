//Introduce and initialize the variables x, y, z and b so that the program prints "Onnistui!".

using System;

class Program
{
    static void Main()
    {
        int x = 1;
        int y = 2;
        int z = 3;
        int b = 4;
        string s = "A";               

        if (((x >= y) && (y > z)) || ((x > y) && (s == "A")))
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
