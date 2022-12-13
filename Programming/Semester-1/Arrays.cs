using System;
using System.Linq;
using System.Collections.Generic;

namespace LaboOefeningen
{
    internal class Arrays
    {
        public static void Keuzemenu()
        {
            int oefening;
            do
            {
                Console.WriteLine("Welke oefening kies je?");
                Console.WriteLine("1 - ArrayTrueFalse");
                Console.WriteLine("2 - ArrayOefener1");
                Console.WriteLine("3 - Boodschappenlijst");
                Console.WriteLine("4 - Kerstinkopen");
                Console.WriteLine("5 - Lotto");
                Console.WriteLine("6 - IntegerIndexOf");
                Console.WriteLine("7 - Binary search");
                Console.WriteLine("8 - Boodschappenlijst-list");
                Console.WriteLine("9 - Kerstinkopen list");
                oefening = Convert.ToInt32(Console.ReadLine());
                if (oefening == 1)
                {
                    Console.Clear();
                    Arrays.ArrayTrueFalse();
                }
                else if (oefening == 2)
                {
                    Console.Clear();
                    Arrays.ArrayOefener1();
                }
                else if (oefening == 3)
                {
                    Console.Clear();
                    Arrays.Boodschappenlijst();
                }
                else if (oefening == 4)
                {
                    Console.Clear();
                    Arrays.Kerstinkopen();
                }
                else if (oefening == 5)
                {
                    Console.Clear();
                    Arrays.Lotto();
                }
                else if (oefening == 6)
                {
                    Console.Clear();
                    Arrays.IntegerIndexOf();
                }
                else if (oefening == 7)
                {
                    Console.Clear();
                    Arrays.BinarySearch();
                }
                else if (oefening == 8)
                {
                    Console.Clear();
                    Arrays.BoodschappenLijstList();
                }
                else if (oefening == 9)
                {
                    Console.Clear();
                    Arrays.Keuzemenu();
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze");
                }
            } while (oefening > 9 || oefening < 0);
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
                if(autoMerken[midIndex].CompareTo(zoekwaarde) == -1)
                {
                    beginIndex = midIndex + 1;
                }
                else if(autoMerken[midIndex].CompareTo(zoekwaarde) == 1)
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
            if(index == -1)
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
                Console.WriteLine($"Wat is item {items.Count() +1} op je lijst?");
                input = Console.ReadLine();
                if(input != "")
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
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i+1}: {items[i]}");
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
                if(input.ToLower() == "Nee".ToLower())
                {
                    doneShopping = true;
                }else if(input.ToLower() == "Ja".ToLower())
                {
                    
                }
            }
            Console.WriteLine("Volgende items van je lijst ben je vergeten te kopen:");
            for(int i=0; i<items.Count(); i++)
            {
                Console.Write($"{items[i]} ");
            }
        }

        public static void KerstinkopenList()
        {
            int budget;
            bool running = true;
            int input;  
            List<int> prices = new List<int>();
            while (running)
            {
                for(int i = 0; i < prices.Count; i++)
                {
                    Console.WriteLine($"Prijs van cadeau {prices.Count+1}");
                    // TODO: Later do this because i am me
                }
            }
        }
    }
}

