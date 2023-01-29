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
                    lottoGetal = random.Next(42) + 1;
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
            int[] waardes = new int [10];
            int searchNumber;
            Console.WriteLine("Geef 10 willekeurige gehele getallen");
            for (int i = 0; i < waardes.Length; i++)
            {
                waardes[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Welk geheel getal wil je vinden?");
            searchNumber = Convert.ToInt32(Console.ReadLine());
            if (Array.IndexOf(waardes, searchNumber) < 0)
            {
                Console.WriteLine($"je zocht {searchNumber}, dit bestaat jammergenoeg niet");
            }
            else 
            {
                Console.WriteLine($"Je zocht {searchNumber}, deze bevindt zich op index {Array.IndexOf(waardes,searchNumber)}");
            }
        }
        public static void BinarySearch()
        {
            string[] autoMerken = { "Citroen", "Mercedes", "Peugeot", "BMW", "Toyota", "AstonMartin", "Ferrari", "Opel", "Lexus", "Wartburg" };
            string zoekwaarde;

            Console.WriteLine("Welk automerk wil je zoeken?");
            zoekwaarde = Console.ReadLine();
            int index;
            int beginIndex;
            int eindIndex;
            int middenIndex;
            beginIndex = 0;
            eindIndex = autoMerken.Length - 1;
            index = -1;
            bool valid = true;
            Array.Sort(autoMerken);
            while (beginIndex <= eindIndex && valid)
            {
                middenIndex = beginIndex + (eindIndex - beginIndex) / 2;
                if (autoMerken[middenIndex].CompareTo(zoekwaarde) == -1)
                {
                    beginIndex = middenIndex + 1;
                }
                else if (autoMerken[middenIndex].CompareTo(zoekwaarde) == 1) 
                {
                eindIndex = middenIndex - 1; 
                }
                else
                {
                index = middenIndex;
                beginIndex = eindIndex + 1;
                valid = false;
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
        public static void BoodschappenlijstList()
        {
            List<string> boodschappenlijst = new List<string>();
            string boodschap;
            int aantalBoodschappen = 1;
            bool notating = true;
            bool shopping = true;
            do
            {
                Console.WriteLine($"Wat is item {aantalBoodschappen} op je lijst?");
                boodschap = Console.ReadLine();
                if (boodschap != "")
                {
                    boodschappenlijst.Add(boodschap);
                    aantalBoodschappen++;
                }
                else
                {
                    notating = false;
                }
            }
            while (notating);
            boodschappenlijst.Sort();
            aantalBoodschappen = 1;
            foreach (string item in boodschappenlijst)
            {
                Console.WriteLine($"{aantalBoodschappen}: {item}");
                aantalBoodschappen++;
            }
            Console.WriteLine("Op naar de winkel!");
            do
            {
                Console.WriteLine("Welk item heb je gekocht?");
                string bought = Console.ReadLine();
                if (boodschappenlijst.Contains(bought))
                {
                    boodschappenlijst.Remove(bought);
                    Console.WriteLine("Nog winkelen? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        shopping = false;
                    }
                    else if (boodschappenlijst.Count == 0)
                    {
                        shopping = false;
                    }
                }
                else
                {
                    Console.WriteLine("Select an item on your list!");
                }
            }
            while (shopping);
            Console.WriteLine("Naar huis met de boodschappen!");
            Console.WriteLine("Volgende items van je lijst ben je vergeten kopen:");
            foreach (string item in boodschappenlijst)
            {
                Console.WriteLine($"- {item} ");
            }

        }
        public static void KerstinkopenList()
        {
            bool notating = true;
            List<int> kerstInkopen = new List<int>();
            int aantal = 1;
            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            int budget = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (kerstInkopen.Sum() > budget)
                {
                    Console.WriteLine($"Je bent al {kerstInkopen.Sum()-budget} euro over het budget!");
                    notating = false;
                }
                else 
                {
                    Console.WriteLine($"Prijs van cadeau {aantal}");
                    string cadeau = Console.ReadLine();
                    if (cadeau != "")
                    {
                        kerstInkopen.Add(Int32.Parse(cadeau));
                        aantal++;
                    }
                    else
                    {
                        notating = false;
                    }

                }
            } while (notating);
            Console.WriteLine("Info over je aankopen: ");
            Console.WriteLine($"Totaal bedrag: {kerstInkopen.Sum()} euro");
            Console.WriteLine($"Duurste cadeau: {kerstInkopen.Max()} euro");
            Console.WriteLine($"Goedkoopste bedrag: {kerstInkopen.Min()} euro");
            Console.WriteLine($"Gemiddelde prijs: {kerstInkopen.Average()} euro");

        }
        public static void Galgje()
        {
            Random random = new Random();
            string[] woorden = {"goud", "ijzer","koper","silver","lood"};
            string word = woorden[random.Next(1)]; 
            char[] wordHidden = word.ToCharArray();
            char[] wordFiltered = new char[wordHidden.Length];
            for (int i = 0; i < wordHidden.Length; i++)
            {
                wordFiltered[i] = '*';
            }
            bool status = true;
            int chances = 0;
            do
            {
                foreach (char letter in wordFiltered) 
                {
                    Console.Write($"{letter}");
                }
                Console.WriteLine("");
                Console.WriteLine($"Geef de letter in, op typ het volledige woord indien je het denkt te weten:");
                string input = Console.ReadLine();
                if (input.Length <= 1)
                {
                    char inputCharacter = char.Parse(input);
                    if (word.Contains(inputCharacter))
                    {
                        Console.WriteLine("U hebt een correcte letter geraden!\n");
                        wordFiltered[Array.IndexOf(wordHidden, inputCharacter)] = wordHidden[Array.IndexOf(wordHidden, inputCharacter)];
                        chances++;
                    }
                    else
                    {
                        Console.WriteLine("Dit is een foutieve invoer!");
                        chances++;
                    }
                }
                else
                {
                    if (input == word)
                    {
                        Console.WriteLine("Proficiat! U hebt het juiste woord gevonden!");
                        status = false;
                    }
                    else
                    {
                        Console.WriteLine("Dit is een foutieve invoer!");
                        chances++;
                    }
                }
            } while (status);

            Console.WriteLine($"Benodigde pogingen {chances}");
        
        }
    }
}
