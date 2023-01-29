using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class EenProgrammaSchrijvenInCSharp
    {
        public static void MijnEersteMethode()
        {
            Console.WriteLine("Mijn eerste code werkt");
        }

        public static void MijnEersteProgramma()
        {
            Console.Write("Typ je voornaam: ");
            string voornaam = Console.ReadLine();
            Console.Write("Typ je achernaam: ");
            string achternaam = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Dus je naam is: " + achternaam + " " + voornaam);
            Console.WriteLine("Of: " + voornaam + " " + achternaam);

        }

        public static void Rommelzin()
        {
            Console.WriteLine("Wat is je favoriete kleur?");
            Console.Write("> ");
            string kleur = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete eten?");
            Console.Write("> ");
            string eten = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete auto");
            Console.Write("> ");
            string auto = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete film?");
            Console.Write("> ");
            string film = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete boek?");
            Console.Write("> ");
            string boek = Console.ReadLine();
            Console.WriteLine("Je favoriete kleur is " + eten + ". Je eet graag " + auto + ". je lievelingsfilm is " + boek + " en je favoriete boek is " + film + ".");
        }

        public static void GekleurdeRommelzin()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wat is je favoriete kleur?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("> ");
            string kleur = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wat is je favoriete eten?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("> ");
            string eten = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Wat is je favoriete auto");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("> ");
            string auto = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wat is je favoriete film?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("> ");
            string film = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wat is je favoriete boek?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("> ");
            string boek = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Je favoriete kleur is " + eten + ". Je eet graag " + auto + ". je lievelingsfilm is " + boek + " en je favoriete boek is " + film + ".");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Keuzemenu()
        {
            int oefening;
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - Mijn eerste methode");
            Console.WriteLine("2 - Mijn eerste programma");
            Console.WriteLine("3 - Rommelzin");
            Console.WriteLine("4 - Gekleurde rommelzin");
            oefening = Convert.ToInt32(Console.ReadLine());

            if (oefening > 4)
            {
                Console.WriteLine("Ongeldige keuze");
                Console.Clear();
                Console.WriteLine("Welke oefening kies je?");
                Console.WriteLine("1 - Mijn eerste methode");
                Console.WriteLine("2 - Mijn eerste programma");
                Console.WriteLine("3 - Rommelzin");
                Console.WriteLine("4 - Gekleurde rommelzin");
                oefening = Convert.ToInt32(Console.ReadLine());
            }
            if (oefening == 1)
            {
                Console.Clear();
                EenProgrammaSchrijvenInCSharp.MijnEersteMethode();
            }
            if (oefening == 2)
            {
                Console.Clear();
                EenProgrammaSchrijvenInCSharp.MijnEersteProgramma();
            }
            if (oefening == 3)
            {
                Console.Clear();
                EenProgrammaSchrijvenInCSharp.Rommelzin();
            }
            if (oefening== 4)
            {
                Console.Clear();
                EenProgrammaSchrijvenInCSharp.GekleurdeRommelzin();
            }

        }
    }
}
