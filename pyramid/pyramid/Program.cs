﻿using System;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna pyramidin korkeus:");
            int n = int.Parse(Console.ReadLine());

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
