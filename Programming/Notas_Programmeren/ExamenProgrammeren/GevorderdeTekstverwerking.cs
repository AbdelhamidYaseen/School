using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenProgrammeren
{
    internal class GevorderdeTekstverwerking
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
                    "01| Oef 1: Kerstinkopen\n" +
                    "02| Oef 2: Pixels\n" +
                    "03| Oef 3: SomVanGetallen\n" +
                    "04| Oef 4: CentraalAlignerenTekst\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")      { Console.Clear(); Kerstinkopen(); }
                else if (selected == "02") { Console.Clear(); Pixels(); }
                else if (selected == "03") { Console.Clear(); SomVanGetallen(); }
                else if (selected == "04") { Console.Clear(); CentraalAlignerenTekst(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
        public static void Kerstinkopen()
        {
            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            double budget = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoeveel cadeautjes wil je kopen?");
            int numberOfPresents = Convert.ToInt32(Console.ReadLine());
            double[] presents = new double[numberOfPresents];
            for (int i = 0; i < numberOfPresents; i++)
            {
                Console.WriteLine($"Prijs van cadeau {i + 1}?");
                presents[i] = Convert.ToDouble(Console.ReadLine());
                if (presents.Sum() > budget)
                {
                    Console.WriteLine($"Je bent al {(presents.Sum() - budget):C} over het budget!");
                }
            }
            string headerText = "Info over je aankopen:";
            Console.WriteLine(headerText);
            Console.WriteLine("".PadRight(headerText.Length, '='));
            Console.WriteLine($"{"Totaal bedrag:",-25} {presents.Sum():C}.");
            Console.WriteLine($"{"Duurste cadeau:",-25} {presents.Max():C}.");
            Console.WriteLine($"{"Goedkoopste cadeau:",-25} {presents.Min():C}.");
            Console.WriteLine($"{"Gemiddelde prijs:",-25} {presents.Average():C}.");
        }
        public static void Pixels()
        {
            ConsoleColor[] allColors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Console.WriteLine($"Hoe veel rijen telt je canvas?");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hoe veel kolommen telt je canvas?");
            int numberOfColumns = Convert.ToInt32(Console.ReadLine());
            ConsoleColor[,] canvas = new ConsoleColor[numberOfRows, numberOfColumns];
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1. Een pixel kleuren");
                Console.WriteLine("2. Afbeelding tonen");
                Console.WriteLine("3. Een afbeelding exporteren");
                Console.WriteLine("4. Een afbeelding inladen");
                Console.WriteLine("5. Stoppen");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Wat is de rij-index van de pixel (begin vanaf 0)?");
                    int indexX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wat is de kolom-index van de pixel (begin vanaf 0)?");
                    int indexY = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Welke kleur wil je gebruiken?");
                    for (int i = 0; i < allColors.Length; i++)
                    {
                        Console.WriteLine($"{i}: {allColors[i]}");
                    }
                    canvas[indexX, indexY] = (ConsoleColor)Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 2)
                {
                    ShowPixels(canvas);
                }
                else if (choice == 3)
                {
                    // Denk eraan dat je dit kan doorlopen met de debugger!
                    Console.WriteLine("Geef het volledige pad naar de locatie waar je wil opslaan, inclusief bestandsnaam.");
                    string path = Console.ReadLine();
                    // We zullen per rij van de tekening één regel tekst in een file bijhouden.
                    string[] lines = new string[canvas.GetLength(0)];
                    for (int row = 0; row < canvas.GetLength(0); row++)
                    {
                        // Binnen één rij leggen we verschillende kolommen vast.
                        string[] columns = new string[canvas.GetLength(1)];
                        for (int column = 0; column < canvas.GetLength(1); column++)
                        {
                            /* Dit is een beetje tricky.
                             * Kleuren kunnen worden omgezet naar getallen.
                             * Getallen kunnen worden omgezet naar strings.
                             * We willen beide na elkaar.
                             * Rechtstreeks naar string omzetten gebeurt op een andere manier en levert een ander resultaat.
                             * Probeer gerust eens en kijk dan wat er in de file staat!
                             */
                            columns[column] = Convert.ToString((int)canvas[row, column]);
                        }
                        // hiermee leggen we één regel vast
                        // kijk met de debugger naar de inhoud van lines voor en na het uitvoeren van deze regel
                        lines[row] = String.Join(';', columns);
                    }
                    File.WriteAllLines(path, lines);
                    System.Console.WriteLine("Bestand geëxporteerd!");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Geef het volledige pad van het bestand dat je wil inladen.");
                    string path = Console.ReadLine();
                    string[] lines = File.ReadAllLines(path);
                    // in een geldige afbeelding hebben alle regels even veel kolommen
                    // dus we nemen gewoon de eerste regel om het aantal kolommen te vinden
                    string firstLine = lines[0];
                    numberOfRows = lines.Length;
                    numberOfColumns = firstLine.Split(";").Length;
                    canvas = new ConsoleColor[numberOfRows, numberOfColumns];
                    // we hebben een leeg canvas, nu moeten we het regel per regel invullen
                    for (int row = 0; row < numberOfRows; row++)
                    {
                        string line = lines[row];
                        // dit zijn de verschillende kolomwaarden *binnen één regel*
                        string[] columnValues = line.Split(";");
                        for (int column = 0; column < numberOfColumns; column++)
                        {
                            // ook hier is rechtstreeks omzetten van string naar ConsoleColor geen optie
                            // onrechtstreeks van string naar getal naar ConsoleColor wel
                            canvas[row, column] = (ConsoleColor)Convert.ToInt32(columnValues[column]);
                        }
                    }
                }
            }
        }
        public static void ShowPixels(ConsoleColor[,] pixelColors)
        {
            Console.Clear();
            for (int i = 0; i < pixelColors.GetLength(0); i++)
            {
                for (int j = 0; j < pixelColors.GetLength(1); j++)
                {
                    Console.BackgroundColor = pixelColors[i, j];
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        public static void SomVanGetallen()
        {
            Console.WriteLine("Gelieve getallen gescheiden door ';'  in te geven");
            string numbersAsText = Console.ReadLine();
            string[] numbersAsSeparateStrings = numbersAsText.Split(";");
            int sum = 0;
            for (int i = 0; i < numbersAsSeparateStrings.Length; i++)
            {
                sum += Convert.ToInt32(numbersAsSeparateStrings[i]);
            }
            string sumRepresentation = string.Join("+", numbersAsSeparateStrings);
            Console.WriteLine($"{sumRepresentation} = {sum}");
        }
        public static void CentraalAlignerenTekst()
        {
            Console.WriteLine("Geef een tekst in: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Geef de gewenste lengte van de tekst op, die moet minimaal {text.Length} zijn");
            int desiredLength = Convert.ToInt32(Console.ReadLine());
            while (desiredLength <= text.Length)
            {
                Console.WriteLine($"Lengte moet minimaal {text.Length} zijn, geef de lengte opnieuw in!");
                desiredLength = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Geef het 'padding karakter':");
            string padding = Console.ReadLine();
            Console.WriteLine(CentraalAligneren(text, desiredLength, padding[0]));
        }
        public static string CentraalAligneren(string text, int paddedLength, char padding)
        {
            int paddingLeft = (paddedLength - text.Length) / 2;
            return text.PadLeft(text.Length + paddingLeft, padding).PadRight(paddedLength, padding);
        }

    }
}
