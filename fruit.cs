//A program that asks the user to enter the name of a fruit and then prints "Your favorite fruit is the name of the fruit.


using System;

class hedelma
{
    static void Main()
    {
        Console.Write("Mikä on lempihedelmäsi?");
        string lempihedelma = Console.ReadLine();
        Console.WriteLine("Lempihedelmäsi on " + lempihedelma);
    }
}