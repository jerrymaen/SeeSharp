// Write a C# program that implements bubble sorting. The program receives the values to be sorted as command line arguments.

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

        BubbleSortArray(numbers);

        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.Write("");
    }

    static void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {

                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
