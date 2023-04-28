using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Case2;

class Program
{

    static void Main(string[] args)
    {
        bool løkke;
        løkke = false;

        while (løkke == false)
        {
            
            Console.Clear();
            Console.WriteLine("Vælg en af fælgende valgmuligheder.");
            Console.WriteLine("Hvis du ikke indtaster nogle at valgmulighederne, vil du starte forfra.\n");
            Console.WriteLine("Lærer (1)");
            Console.WriteLine("Elev  (2)");
            Console.WriteLine("Fag   (3)");
            Console.WriteLine("Exit  (4)");
            Console.Write("Indtast: ");
            string Funktion = Console.ReadLine();

            if (Funktion == "1")
            {
                Console.WriteLine("Funktion 1");
                Console.ReadKey();
            }
            if (Funktion == "2")
            {
                Console.WriteLine("Funktion 2");
                Console.ReadKey();
            }
            if (Funktion == "3")
            {
                Console.WriteLine("Funktion 3");
                Console.ReadKey();
            }
            if (Funktion == "4")
            {
                Environment.Exit(0);
            }
        }
    }
}