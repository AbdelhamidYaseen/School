using Microsoft.Win32.SafeHandles;
using System;

namespace BeginnenMetCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string gemoedToestand;
            string gemeente;

            Console.Write("Hello World! \n\n\n");
            Console.Write("Wie ben jij? ");
            name = Console.ReadLine();
            Console.WriteLine("De gebruiker zijn naam is: " + name + ".");
            Console.Write("Dag Yaseen hoe gaat het? ");
            gemoedToestand = Console.ReadLine();
            Console.WriteLine("Het gaat met Yaseen " + gemoedToestand);
            Console.Write("In welke gemeente woon je " + name + "? ");
            gemeente = Console.ReadLine();
            Console.WriteLine(name + " woon in de gemeente " + gemeente + " en het gaat " + gemoedToestand + " met hem.");
        }
    }
}
