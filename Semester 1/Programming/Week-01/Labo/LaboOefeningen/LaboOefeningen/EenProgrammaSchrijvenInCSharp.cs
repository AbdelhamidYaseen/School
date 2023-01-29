using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class EenProgrammaSchrijvenInCSharp
    {

        public static void MijnEersteMethode() {
            Console.WriteLine("Mijn eerste methode werkt!");
        }

        public static void MijnEersteProgramma() {
            string voornaam;
            string achternaam;

            Console.WriteLine("Dit is mijn eerste C#-programma");
            Console.WriteLine("*******************************");
            Console.Write("Type je voornaam: ");
            voornaam = Console.ReadLine();
            Console.Write("Type je achternaam: ");
            achternaam = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Dus je naam is: " + achternaam + " " + achternaam);
            Console.WriteLine("Of " + voornaam + " " + achternaam);
        }

        public static void Rommelzin() {
            string kleur;
            string eten;
            string auto;
            string film;
            string boek;

            Console.WriteLine("Wat is je favoriete kleur?");
            kleur = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete eten?");
            eten = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete auto?");
            auto = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete film");
            film = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete boek?");
            boek = Console.ReadLine();
            Console.WriteLine(
                "Je favoriete kleur is "
                + kleur
                + ".\n"
                +"Je favoriete eten is "
                + eten 
                +".\n"
                +"Je favoriete auto is "
                + auto
                +".\n"
                +"Je favoriete film is "
                + film
                +".\n"
                +"Je favoriete boek is "
                +boek
                +".\n");
        }

        public static void GekleurdeRommelzin() {
            string kleur;
            string eten;
            string auto;
            string film;
            string boek;


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wat is je favoriete kleur?");
            Console.ResetColor();
            kleur = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wat is je favoriete eten?");
            Console.ResetColor();
            eten = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Wat is je favoriete auto?");
            Console.ResetColor();
            auto = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wat is je favoriete film");
            Console.ResetColor();
            film = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wat is je favoriete boek?");
            Console.ResetColor();
            boek = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "> Je favoriete kleur is "
                + kleur
                + ".\n"
                + "> Je favoriete eten is "
                + eten
                + ".\n"
                + "> Je favoriete auto is "
                + auto
                + ".\n"
                + "> Je favoriete film is "
                + film
                + ".\n"
                + "> Je favoriete boek is "
                + boek
                + ".\n");
            Console.ResetColor();
        }
    
    }
}
