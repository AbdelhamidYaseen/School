using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammeren
{
    internal class Arrays
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
                    "01| Oef 1: ArrayTrueFalse\n" +
                    "02| Oef 2: ArrayOefener1\n" +
                    "03| Oef 3: Boodschappenlijst\n" +
                    "04| Oef 4: Kerstinkopen\n" +
                    "05| Oef 5: Lotto\n" +
                    "06| Oef 6: IntegerIndexOf\n" +
                    "07| Oef 7: BinarySearch\n" +
                    "08| Oef 8: BoodschappenLijstList\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")      { Console.Clear(); ArrayTrueFalse(); }
                else if (selected == "02") { Console.Clear(); ArrayOefener1(); }
                else if (selected == "03") { Console.Clear(); Boodschappenlijst(); }
                else if (selected == "04") { Console.Clear(); Kerstinkopen(); }
                else if (selected == "05") { Console.Clear(); Lotto(); }
                else if (selected == "06") { Console.Clear(); IntegerIndexOf(); }
                else if (selected == "07") { Console.Clear(); BinarySearch(); }
                else if (selected == "08") { Console.Clear(); BoodschappenLijstList(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
        public static void ArrayTrueFalse()
        {
            Boolean[] trueFalse = new Boolean[30];
            Console.WriteLine("Maak een array gevuld met afwisselend true en false (de array is 30 lang)");
            for (int i = 0; i <= trueFalse.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    trueFalse[i] = true;
                }
                else
                {
                    trueFalse[i] = false;
                }
                Console.Write(trueFalse[i].ToString() + ", ");

            }
        }
        public static void ArrayOefener1()
        {
            int[] geheleGetallen = new int[10];
            int som = 0;
            double gemiddelde;
            int grootsteGetal, minGetal;
            Console.WriteLine("Voer 10 gehele getallen in");
            for (int i = 0; i < geheleGetallen.Length - 1; i++)
            {
                geheleGetallen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("******");
            grootsteGetal = geheleGetallen[0];
            for (int i = 0; i < geheleGetallen.Length - 1; i++)
            {
                som += geheleGetallen[i];
                if (grootsteGetal < geheleGetallen[i])
                {
                    grootsteGetal = geheleGetallen[i];
                }
            }
            gemiddelde = som / geheleGetallen.Length;
            Console.WriteLine($"Som is {som}, Gemiddelde is {gemiddelde}, Grootste getal is {grootsteGetal}");
            Console.WriteLine("");
            Console.WriteLine("Geef minimumgetal in?");
            minGetal = Convert.ToInt32(Console.ReadLine());
            if (minGetal > grootsteGetal)
            {
                Console.WriteLine("Niets is groter");
            }
            else
            {
                for (int i = 0; i < geheleGetallen.Length - 1; i++)
                {
                    if (geheleGetallen[i] > minGetal)
                    {
                        Console.Write(geheleGetallen[i].ToString() + " ");
                    }
                }
            }
        }
        public static void Boodschappenlijst()
        {
            int aantalBoodschappen;
            string item, kopenOfNiet, gekocht;
            Console.WriteLine("We gaan de boodschappenlijst samenstellen. hoeveel items wil je opschrijven?");
            aantalBoodschappen = Convert.ToInt32(Console.ReadLine());
            string[] boodschappenlijst = new string[aantalBoodschappen];
            for (int i = 0; i < aantalBoodschappen; i++)
            {
                Console.WriteLine($"Wat is item {i + 1} op je lijst?");
                item = Console.ReadLine();
                boodschappenlijst[i] = item;
            }
            Array.Sort(boodschappenlijst);
            Console.WriteLine("Dit is je gesorteerde lijst:");
            for (int i = 0; i < aantalBoodschappen; i++)
            {
                Console.WriteLine($"{i + 1}: {boodschappenlijst[i]}");
            }
            Console.WriteLine("Op naar de winkel!");
            do
            {
                Console.WriteLine("Welk item heb je gekocht?");
                gekocht = Console.ReadLine();
                if (Array.IndexOf(boodschappenlijst, gekocht) < 0)
                {
                    Console.WriteLine("Dit item staat niet op je boodschappenlijst.");
                }
                else
                {
                    boodschappenlijst[Array.IndexOf(boodschappenlijst, gekocht)] = "gekocht";
                }
                Console.WriteLine("Wil je nog winkelen? (ja of nee)");
                kopenOfNiet = Console.ReadLine();
            } while (kopenOfNiet == "ja");
            Console.WriteLine("Naar huis met de boodschappen!");
            Console.WriteLine("Volgende items van je lijst ben je vergeten te kopen:");
            for (int i = 0; i < aantalBoodschappen; i++)
            {
                if (boodschappenlijst[i] != "gekocht")
                {
                    Console.Write($"{boodschappenlijst[i]} ");
                }
            }
        }
        public static void Kerstinkopen()
        {
            int aantalCadeaus;
            double budget;
            double totaalPrijs = 0;
            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            budget = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel cadeautjes wil je kopen?");
            aantalCadeaus = Convert.ToInt32(Console.ReadLine());
            int[] cadeaus = new int[aantalCadeaus];
            for (int i = 0; i < aantalCadeaus; i++)
            {
                Console.WriteLine($"Prijs van cadeau {i + 1}?");
                cadeaus[i] = Convert.ToInt32(Console.ReadLine());
                totaalPrijs += cadeaus[i];
            }
            if (totaalPrijs >= budget)
            {
                Console.WriteLine($"Je bent al {totaalPrijs - budget} Over het budget!");
            }
            Console.WriteLine("Info over je aankopen:");
            Console.WriteLine($"Totaal bedrag: {totaalPrijs} euro.");
            Console.WriteLine($"Duurste cadeau: {cadeaus.Max()} euro.");
            Console.WriteLine($"Goedkoopste cadeau: {cadeaus.Min()} euro.");
            Console.WriteLine($"Gemiddelde prijs: {cadeaus.Sum() / aantalCadeaus} euro.");
        }
        public static void Lotto()
        {
            Random random = new Random();
            int lottoGetal;
            int[] lottoTrekking = new int[6];
            int[] geradenLotto = new int[6];
            int aantalJuist = 0;
            for (int i = 0; i < lottoTrekking.Length; i++)
            {
                do
                {
                    lottoGetal = random.Next(1, 43);
                }
                while (Array.IndexOf(lottoTrekking, lottoGetal) >= 0);
                lottoTrekking[i] = lottoGetal;
            }
            Array.Sort(lottoTrekking);
            Console.WriteLine("Geef je lotto getallen (getallen moeten tussen 1 en 42 liggen)");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Geef lotto nummer {i + 1}");
                geradenLotto[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(geradenLotto);
            Console.WriteLine("Je gekozen cijfers zijn:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(geradenLotto[i].ToString() + " ");
            }
            Console.WriteLine("\r\nDe trekking cijfers zijn:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(lottoTrekking[i].ToString() + " ");
            }
            for (int i = 0; i < 6; i++)
            {
                if (Array.IndexOf(lottoTrekking, geradenLotto[i]) >= 0)
                {
                    aantalJuist++;
                }
            }
            if (aantalJuist < 3)
            {
                Console.WriteLine("\r\nJe hebt 0 euro gewonnen");
            }
            else if (aantalJuist == 3)
            {
                Console.WriteLine("\r\nJe hebt 10 euro gewonnen");
            }
            else if (aantalJuist == 4)
            {
                Console.WriteLine("\r\nJe hebt 1000 euro gewonnen");
            }
            else if (aantalJuist == 5)
            {
                Console.WriteLine("\r\nJe hebt 100.000 euro gewonnen");
            }
            else if (aantalJuist == 6)
            {
                Console.WriteLine("\r\nJe hebt 10.000.000 euro gewonnen");
            }
        }
        public static void IntegerIndexOf()
        {
            int[] willekeurigGetal = new int[10];
            int zoekGetal;
            Console.WriteLine("Geef 10 willekeurige gehele getallen");
            for (int i = 0; i < willekeurigGetal.Length; i++)
            {
                willekeurigGetal[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Welk geheel getal wil je zoeken?");
            zoekGetal = Convert.ToInt32(Console.ReadLine());
            if (Array.IndexOf(willekeurigGetal, zoekGetal) < 0)
            {
                Console.WriteLine($"Je zocht {zoekGetal}, jammer die is niet gevonden.");
            }
            else
            {
                Console.WriteLine($"Je zocht {zoekGetal}, die is gevonden op index {Array.IndexOf(willekeurigGetal, zoekGetal)}");
            }
        }
        public static void BinarySearch()
        {
            string[] autoMerken = { "Citroen", "Mercedes", "Peugeot", "BMW", "Toyota", "AstonMartin", "Ferrari", "Opel", "Lexus", "Wartburg" };
            string zoekwaarde;

            Console.WriteLine("Welk automerk wil u zoeken?");
            zoekwaarde = Console.ReadLine();
            int beginIndex, endIndex, midIndex, index;
            beginIndex = 0;
            endIndex = autoMerken.Length - 1;
            index = (int)(-1);
            bool running = true;
            Array.Sort(autoMerken);
            while (beginIndex <= endIndex && running)
            {
                midIndex = beginIndex + (endIndex - beginIndex) / 2;
                if (autoMerken[midIndex].CompareTo(zoekwaarde) == -1)
                {
                    beginIndex = midIndex + 1;
                }
                else if (autoMerken[midIndex].CompareTo(zoekwaarde) == 1)
                {
                    endIndex = midIndex - 1;
                }
                else
                {
                    index = midIndex;
                    beginIndex = endIndex + 1;
                    running = false;

                }
            }
            if (index == -1)
            {
                Console.WriteLine($"Je zocht {zoekwaarde}, jammer genoeg is deze niet gevonden.");
            }
            else
            {
                Console.WriteLine($"Je zocht {zoekwaarde}, die is gevonden op index {index}");
            }

        }
        public static void BoodschappenLijstList()
        {
            List<String> items = new List<String>();
            List<String> boughtItems = new List<String>();
            string input;
            bool running = true;
            bool doneShopping = false;
            while (running)
            {
                Console.WriteLine($"Wat is item {items.Count() + 1} op je lijst?");
                input = Console.ReadLine();
                if (input != "")
                {
                    items.Add(input);
                }
                else
                {
                    running = false;
                }

            }
            Console.WriteLine("Dit is de gesorteerde lijst");
            items.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i]}");
            }
            Console.WriteLine("Op naar de winkel");
            while (!doneShopping)
            {
                Console.WriteLine("Welke items heb je gekocht?");
                input = Console.ReadLine();
                if (items.Contains(input))
                {
                    items.Remove(input);
                    boughtItems.Add(input);
                }
                Console.WriteLine("Nog winkelen? (Ja of Nee)");
                input = Console.ReadLine();
                if (input.ToLower() == "Nee".ToLower())
                {
                    doneShopping = true;
                }
                else if (input.ToLower() == "Ja".ToLower())
                {

                }
            }
            Console.WriteLine("Volgende items van je lijst ben je vergeten te kopen:");
            for (int i = 0; i < items.Count(); i++)
            {
                Console.Write($"{items[i]} ");
            }
        }

    }
}
