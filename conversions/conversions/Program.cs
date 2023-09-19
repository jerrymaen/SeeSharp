//Introduce the variables below and initialize them with appropriate values.
//var1 = 8-bit signed integer
//var2 = 64-bit signed integer
//var3 = 16-bit unsigned integer
//var4 = 64-bit double-precision floating point

using System;

class Conversions
{
    static void Main()
    {
        sbyte var1 = 42;
        long var2 = -1;
        ushort var3 = 10;
        double var4 = 1.22;

        if (var1.GetType() == typeof(sbyte))
        {
            Console.WriteLine("var1 tyyppi ok.");
        }

        if (var2.GetType() == typeof(Int64))
        {
            Console.WriteLine("var2 tyyppi ok.");
        }

        if (var3.GetType() == typeof(UInt16))
        {
            Console.WriteLine("var3 tyyppi ok.");
        }

        if (var4.GetType() == typeof(Double))
        {
            Console.WriteLine("var4 tyyppi ok.");
        }
    }
}