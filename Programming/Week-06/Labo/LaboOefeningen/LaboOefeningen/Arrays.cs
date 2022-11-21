using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class Arrays
    {
        public static void ArrayTrueFalse(){
            bool[] trueFalseArray = { true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false };
            for (int i = 0; i < trueFalseArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    trueFalseArray[i] = true;
                    Console.Write($"{trueFalseArray[i]} ");
                }
                else 
                {
                    trueFalseArray[i] = false;
                    Console.Write($"{trueFalseArray[i]} ");
                }
            }


        }
        public static void ArrayOefener1()
        {
            int[] getallen = new int[10];
            int inputGetal;
            Console.WriteLine("Voer 10 gehele getallen in");
            for (int i = 0; i < getallen.Length; i++)
            {
                inputGetal = Convert.ToInt32(Console.ReadLine());
                getallen[i] = inputGetal; 
            }
            int som = 0;
            int grootste = getallen[0];
            for (int i = 0; i < getallen.Length; i++)
            {
                som = som + getallen[i];
                if (getallen[i] > grootste) {
                    grootste = getallen[i];
                }
            }
            double gemiddelde = Convert.ToDouble(som) /getallen.Length;
            Console.WriteLine("*******************************");
            Console.WriteLine($"Som is {som}\nGrootste getal is {grootste}\nGemiddelde is {gemiddelde}");
            Console.WriteLine("*******************************");
            Console.WriteLine("Geef minimum getal in:");
            int minimumgetal;
            minimumgetal = Convert.ToInt32(Console.ReadLine());
            if (minimumgetal > grootste) {
                Console.WriteLine("Niets is groter");
            }
            else {
                for (int i = 0; i < getallen.Length; i++)
                {
                    if (getallen[i] > minimumgetal)
                    {
                        Console.Write($"{getallen[i]} ");
                    }
                }
            }
        }
        public static void Boodschappenlijst()
        {
            int aantal;
            Console.WriteLine("We gaan de boodschappenlijst samenstellen. Hoeveel items wil je opschrijven?");
            aantal = Convert.ToInt32(Console.ReadLine());
            string[] items = new string[aantal];
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"Wat is item {i+1} op je lijst.");
                string invoerWaarde = Console.ReadLine();
                items[i] = invoerWaarde;
            }
            Array.Sort(items);
            Console.WriteLine("Dit is je gesorteerde lijst");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i+1} {items[i]}");
            }
            Console.WriteLine("Op naar de winkel");
            string gekochtItem;
            string nogWinkelen;
            nogWinkelen = "ja";
            while (nogWinkelen == "ja")
            {
                Console.WriteLine("Welk item heb je gekocht");
                gekochtItem = Console.ReadLine();
                if (Array.IndexOf(items,gekochtItem) < 0)
                {
                    Console.WriteLine("Dit item bevindt zich niet op de lijst!");
                    Console.WriteLine("Nog winkelen? (ja of nee)");
                    nogWinkelen = Console.ReadLine();
                }
                else 
                {
                    items[Array.IndexOf(items, gekochtItem)] = "gekocht";
                    Console.WriteLine("Nog winkelen? (ja of nee)");
                    nogWinkelen = Console.ReadLine();
                }
                Console.WriteLine("Naar huis met de boodschappen!");
                Console.WriteLine("Volgende items van je lijst ben je vergeten te kopen");
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] != "gekocht")
                    {
                        Console.WriteLine($"{items[i]} ");
                    }
                }
            }
        }
        /*
        public static void KerstInkopen()
        {
            int 
            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            int budget = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel cadeautjes wil je kopen?");
            int aantalCads = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < aantalCads; i++)
            {
                Console.WriteLine($"Prijs van cadeau {i+1}");
            }
            Console.WriteLine($"Je bent al {} over het budget!");

        }
        */
        public static void Lotto()
        {


        }
        public static void IntegerIndexOf()
        {


        }
        public static void BinarySearch()
        {


        }
        public static void BoodschappenlijstList()
        {


        }
        public static void KerstinkopenList()
        {


        }
    }
}
