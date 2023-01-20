using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammeren
{
    internal class Beslissingen
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
                    "01| Oef 1: SchoenenVerkoper\n" +
                    "02| Oef 2: EvenOneven\n" +
                    "03| Oef 3: PositiefNegatiefNul\n" +
                    "04| Oef 4: BMIBerekenaar\n" +
                    "05| Oef 5: GrootsteVanDrie\n" +
                    "06| Oef 6: Examens\n" +
                    "07| Oef 7: WetVanOhm\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")      { Console.Clear(); SchoenenVerkoper(); }
                else if (selected == "02") { Console.Clear(); EvenOneven(); }
                else if (selected == "03") { Console.Clear(); PositiefNegatiefNul(); }
                else if (selected == "04") { Console.Clear(); BMIBerekenaar(); }
                else if (selected == "05") { Console.Clear(); GrootsteVanDrie(); }
                else if (selected == "06") { Console.Clear(); Examens(); }
                else if (selected == "07") { Console.Clear(); WetVanOhm(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
        public static void SchoenenVerkoper()
        {
            double prijs = 50;
            int aantal;
            string klantenkaart;
            Console.WriteLine("Hebt u een klanten kaart? (Ja of Nee)");
            klantenkaart = Console.ReadLine();
            Console.WriteLine("Hoeveel aantal paar schoenen wil je kopen?");
            aantal = Convert.ToInt32(Console.ReadLine());
            prijs = prijs * aantal;

            if (aantal > 2 && klantenkaart == "Ja")
            {
                prijs = prijs - prijs * 0.10;
            }
            Console.WriteLine($"De prijs voor {aantal} paar schoenen is {prijs} euro");
        }
        public static void EvenOneven()
        {
            int getal;
            Console.WriteLine("Geef een getal:");
            getal = Convert.ToInt32(Console.ReadLine());
            if (getal % 2 == 0)
            {
                Console.WriteLine($"Het getal {getal} is even");
            }
            else
            {
                Console.WriteLine($"Het getal {getal} is oneven");
            }
        }
        public static void PositiefNegatiefNul()
        {
            int getal;

            Console.WriteLine("Geef een getal");
            getal = Convert.ToInt32(Console.ReadLine());
            if (getal > 0)
            {
                Console.WriteLine($"Het getal {getal} is positief");
            }
            else if (getal < 0)
            {
                Console.WriteLine($"Het getal {getal} is negatief");
            }
            else
            {
                Console.WriteLine("Het getal is nul");
            }
        }
        public static void BMIBerekenaar()
        {
            int gewicht;
            double lengte, bmi;
            Console.WriteLine("Wat is je gewicht?");
            gewicht = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is je lengte?");
            lengte = Convert.ToDouble(Console.ReadLine());


            bmi = gewicht / Math.Pow(lengte, 2);
            if (bmi < 18.5)
            {
                Console.WriteLine($"Je hebt een BMI van {bmi}. Je hebt ondergewicht.");
            }
            else if (bmi > 18.5 && bmi < 25)
            {
                Console.WriteLine($"Je hebt een BMI van {bmi}. Je hebt een normaal gewicht.");
            }
            else if (bmi > 25 && bmi < 30)
            {
                Console.WriteLine($"Je hebt een BMI van {bmi}. Je hebt overgewicht.");
            }
            else if (bmi > 30 && bmi < 40)
            {
                Console.WriteLine($"Je hebt een BMI van {bmi}. Je bent zwaarlijvig.");
            }
            else if (bmi > 40)
            {
                Console.WriteLine($"Je hebt een BMI van {bmi}. Je hebt obesitas.");
            }
        }
        public static void GrootsteVanDrie()
        {
            int eersteGetal;
            int tweedeGetal;
            int derdeGetal;

            Console.Write("Geef het eerste getal in: ");
            eersteGetal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het tweede getal in: ");
            tweedeGetal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het derde getal in: ");
            derdeGetal = Convert.ToInt32(Console.ReadLine());
            if (eersteGetal > tweedeGetal && eersteGetal > derdeGetal)
            {
                Console.WriteLine($"Het eerste getal ({eersteGetal}) is het grootste.");
            }
            else if (tweedeGetal > eersteGetal && tweedeGetal > derdeGetal)
            {
                Console.WriteLine($"Het tweede getal ({tweedeGetal}) is het grootste.");
            }
            else
            {
                Console.WriteLine($"Het derde getal ({derdeGetal}) is het grootste");
            }
        }
        public static void Examens()
        {
            int examenEen, examenTwee, examenDrie, onvoldoendes;
            double gemiddelde;

            Console.Write("Geef het resultaat in van het eerste examen: ");
            examenEen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het resultaat in van het tweede examen: ");
            examenTwee = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het resultaat in van jet derde examen: ");
            examenDrie = Convert.ToInt32(Console.ReadLine());
            gemiddelde = (examenEen + examenTwee + examenDrie) / 3;
            onvoldoendes = 0;

            if (examenEen < 50)
            {
                onvoldoendes = onvoldoendes + 1;
            }
            if (examenTwee < 50)
            {
                onvoldoendes = onvoldoendes + 1;
            }
            if (examenDrie < 50)
            {
                onvoldoendes = onvoldoendes + 1;
            }
            if (gemiddelde > 50 && onvoldoendes <= 1)
            {
                Console.WriteLine("Je bent geslaagd!");
            }
            else
            {
                Console.WriteLine("Je bent niet geslaagd!");
            }
        }
        public static void WetVanOhm()
        {
            string berekenen;
            double Spanning, weerstand, stroomsterkte;

            Console.WriteLine("Wat wil je berekenen: spanning, weerstand of stroomsterkte?");
            berekenen = Console.ReadLine();

            if (berekenen == "spanning")
            {
                Console.Write("Wat is de weerstand? ");
                weerstand = Convert.ToDouble(Console.ReadLine());
                Console.Write("Wat is de stroomsterkte? ");
                stroomsterkte = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De spanning is {stroomsterkte * weerstand}.");
            }
            if (berekenen == "weerstand")
            {
                Console.Write("Wat is de spanning? ");
                Spanning = Convert.ToDouble(Console.ReadLine());
                Console.Write("Wat is de stroomsterkte? ");
                stroomsterkte = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De weerstand is {Spanning / stroomsterkte}.");
            }
            if (berekenen == "stroomsterkte")
            {
                Console.Write("Wat is de weerstand? ");
                weerstand = Convert.ToDouble(Console.ReadLine());
                Console.Write("Wat is de spanning? ");
                Spanning = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De stroomsterkte is {Spanning / weerstand}.");
            }
        }

    }
}
