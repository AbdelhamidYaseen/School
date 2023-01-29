using System;
namespace LaboOefeningen
{
    internal class TextCell
    {
        public static void TextCellMain()
        {
            int amountOfCells;
            Console.WriteLine("Hoe veel cellen telt je spreadsheet?");
            amountOfCells = Convert.ToInt32(Console.ReadLine());
            string[] raster = new string[amountOfCells];
            for (int i = 0; i < raster.Length; i++)
            {
                raster[i] = "";
            }

            //while (true)
            //{
                BerekenEnToonRooster(raster);
                WijzigCel(raster);
            //}
        }

        public static void BerekenEnToonRooster(string[] raster)
        {
            for (int i = 0; i < raster.Length; i++)
            {
                Console.Write("|");
                string textAppereance = GetalVoorstellingNaarLetters(i + 1);
                Console.Write(textAppereance);
            }
            Console.WriteLine("|");
            for (int i = 0; i < raster.Length; i++)
            {
                Console.Write("|");
                Console.Write(raster[i]);
            }
            Console.WriteLine("|");

        }

        public static void WijzigCel(string[] raster)
        {

        }

        public static string GetalVoorstellingNaarLetters(int number)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int amountOfSymbols = alphabet.Length;
            string result = "";
            int todo = number;
            bool finished = false;
            while (!finished)
            {
                if (todo <= amountOfSymbols)
                {
                    finished = true;
                }
                int karakterIndex = (todo - 1) % amountOfSymbols;
                result = alphabet[karakterIndex] + result;
                todo = (todo - 1) / amountOfSymbols;
            }
            return result;
        }

        public static int LetterVoorstellingNaarGetal(string letters)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int amountOfSymbols = alphabet.Length;
            int result = 0;
            for (int i = letters.Length - 1; i >= 0; i--)
            {
                int exponent = letters.Length - i - 1;
                result += (alphabet.IndexOf(letters[i]) + 1) * (int)Math.Pow(amountOfSymbols, exponent);
            }
            return result;
        }
    }
}

