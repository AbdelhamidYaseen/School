using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammeren
{
    internal class VariabelenEnDatatypes
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
                    "01| Oef 1: Optellen\n" +
                    "02| Oef 2: Verbruikwagen\n" +
                    "03| Oef 3: Gemiddelde\n" +
                    "04| Oef 4: Maaltafel\n" +
                    "05| Oef 5: Ruimte\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")      { Console.Clear(); Optellen(); }
                else if (selected == "02") { Console.Clear(); VerbruikWagen(); }
                else if (selected == "03") { Console.Clear(); Gemiddelde(); }
                else if (selected == "04") { Console.Clear(); Maaltafels(); }
                else if (selected == "05") { Console.Clear(); Ruimte(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }

        public static void Optellen() 
        {
            Console.WriteLine("Wat is het eerste getal?");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De som is {firstNumber + secondNumber}"); ;
        }

        public static void VerbruikWagen() 
        {
            Console.Write("Geef het aantal liter in de takn voor de rit: ");
            int beforeTank = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het aantal liter in de tank na de rit: ");
            int afterTank = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef de kilometerstand van je auto voor de rit: ");
            int kmStandBefore = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef de kilometer van je auto na de rit: ");
            int kmStandAfter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Het verbuik van de auto is: {100*(beforeTank-afterTank)/(kmStandAfter-kmStandBefore)}");
        }

        public static void Gemiddelde() 
        {
            Console.WriteLine("Geef 3 positieve getallen");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{(firstNumber+secondNumber+thirdNumber)/3}");
        }

        public static void Maaltafels() 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} * 411 is {i*411}.");
            }
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
            Console.WriteLine("Op Mercurius voel je je alsof je " + persoonGewicht * mercuriusGewicht + "kg weegt.");
            Console.WriteLine("Op Venus voel je je alsof je " + persoonGewicht * venusGewicht + "kg weegt.");
            Console.WriteLine("Op Aarde voel je je alsof je " + persoonGewicht * aardeGewicht + "kg weegt.");
            Console.WriteLine("Op Mars voel je je alsof je " + persoonGewicht * marsGewicht + "kg weegt.");
            Console.WriteLine("Op Jupiter voel je je alsof je " + persoonGewicht * jupiterGewicht + "kg weegt.");
            Console.WriteLine("Op Saturnus voel je je alsof je " + persoonGewicht * saturnusGewicht + "kg weegt.");
            Console.WriteLine("Op Uranus voel je je alsof je " + persoonGewicht * uranusGewicht + "kg weegt.");
            Console.WriteLine("Op Neptunus voel je je alsof je " + persoonGewicht * neptunusGewicht + "kg weegt.");
            Console.WriteLine("Op Pluto voel je je alsof je " + persoonGewicht * plutoGewicht + "kg weegt.");
        }

    }
}
