using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammeren
{
    internal class Introductie
    {

        public static void SelectionScreen()
        {
            string selected;
            bool flick = true;
            do
            {
                Console.Clear();
                Console.WriteLine("======================================================");
                Console.WriteLine("Please select a excercise");
                Console.WriteLine("======================================================");
                Console.WriteLine(
                    "01| Oef 1: Rommelzin\n" +
                    "02| Oef 2: GekleurdeRommelzin\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")      { Console.Clear(); RommelZin(); }
                else if (selected == "02") { Console.Clear(); GekleurdeRommelZin(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }

        public static void RommelZin() 
        {
            Console.WriteLine("Wat is je favoriete kleur?");
            string kleur = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete eten?");
            string eten = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete film?");
            string film = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete boek?");
            string boek = Console.ReadLine();
        }
        public static void GekleurdeRommelZin() 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wat is je favoriete kleur?");
            Console.ResetColor();
            string kleur = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wat is je favoriete eten?");
            Console.ResetColor();
            string eten = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Wat is je favoriete film?");
            Console.ResetColor();
            string film = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wat is je favoriete boek?");
            Console.ResetColor();
            string boek = Console.ReadLine();
        }
    }
}
