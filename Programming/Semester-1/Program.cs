using System;

namespace LaboOefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoofdstuk;
            Console.WriteLine("Welk hoofdstuk kies je?");
            Console.WriteLine("1 - Hoofdstuk 1 - Werken met Visual Studio Code");
            Console.WriteLine("2 - Hoofdstuk 2 - Variablen en Datatypes");
            Console.WriteLine("3 - Hoofdstuk 3 - Strings en hun methodes");
            Console.WriteLine("4 - Hoofdstuk 4 - Beslissingen");
            Console.WriteLine("5 - Hoofdstuk 5 - Loops");
            Console.WriteLine("6 - Hoofdstuk 6 - Arrays");
            Console.WriteLine("7 - Hoofdstuk 7 - Methodes");
            Console.WriteLine("8 - Hoofdstuk 8 - TextCell");

            hoofdstuk = Convert.ToInt32(Console.ReadLine());

            if (hoofdstuk > 8)
            {
                Console.WriteLine("Ongeldige keuze");
                Console.Clear();
                Console.WriteLine("Welk hoofdstuk kies je?");
                Console.WriteLine("1 - Hoofdstuk 1 - Werken met Visual Studio Code");
                Console.WriteLine("2 - Hoofdstuk 2 - Variablen en Datatypes");
                Console.WriteLine("3 - Hoofdstuk 3 - Strings en hun methodes");
                Console.WriteLine("4 - Hoofdstuk 4 - Beslissingen");
                Console.WriteLine("5 - Hoofdstuk 5 - Loops");
                Console.WriteLine("7 - Hoofdstuk 7 - Methodes");
                Console.WriteLine("8 - Hoofdstuk 8 - TextCell");

                hoofdstuk = Convert.ToInt32(Console.ReadLine());

            }
            else if (hoofdstuk == 1)
            {
                Console.Clear();
                EenProgrammaSchrijvenInCSharp.Keuzemenu();
            }
            else if (hoofdstuk == 2)
            {
                Console.Clear();
                VariabelenEnDatatypes.Keuzemenu();
            }
            else if (hoofdstuk == 3)
            {
                Console.Clear();
                StringsEnHunMethoden.Keuzemenu();
            }
            else if (hoofdstuk == 4)
            {
                Console.Clear();
                Beslissingen.Keuzemenu();
            }
            else if (hoofdstuk == 5)
            {
                Console.Clear();
                Loops.Keuzemenu();
            }
            else if(hoofdstuk == 6)
            {
                Console.Clear();
                Arrays.Keuzemenu();
            }
            else if(hoofdstuk == 7)
            {
                Console.Clear();
                Methodes.Keuzemenu();
            }
            else if(hoofdstuk == 8)
            {
                Console.Clear();
                TextCell.TextCellMain();
            }
        }
    }
}
