﻿using System;

namespace drinkMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse:");
            Console.WriteLine("1) Vesi");
            Console.WriteLine("2) Mehu");
            Console.WriteLine("3) Limonadi");
            Console.WriteLine("4) Lopeta");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Valitsit Vesi.");
                    break;
                case 2:
                    Console.WriteLine("Valitsit Mehu.");
                    break;
                case 3:
                    Console.WriteLine("Valitsit Limonadi.");
                    break;
                case 4:
                    Console.WriteLine("Lopetus!");
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }
        }
    }
}
