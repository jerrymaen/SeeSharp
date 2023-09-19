//Declare the variables below and give them appropriate values:
//var1 tyyppiä short.
//var2 tyyppiä byte.
//var3 tyyppiä float.   
//var4 tyyppiä char.
//var5 tyyppiä boolean.
//var6 tyyppiä ulong.
//var7 tyyppiä decimal.

using System;

class Tietotyypit
{
    static void Main(string[] args)
    {

        short var1 = 10;
        byte var2 = 200;
        float var3 = 3.14f;
        char var4 = 'A';
        bool var5 = true;
        ulong var6 = 1000000000UL;
        decimal var7 = 123.456m;

        Console.WriteLine("Var1 on tyyppiä " + var1.GetType());
        Console.WriteLine("Var2 on tyyppiä " + var2.GetType());
        Console.WriteLine("Var3 on tyyppiä " + var3.GetType());
        Console.WriteLine("Var4 on tyyppiä " + var4.GetType());
        Console.WriteLine("Var5 on tyyppiä " + var5.GetType());
        Console.WriteLine("Var6 on tyyppiä " + var6.GetType());
        Console.WriteLine("Var7 on tyyppiä " + var7.GetType());

    }
}