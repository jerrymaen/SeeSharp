using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You can vote!");
        }
        Console.ReadLine();
    }
}