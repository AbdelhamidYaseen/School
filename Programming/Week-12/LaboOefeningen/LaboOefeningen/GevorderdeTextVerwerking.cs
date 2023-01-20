using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LaboOefeningen
{
    internal class GevorderdeTextVerwerking
    {
        public static void SomVanGetallen() {
            Console.WriteLine("Gelieve getallen gescheiden door ';' in te geven:");
            string getallen = Console.ReadLine();
            string[] getallenSplit = getallen.Split(";");
            Console.WriteLine("\n======================================\n");
            Console.Write($"{getallenSplit[0]}");
            for (int i = 1; i<getallenSplit.Length; i++) {
                Console.Write($"+{getallenSplit[i]}");
            }
            Console.WriteLine($" = {getallenSplit.Sum(int.Parse)}");
            Console.WriteLine("\n======================================");

        }
        public static void CentraalAlignerenTekst() {
            Console.WriteLine("Geef een tekst in:");
            string input = Console.ReadLine();
            Console.WriteLine("Geef de gewenste lengete van de tekst op, die moet minimaal 6 zijn");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length < input.Length)
            {
                Console.WriteLine("Dit is niet lang genoeg");
            }   
            while (length< input.Length);
            Console.WriteLine("Geef het character dat je wilt gebruiken:");
            char character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(CentraalAligneren(input, length, character));
        }
        public static string CentraalAligneren(string text, int length, char sign) {
            int tekensLengte = length - text.Length;
            string tekstAlligned;
            tekstAlligned = text.PadLeft((length - tekensLengte / 2), sign);
            tekstAlligned = tekstAlligned.PadRight(length, sign);
            return tekstAlligned;
        }
        public static void KerstVerwerking() {
            bool notating = true;
            List<int> kerstInkopen = new List<int>();
            int aantal = 1;
            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            int budget = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (kerstInkopen.Sum() > budget)
                {
                    Console.WriteLine($"Je bent al {kerstInkopen.Sum() - budget} euro over het budget!");
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
            string title = "Info over je aankopen:";
            string scheidingsCharacter = new string('=', title.Length);
            string heading = $"{title}\n{scheidingsCharacter}";
            Console.WriteLine($"{heading}");
            Console.WriteLine($"{"Totaal bedrag:".PadRight(25,' ')}{kerstInkopen.Sum()}");
            Console.WriteLine($"{"Duurste cadeau:".PadRight(25, ' ')}{kerstInkopen.Max()}");
            Console.WriteLine($"{"Goedkoopste bedrag:".PadRight(25, ' ')}{kerstInkopen.Min()}");
            Console.WriteLine($"{"Gemiddelde prijs:".PadRight(25, ' ')}{kerstInkopen.Average()}");
        }
    }
}