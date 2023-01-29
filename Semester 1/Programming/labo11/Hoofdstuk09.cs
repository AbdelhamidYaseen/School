using System;

namespace LaboOefeningen
{
    public class Hoofdstuk09
    {
        public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Som N de rij");
            Console.WriteLine("2. Som per rij");
            //3. Som per kolom maakte geen deel uit van de opgaven
            Console.WriteLine("3. Som per kolom");
            Console.WriteLine("4. Pixels");
            Console.WriteLine("5. Conway's Game Of Life ");
            Console.WriteLine("6. HeatmapPaardensprong");
            int keuze = Convert.ToInt32(Console.ReadLine());

            if (keuze == 1)
            {
                double[,] numbers = {{4.2, 8.1, 3.3},
                     {2.0, 4.0, 6.0},
                     {3.1,3.2,3.3}};
                Console.WriteLine("Van welke rij wil je de som zien?");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SomNdeRij(numbers, row));
            }
            if (keuze == 2) 
            {
                SomPerRij();
            }
            if (keuze == 3) 
            {
                SomPerKolom();
            }
            if (keuze == 4) 
            {
                Pixels();
            }
            if (keuze == 5) 
            {
                ConwayGameOfLife.ConwayGameOfLifeMain();
            }
            if (keuze == 6) 
            {
                HeatmapPaardensprong.HeatmapPaardensprongMain();
            }
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
            ConsoleColor[] kleuren = (ConsoleColor[]) Enum.GetValues(typeof(ConsoleColor));
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
