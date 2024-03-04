using System;

class Program
{
    static void Main()
    {
        Console.Write("Anna pyramidin korkeus: ");
        string input = Console.ReadLine();
        int n;
        if (int.TryParse(input, out n))
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
