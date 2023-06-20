using System;
using System.Collections.Generic;
using Vraag.Recepten;

namespace Vraag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void DemonstreerRecepten()
            {
                List<Recept> recepten = new List<Recept>();
                var recept1 = new ReceptWarm(1, "Spaghetti", 30, 2, Moeilijkheidsgraad.normaal);
                var recept2 = new ReceptWarm(2, "Biefstuk friet", 40, 1,
                Moeilijkheidsgraad.moeilijk);
                var recept3 = new ReceptKoud(3, "Salade nicoise", 20, 1,
                Moeilijkheidsgraad.normaal);
                var recept4 = new ReceptKoud(4, "Smoskaas", 5, 1, Moeilijkheidsgraad.makkelijk);
                var recept5 = new ReceptKoud(5, "Koude tapas", 5, 2,
                Moeilijkheidsgraad.makkelijk);
                recept1.Opwarmen(75);
                recept2.Opwarmen(90);
                recept3.Afkoelen(5);
                recept4.Afkoelen(10);
                recept5.Afkoelen(10);
            }
            while (true)
            {
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1. DemonstreerRecepten uitvoeren");
                Console.WriteLine("2. TestGemiddeldWaterpeil uitvoeren");
                try
                {
                    int keuze = int.Parse(Console.ReadLine());
                    switch (keuze)
                    {
                        case 1:
                            DemonstreerRecepten();
                            break;
                        case 2:
                            Console.WriteLine("TODO: zelf implementeren");
                            break;
                        default:
                            Console.WriteLine("Er is geen optie met dat nummer...");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Er liep iets mis...");
                }
            }
        }
    }
}


