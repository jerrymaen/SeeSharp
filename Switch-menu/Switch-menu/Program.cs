// Program that prints a menu and asks for input from the user. You must use a switch statement.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Valitse:");
            Console.WriteLine("1) Vesi");
            Console.WriteLine("2) Mehu");
            Console.WriteLine("3) Limonadi");
            Console.WriteLine("4) Lopeta");

            int valinta;

            if (int.TryParse(Console.ReadLine(), out valinta))
            {
                switch (valinta)
                {
                    case 1:
                        Console.WriteLine("Valitsit Vesi.\n");
                        break;
                    case 2:
                        Console.WriteLine("Valitsit Mehu.\n");
                        break;
                    case 3:
                        Console.WriteLine("Valitsit Limonadi.\n");
                        break;
                    case 4:
                        Console.WriteLine("Lopetus!\n");
                        return;

                }
            }
        }
    }
}