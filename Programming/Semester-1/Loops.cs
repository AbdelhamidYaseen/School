using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class Loops
    {
        public static void Keuzemenu()
        {
            int oefening;
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - Countdown");
            Console.WriteLine("2 - Wachtwoord");
            Console.WriteLine("3 - Gemiddelde");
            Console.WriteLine("4 - Feestje");
            Console.WriteLine("5 - Aantal Digits");
            Console.WriteLine("6 - Som Even Getallen");
            Console.WriteLine("7 - Factoren");
            Console.WriteLine("8 - RNA");
            Console.WriteLine("9 - Boekhouder");
            Console.WriteLine("10 - Van -100 tot 100");
            Console.WriteLine("11 - Een tafel");
            Console.WriteLine("12 - Veelvouden 6 en 8");
            Console.WriteLine("13 - Priemchecker");
            Console.WriteLine("14 - Priem generator");
            Console.WriteLine("15 - Rij van Fibonnaci");
            oefening = Convert.ToInt32(Console.ReadLine());

            if (oefening > 15)
            {
                Console.WriteLine("Welke oefening kies je?");
                Console.WriteLine("1 - Countdown");
                Console.WriteLine("2 - Wachtwoord");
                Console.WriteLine("3 - Gemiddelde");
                Console.WriteLine("4 - Feestje");
                Console.WriteLine("5 - Aantal Digits");
                Console.WriteLine("6 - Som Even Getallen");
                Console.WriteLine("7 - Factoren");
                Console.WriteLine("8 - RNA");
                Console.WriteLine("9 - Boekhouder");
                Console.WriteLine("10 - Van -100 tot 100");
                Console.WriteLine("11 - Een tafel");
                Console.WriteLine("12 - Veelvouden 6 en 8");
                Console.WriteLine("13 - Priemchecker");
                Console.WriteLine("14 - Priem generator");
                oefening = Convert.ToInt32(Console.ReadLine());
            }
             else if (oefening == 1)
            {
                Console.Clear();
                Loops.CountDown();
            }
            else if (oefening == 2)
            {
                Console.Clear();
                Loops.Wachtwoord();
            }
            else if (oefening == 3)
            {
                Console.Clear();
                Loops.Gemiddelde();
            }
            else if (oefening == 4)
            {
                Console.Clear();
                Loops.Feestje();
            }
            else if (oefening == 5)
            {
                Console.Clear();
                Loops.AantalCijfers();
            }
            else if (oefening == 6)
            {
                Console.Clear();
                Loops.SomEvenGetallen();
            }
            else if (oefening == 7)
            {
                Console.Clear();
                Loops.Factoren();
            }
            else if (oefening == 8)
            {
                Console.Clear();
                Loops.RNATranscriptie();
            }
            else if (oefening == 9)
            {
                Console.Clear();
                Loops.Boekhouder();
            }
            else if (oefening == 10)
            {
                Console.Clear();
                Loops.VanMin100Tot100();
            }
            else if (oefening == 11)
            {
                Console.Clear();
                Loops.EenTafel();
            }
            else if (oefening == 12)
            {
                Console.Clear();
                Loops.Veelvouden6En8();
            }
            else if (oefening == 13)
            {
                Console.Clear();
                Loops.PriemChecker();
            }
            else if (oefening == 14)
            {
                Console.Clear();
                Loops.PriemGenerator();
            }
            else if (oefening == 15)
            {
                Console.Clear();
                Loops.FibonacciReeks();
            }

        }
        public static void CountDown()
        {
            int getal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            while (getal > 0)
            {
                Console.WriteLine(getal);
                getal--;
            }
            Console.WriteLine("Start!");
        }
        public static void Wachtwoord()
        {
            string PSW, wachtwoord;
            int aantal;
            PSW = "AP";
            aantal = 0;
            do
            {
                Console.Write("Geef het wachtwoord in! ");
                wachtwoord = Console.ReadLine();
                aantal++;
            } while (wachtwoord != PSW);

            Console.WriteLine("Wachtwoord in orde!");
            Console.WriteLine($"Aantal pogingen: {aantal}");
        }
        public static void Gemiddelde()
        {
            double getal = 0;
            double gemiddelde = 0;
            int aantal = 0;
            do
            {
                Console.Write("Geef het volgende getal in (stoppen met 0) ");
                getal = Convert.ToDouble(Console.ReadLine());
                gemiddelde += getal;
                aantal++;
            } while (getal != 0);
                    
            Console.WriteLine($"Het gemiddelde: {gemiddelde/(aantal-1)}");
        }
        public static void Feestje()
        {
            string keuze;
            string naam;
            keuze = "";
            int count = 0;

            while (keuze != "nee")
            {
                Console.Write("Wil je de volgende persoon inschrijven? (ja of nee) ");
                keuze = Console.ReadLine();
                if (keuze == "ja")
                {
                    Console.Write("Geef de naam: ");
                    naam = Console.ReadLine();
                }
                count++;
            }
            Console.WriteLine($"Er zijn {count - 1} personen aanwezig.");
        }
        public static void AantalCijfers()
        {
            int getal;
            int digits = 0;
            Console.Write("Geef een geheel getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            while (getal >0.9)
            {
                digits++;
                getal = getal / 10;
            }
            Console.WriteLine($"Het ingegeven getal bestaat ui {digits} cijfers.");
        }
        public static void SomEvenGetallen()
        {
            int j, n, som;
            j = 1;
            som = 0;
            Console.Write("Geef n in: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (j <= n)
            {
                if (j % 2 == 0)
                {
                    som += j;
                    Console.Write($"Even getal {j}.");
                    Console.WriteLine($"De som van de getallen tot nu is: {som}.");
                }
                j++;
            }
        }
        public static void Factoren()
        {
            int getal, x;
            x = 1;
            string factoren = "Factoren zijn: ";
            Console.WriteLine("Geef een getal (groter dan 1): ");
            getal = Convert.ToInt32(Console.ReadLine());
            while (x < getal)
            {
                
                if (getal % x == 0)
                {
                    factoren = factoren + x.ToString() + ", ";
                    x++;
                }
                else
                {
                    x++;
                }
            }
            Console.WriteLine($"{factoren}{getal}");
        }
        public static void RNATranscriptie()
        {
            string DNA, RNA;
            RNA = "";
            do
            {
                Console.WriteLine("Geef de letter in (stoppen met 'stop')");
                DNA = Console.ReadLine();
                if (DNA == "G")
                {
                    RNA += "C";
                }
                else if (DNA == "C")
                {
                    RNA += "G";
                }
                else if (DNA == "T")
                {
                    RNA += "A";
                }
                else if (DNA == "A")
                {
                    RNA += "U";
                }
            } while (DNA != "stop");
            Console.WriteLine($"De RNA string is: {RNA}");
        }
        public static void Boekhouder()
        {
            int getal;
            int balans = 0;
            int posGet = 0;
            int negGet = 0;
            int gemiddelde = 0;
            int counter = 0;
            do
            {
                Console.WriteLine("Geef een getal");
                getal = Convert.ToInt32(Console.ReadLine());
                counter++;
                balans += getal;
                if (getal > 0)
                {
                    posGet += getal;
                }
                if (getal < 0)
                {
                    negGet += getal;
                }
                gemiddelde += getal;
                Console.WriteLine($"De balans is {balans}");
                Console.WriteLine($"De som van de positieve getallen is {posGet}");
                Console.WriteLine($"De som van de negatieve getallen is {negGet}");
                Console.WriteLine($"Het gemiddelde is {gemiddelde/counter}");
            } while (true);
            

        }
        public static void VanMin100Tot100()
        {
            for (int i=-100; i<=100; i ++)
            {
                Console.WriteLine(i);
            }
        }
        public static void EenTafel()
        {
            int input;

            Console.WriteLine($"Van welk getal wil je de tafel van vermenigvuldiging zien?");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {input} = {i * input}");
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
        public static void PriemChecker()
        {
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
            else
            {
                Console.WriteLine($"{getal} is geen priemgetal");
            }
        }
        public static void PriemGenerator()
        {
            int getal, hoogste;
            int prime = 0;
            string priemgetallen ="";
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
        public static void FibonacciReeks()
        {
            int eersteGetal = 0;
            int tweedeGetal = 1;
            int som = eersteGetal;
            int aantal;

            Console.WriteLine("Hoeveel getallen wil je te zien krijgen?");
            aantal = Convert.ToInt32(Console.ReadLine());
            for (int counter = 1; counter <= (aantal + 2); counter++)
            {
                Console.WriteLine($"{eersteGetal}");
                som = tweedeGetal;
                tweedeGetal = som + eersteGetal;
                eersteGetal = som;
            }
        }
    }
}
