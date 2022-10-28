using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_Oefeningen
{
    internal class Loops
    {
        public static void CountDown()
        {
            uint beginGetal;

            Console.WriteLine("Van waar wil je beginnen aftellen?");
            beginGetal = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("========================================");
            while (beginGetal <= 10)
            {
                Console.WriteLine(beginGetal);
                beginGetal--;
            }
            Console.WriteLine("========================================");
            Console.WriteLine("START");
        }
        public static void Wachtwoord() {
            string PSW = "AP";
            int aantal = 0;
            string wachtwoord;


            while (aantal < 3) {
                Console.WriteLine($"Nog {3 - aantal} pogingen over.");
                Console.WriteLine("===================");
                Console.Write("Geef het wachtwoord in: ");
                Console.WriteLine("===================");
                wachtwoord = Console.ReadLine();
                if (wachtwoord == PSW)
                {
                    Console.WriteLine("Wachtwoord correct!");
                    aantal = 5;
                }
                else if (aantal > 3)
                {
                    Console.WriteLine("Aantal pogingen overschreden");
                }
                else 
                {
                    aantal++;
                }
            }

        }
        public static void Gemiddelde()
        {

            int input;
            int counter = 0;
            double result = 0;

            do
            {
                Console.Write("Geef het volgende getal in (stoppen met 0): ");
                input = Convert.ToInt32(Console.ReadLine());
                result += input;
                counter++;
            } while (input != 0);
            double finalResult = result / (counter - 1);
            Console.Write($"Het gemiddelde is: {finalResult}");
        }
        public static void Feestje() {
            bool recruiting = true;
            int personen = 0;
            string namenLijst = "";
            while (recruiting) {
                string answer;
                Console.Write("Wil je een volgende persoon inschrijven (ja of nee) ");
                answer = Console.ReadLine();
                if (answer == "ja")
                {
                    Console.Write("Geef de naam: ");
                    namenLijst = String.Concat(namenLijst, Console.ReadLine()) + " ";
                    personen++;
                }
                else if (answer == "no") {
                    recruiting = false;
                }
                else if (personen <= 20)
                {
                    recruiting = false;
                }
                
                Console.WriteLine();
            
            }
            Console.WriteLine($"Lijst van aanwezigen: {namenLijst}");
            Console.WriteLine($"Er zijn {personen} personen aanwezig");
        
        }
        public static void AantalDigits() {
            int input;
            int count = 1;
            Console.Write("Geef een geheel getal in: ");
            input = Convert.ToInt32(Console.ReadLine());
            do
            {
                count++;
                input = input / 10;
            } 
            while (input / 10 > 0.1);
            Console.WriteLine($"Het ingegeven getal bestaat uit {count} cijfers");
        }
    }
}
