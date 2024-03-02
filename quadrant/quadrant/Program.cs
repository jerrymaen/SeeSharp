using System;

namespace quadrant
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Löydä xy-akseleilla olevan pisteen kvadrantti: \n");

            Console.Write("X-koordinaatti: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Y-koordinaatti: ");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Koordinaattipiste (0,0) on origossa.");
            } else if (x > 0 && y > 0)
            {
                Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa 1.");
            } else if (x < 0 && y > 0)
            {
                Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa 2.");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa 3.");
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa 4.");
            }
        }
    }
}