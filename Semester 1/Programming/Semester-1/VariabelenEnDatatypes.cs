using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class VariabelenEnDatatypes
    {
        public static void Optellen()
        {
            Console.WriteLine("Wat is het eerste getal?");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int som = getal1 + getal2;
            Console.WriteLine("De som is: " + som + ".");

        }


        public static void VerbruikWagen()
        {
            double tankVoorRit;
            double tankNaRit;
            double kmVoorRit;
            double kmNaRit;
            double verbruik;

            Console.Write("Geef het aantal liter in de tank voor de rit: ");
            tankVoorRit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het aantal liter in de tank na de rit: ");
            tankNaRit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef de kilometerstand van je auto voor de rit: ");
            kmVoorRit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef de kilometerstand vaan je auto na de rit: ");
            kmNaRit = Convert.ToDouble(Console.ReadLine());
            verbruik = (100 * (tankVoorRit - tankNaRit) / (kmNaRit - kmVoorRit));
            Console.WriteLine("Het verbruik van de auto is: " + verbruik);
        }


        public static void BeetjeWiskunde()
        {
            float eersteBewerking, tweedeBewerking, derdeBewerking, vierdeBewerking;
            eersteBewerking = -1 + 4 * 6;
            tweedeBewerking = (35 + 5) * 7;
            derdeBewerking = 14 + -4 * 6 / 11;
            vierdeBewerking = 2 + 15 / 6 * 1 - 7 * 2;
            Console.WriteLine(eersteBewerking);
            Console.WriteLine(tweedeBewerking);
            Console.WriteLine(derdeBewerking);
            Console.WriteLine(vierdeBewerking);
        }


        public static void Gemiddelde()
        {
            float eersteGetal, tweedeGetal, derdeGetal, gemiddelde;
            eersteGetal = 18;
            tweedeGetal = 11;
            derdeGetal = 8;
            gemiddelde = (eersteGetal + tweedeGetal + derdeGetal) / 3;
            Console.WriteLine(gemiddelde);
        }

        public static void Maaltafels()
        {
            int getal;
            getal = 411;
            Console.WriteLine("1 * " + getal + " is " + getal*1);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("2 * " + getal + " is " + getal * 2);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("3 * " + getal + " is " + getal * 3);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("4 * " + getal + " is " + getal * 4);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("5 * " + getal + " is " + getal * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("6 * " + getal + " is " + getal * 6);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("7 * " + getal + " is " + getal * 7);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("8 * " + getal + " is " + getal * 8);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("9 * " + getal + " is " + getal * 9);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("10 * " + getal + " is " + getal * 10);
            Console.ReadKey();
            Console.Clear();
        }


        public static void Ruimte()
        {
            double persoonGewicht, mercuriusGewicht, venusGewicht, aardeGewicht, marsGewicht, jupiterGewicht, saturnusGewicht, uranusGewicht, neptunusGewicht, plutoGewicht;
            mercuriusGewicht = 0.38;
            venusGewicht = 0.91;
            aardeGewicht = 1.00;
            marsGewicht = 0.38;
            jupiterGewicht = 2.34;
            saturnusGewicht = 1.06;
            uranusGewicht = 0.92;
            neptunusGewicht = 1.19;
            plutoGewicht = 0.06;
            Console.Write("Wat is je gewicht? ");
            persoonGewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Op Mercurius voel je je alsof je " + persoonGewicht*mercuriusGewicht + "kg weegt.");
            Console.WriteLine("Op Venus voel je je alsof je " + persoonGewicht*venusGewicht + "kg weegt.");
            Console.WriteLine("Op Aarde voel je je alsof je " + persoonGewicht*aardeGewicht + "kg weegt.");
            Console.WriteLine("Op Mars voel je je alsof je " + persoonGewicht*marsGewicht + "kg weegt.");
            Console.WriteLine("Op Jupiter voel je je alsof je " + persoonGewicht*jupiterGewicht +"kg weegt.");
            Console.WriteLine("Op Saturnus voel je je alsof je " + persoonGewicht*saturnusGewicht + "kg weegt.");
            Console.WriteLine("Op Uranus voel je je alsof je " + persoonGewicht*uranusGewicht + "kg weegt.");
            Console.WriteLine("Op Neptunus voel je je alsof je "+ persoonGewicht*neptunusGewicht+ "kg weegt.");
            Console.WriteLine("Op Pluto voel je je alsof je " + persoonGewicht*plutoGewicht + "kg weegt.");
        }

        public static void Keuzemenu()
        {
            int oefening;
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - Optellen");
            Console.WriteLine("2 - Verbruik wagen");
            Console.WriteLine("3 - Beetje wiskunde");
            Console.WriteLine("4 - Gemiddelde");
            Console.WriteLine("5 - Maaltafels");
            Console.WriteLine("6 - Ruimte");
            oefening = Convert.ToInt32(Console.ReadLine());

            if (oefening > 6)
            {
                Console.WriteLine("Ongeldige keuze");
                Console.Clear();
                Console.WriteLine("Welke oefening kies je?");
                Console.WriteLine("1 - Optellen");
                Console.WriteLine("2 - Verbruik wagen");
                Console.WriteLine("3 - Beetje wiskunde");
                Console.WriteLine("4 - Gemiddelde");
                Console.WriteLine("5 - Maaltafels");
                Console.WriteLine("6 - Ruimte");
                oefening = Convert.ToInt32(Console.ReadLine());
            }
            if (oefening == 1)
            {
                Console.Clear();
                VariabelenEnDatatypes.Optellen();
            }
            if (oefening == 2)
            {
                Console.Clear();
                VariabelenEnDatatypes.VerbruikWagen();
            }
            if (oefening == 3)
            {
                Console.Clear();
                VariabelenEnDatatypes.BeetjeWiskunde();
            }
            if (oefening == 4)
            {
                Console.Clear();
                VariabelenEnDatatypes.Gemiddelde();
            }
            if (oefening == 5)
            {
                Console.Clear();
                VariabelenEnDatatypes.Maaltafels();
            }
            if (oefening == 6)
            {
                Console.Clear();
                VariabelenEnDatatypes.Ruimte();
            }
        }
    }
}
