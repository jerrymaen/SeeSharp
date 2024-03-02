using System;

class bubbleSort
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Syötä numero: ");
            return;
        }

        int[] numbers = new int[args.Length];

        for (int i = 0; i < args.Length; i++)
        {
            numbers[i] = int.Parse(args[i]);
        }

        Array.Sort(numbers);

        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
