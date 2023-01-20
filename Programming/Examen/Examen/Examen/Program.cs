using System;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("1. Oefening 1 (spamfilter)");
            Console.WriteLine("2. Oefening 2 (getallencode)");
            Console.WriteLine("3. Oefening 3 (TextCell)");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1) {
                Console.WriteLine("spamfilter");
                LosseOefeningen.SpamFilter();
            }
            else if (answer == 2)
            {
                Console.WriteLine("getallencode");
                LosseOefeningen.OntcijferBestand();
            }
            else
            {
                //Hier ben ik niet geraakt spendeer geen tijd eraan
                TextCell.TextCellMain();
            }
        }

    }
}