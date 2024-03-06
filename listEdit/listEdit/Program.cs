/* You have been given a string-type List containing the following names:
 * "Torvalds, Musk, Gates, Buffet, Dorsey."
 * 
 * Modify the list so that the values it contains are:
 * "Jobs, Musk, McAfee, Buffet, Wozniak." 
 */

using System;
using System.Collections.Generic;

class listEdit
{
    static void Main()
    {
        List<string> nimet = new List<string> { "Torvalds", "Musk", "Gates", "Buffet", "Dorsey" };

        nimet.Remove("Torvalds");
        nimet.Insert(0, "Jobs");
        nimet[2] = "McAfee";
        nimet[4] = "Wozniak";

        foreach (string nimi in nimet)
        {
            Console.WriteLine(nimi);
        }
    }
}