using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public static void Wachtwoord()
        {
            string PSW = "AP";
            int aantal = 0;
            string wachtwoord;


            while (aantal < 3)
            {
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
        public static void Feestje()
        {
            bool recruiting = true;
            int personen = 0;
            string namenLijst = "";
            while (recruiting)
            {
                string answer;
                Console.Write("Wil je een volgende persoon inschrijven (ja of nee) ");
                answer = Console.ReadLine();
                if (answer == "ja")
                {
                    Console.Write("Geef de naam: ");
                    namenLijst = String.Concat(namenLijst, Console.ReadLine()) + " ";
                    personen++;
                }
                else if (answer == "no")
                {
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
        public static void AantalDigits()
        {
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
        public static void VanMin100Tot100()
        {
            for (int i = -100; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("============================================");
            for (int i = -100; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

        }
        public static void EenTafel()
        {
            int number;
            Console.WriteLine("Van welk getal wil je de tafel van vermenigvulding zien");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {number} is {i * number}");
            }
        }
        public static void Veelvouden6En8()
        {
            for (int i = 2; i < 100; i += 2)
            {
                if (i % 6 == 0 || i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Priemchecker(){
            int getal;
            int prime = 0;
            Console.WriteLine("Geef een getal in:");
            getal = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= getal; i++)
            {
                if (getal % i == 0)
                {
                    prime++;
                }
            }
            if (prime == 2)
            {
                Console.WriteLine($"{getal} is een priemgetal");
            }
            else {
                Console.WriteLine($"{getal} is geen priemgetal");
            }
        }
        public static void PriemGenerator() {
            {
                int getal, hoogste;
                int prime = 0;
                string priemgetallen = "";
                Console.WriteLine("Priemgetallen van (laagste getal):");
                getal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("tot en met (hoogste getal)");
                hoogste = Convert.ToInt32(Console.ReadLine());
                while (getal <= hoogste)
                {
                    for (int i = 1; i <= getal; i++)
                    {
                        if (getal % i == 0)
                        {
                            prime++;
                        }
                    }
                    if (prime == 2)
                    {
                        priemgetallen += " " + getal.ToString();
                        getal++;
                        prime = 0;
                    }
                    else
                    {
                        getal++;
                        prime = 0;
                    }

                }
                Console.WriteLine(priemgetallen);
            }
        }
        public static void FibonacciReeks()
        {
            int intGetal1, intGetal2, intVervangGetal, intAantalKeer;

            intGetal1 = 0;
            intGetal2 = 1;
            intVervangGetal = intGetal1;

            Console.WriteLine("Hoeveel getallen wil je te zien krijgen?");
            intAantalKeer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            for (int intTeller = 1; intTeller <= (intAantalKeer + 2); intTeller++)
            {
                Console.WriteLine($"{intGetal1}");
                intVervangGetal = intGetal2;
                intGetal2 = intVervangGetal + intGetal1;
                intGetal1 = intVervangGetal;
            }
        }
    }
}

