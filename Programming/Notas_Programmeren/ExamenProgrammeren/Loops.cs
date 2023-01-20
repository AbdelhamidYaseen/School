using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammeren
{
    internal class Loops
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
                    "01| Oef 1: Countdown\n" +
                    "02| Oef 2: Wachtwoord\n" +
                    "03| Oef 3: Gemiddelde\n" +
                    "04| Oef 4: Feestje\n" +
                    "05| Oef 5: AantalDigits\n" +
                    "06| Oef 6: SomEvenGetallen\n" +
                    "07| Oef 7: Factoren\n" +
                    "08| Oef 8: RNA\n" +
                    "09| Oef 9: Boekhouder\n" +
                    "10| Oef 10: Van-100tot100\n" +
                    "11| Oef 11: EenTafel\n" +
                    "12| Oef 12: Veelvouden6En8\n" +
                    "13| Oef 13: Priemchecker\n" +
                    "14| Oef 14: PriemGenerator\n" +
                    "15| Oef 15: RijVanFibonnaci\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")      { Console.Clear(); CountDown(); }
                else if (selected == "02") { Console.Clear(); Wachtwoord(); }
                else if (selected == "03") { Console.Clear(); Gemiddelde(); }
                else if (selected == "04") { Console.Clear(); Feestje(); }
                else if (selected == "05") { Console.Clear(); AantalCijfers(); }
                else if (selected == "06") { Console.Clear(); SomEvenGetallen(); }
                else if (selected == "07") { Console.Clear(); Factoren(); }
                else if (selected == "08") { Console.Clear(); RNATranscriptie(); }
                else if (selected == "09") { Console.Clear(); Boekhouder(); }
                else if (selected == "10") { Console.Clear(); VanMin100Tot100(); }
                else if (selected == "11") { Console.Clear(); EenTafel(); }
                else if (selected == "12") { Console.Clear(); Veelvouden6En8(); }
                else if (selected == "13") { Console.Clear(); PriemChecker(); }
                else if (selected == "14") { Console.Clear(); PriemGenerator(); }
                else if (selected == "15") { Console.Clear(); FibonacciReeks(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
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

            Console.WriteLine($"Het gemiddelde: {gemiddelde / (aantal - 1)}");
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
            while (getal > 0.9)
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
                Console.WriteLine($"Het gemiddelde is {gemiddelde / counter}");
            } while (true);


        }
        public static void VanMin100Tot100()
        {
            for (int i = -100; i <= 100; i++)
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
