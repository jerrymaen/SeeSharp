// Write a C# program that takes the name of a file as a command-line argument, and prints the contents of that file to the screen.

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Ei tiedostonimeä!");
            return;
        }

        string fileName = args[0];

        if (!File.Exists(fileName))
        {
            Console.WriteLine("Tiedostoa ei löytynyt!");
            return;
        }

        string fileContent = File.ReadAllText(fileName);
        Console.WriteLine(fileContent);
    }
}