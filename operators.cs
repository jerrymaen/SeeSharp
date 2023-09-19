// Introduce and initialize the variables a, b and c so that the program prints "Onnistui!".

using System;

class Program
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        int c = 0;

        if ( (a != b) && (a < b) ) {
            if (a > c) {
                Console.WriteLine("Onnistui!");
            }
        } else {
            Console.WriteLine("Yritä uudestaan!");
        }
    }
}
