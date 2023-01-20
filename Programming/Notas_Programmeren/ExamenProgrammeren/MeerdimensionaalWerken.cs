using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammeren
{
    internal class MeerdimensionaalWerken
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
                    "01| Oef 1: xxx\n" +
                    "02| Oef 2: xxx\n" +
                    "03| Oef 3: xxx\n" +
                    "04| Oef 4: xxx\n" +
                    "05| Oef 5: xxx\n" +
                    "06| Oef 6: xxx\n" +
                    "07| Oef 7: xxx\n" +
                    "08| Oef 8: xxx\n" +
                    "09| Oef 9: xxx\n" +
                    "10| Oef 10: xxx\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01") { Console.Clear(); }
                else if (selected == "02") { Console.Clear(); }
                else if (selected == "03") { Console.Clear(); }
                else if (selected == "04") { Console.Clear(); }
                else if (selected == "05") { Console.Clear(); }
                else if (selected == "06") { Console.Clear(); }
                else if (selected == "07") { Console.Clear(); }
                else if (selected == "08") { Console.Clear(); }
                else if (selected == "09") { Console.Clear(); }
                else if (selected == "10") { Console.Clear(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
        public static int SomNdeRij(double[,] numbers, int row)
        {
            int sum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                sum += (int)numbers[row, i];
            }
            return sum;
        }

        public static void SomPerRij()
        {
            Console.WriteLine($" Hoe veel rijen telt je array?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Hoe veel kolommen telt je array?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            int[,] getallen = new int[aantalRijen, aantalKolommen];
            for (int j = 0; j < getallen.GetLength(1); j++)
            {
                for (int i = 0; i < getallen.GetLength(0); i++)
                {
                    Console.WriteLine($"Waarde voor rij {i + 1}, kolom {j + 1}:");
                    getallen[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Sommen per rij:");
            for (int i = 0; i < getallen.GetLength(0); i++)
            {
                int som = 0;
                for (int j = 0; j < getallen.GetLength(1); j++)
                {
                    som += getallen[i, j];
                }
                Console.WriteLine(som);
            }
        }

        //Dit is een extra gegeven dat niet als oefening werd opgelijst.
        public static void SomPerKolom()
        {
            Console.WriteLine($" Hoe veel rijen telt je array?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Hoe veel kolommen telt je array?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            int[,] getallen = new int[aantalRijen, aantalKolommen];
            for (int i = 0; i < getallen.GetLength(0); i++)
            {
                for (int j = 0; j < getallen.GetLength(1); j++)
                {
                    Console.WriteLine($"Waarde voor rij {i + 1}, kolom {j + 1}:");
                    getallen[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Sommen per kolom:");
            for (int j = 0; j < getallen.GetLength(1); j++)
            {
                int som = 0;
                for (int i = 0; i < getallen.GetLength(0); i++)
                {
                    som += getallen[i, j];
                }
                Console.WriteLine(som);
            }
        }
        public static void Pixels()
        {
            ConsoleColor[] kleuren = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Console.WriteLine($"Hoe veel rijen telt je canvas?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hoe veel kolommen telt je canvas?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            ConsoleColor[,] canvas = new ConsoleColor[aantalRijen, aantalKolommen];
            int keuze = 0;
            while (keuze != 5)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1. Een pixel kleuren");
                Console.WriteLine("2. Afbeelding tonen");
                Console.WriteLine("3. Roodfilter toepassen");
                Console.WriteLine("4. Driehoeksfilter toepassen");
                keuze = Convert.ToInt32(Console.ReadLine());
                if (keuze == 1)
                {
                    Console.WriteLine("Wat is de rij-index van de pixel (begin van af 0?");
                    int indexX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wat is de kolom-index van de pixel (begin van af 0?");
                    int indexY = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Welke kleur wil je gebruiken?");
                    for (int i = 0; i < kleuren.Length; i++)
                    {
                        Console.WriteLine($"{i}: {kleuren[i]}");
                    }
                    canvas[indexX, indexY] = (ConsoleColor)Convert.ToInt32(Console.ReadLine());
                }
                else if (keuze == 2)
                {
                    ShowPixels(canvas);
                }
                else if (keuze == 3)
                {
                    RedFilter(canvas);
                }
                else if (keuze == 4)
                {
                    LowerTriangleFilter(canvas);
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
                }
                Console.WriteLine();
            }
        }

        public static void RedFilter(ConsoleColor[,] pixelRed)
        {
            Console.Clear();
            for (int i = 0; i < pixelRed.GetLength(0); i++)
            {
                for (int j = 0; j < pixelRed.GetLength(1); j++)
                {
                    if (j % 2 != 0 && i % 2 != 0)
                    {
                        pixelRed[i, j] = ConsoleColor.Red;
                    }
                }
            }
        }

        public static void LowerTriangleFilter(ConsoleColor[,] pixelTriangle)
        {
            Console.Clear();
            if (pixelTriangle.GetLength(0) != pixelTriangle.GetLength(1))
            {
                Console.WriteLine("Deze filter kan niet worden toegepast op deze afbeelding.");
            }
            else
            {
                for (int i = 0; i < pixelTriangle.GetLength(0); i++)
                {
                    for (int j = 0; j < pixelTriangle.GetLength(1) && j <= i; j++)
                    {
                        {
                            pixelTriangle[i, j] = ConsoleColor.White;
                        }
                    }
                }
            }
        }

    }
}
