// A program that prints the first given command-line argument. It is assumed that the argument is always provided and consists of letters and numbers.
using System;

class Argument
{
	static void Main(string[] args)
	{

		Console.WriteLine("Komentoriviargumentti oli: " + args[0]);
	}
}