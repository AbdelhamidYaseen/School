using Microsoft.Win32.SafeHandles;
using System;
using System.Globalization;

namespace BeginnenMetCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string gemoedToestand;
            string gemeente;

            Console.Write("Hello World!");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n");
            }


            Console.Write("Wie ben jij? ");
            name = Console.ReadLine();
            Console.WriteLine("De gebruiker zijn naam is: " + name + ".");
            Console.Write("Dag Yaseen hoe gaat het? ");
            gemoedToestand = Console.ReadLine();
            Console.WriteLine("Het gaat met Yaseen " + gemoedToestand);
            Console.Write("In welke gemeente woon je " + name + "? ");
            gemeente = Console.ReadLine();
            Console.WriteLine(name + " woon in de gemeente " + gemeente + " en het gaat " + gemoedToestand + " met hem.");

            Console.WriteLine("Deze tekst staat in de standaard kleur.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Deze tekst komt in een groem met blauwe achtergrond.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Deze tekst staat in het rood met blauwe achtergrond.");
            Console.WriteLine("ERROR!!! VERANDER HET TERUG NAAR DE STANDAARD...");
            Console.ResetColor();
            Console.WriteLine("Het programma is nu weer oke sluit maar af.");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n");
            }
        }
    }
}
