using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExamenProgrammeren
{
    internal class Methoden
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
                if (selected == "01")      { Console.Clear(); ReeksOperaties(); }
                else if (selected == "02") { Console.Clear(); BerekenStraal(25); }
                else if (selected == "03") { Console.Clear(); BerekenOmtrek(25); }
                else if (selected == "04") { Console.Clear(); BerekenOppervlakte(25); }
                else if (selected == "05") { Console.Clear(); Maximum(25, 50); }
                else if (selected == "06") { Console.Clear(); IsEven(25); }
                else if (selected == "07") { Console.Clear(); ToonOnEvenGetallen(25); }
                else if (selected == "08") { Console.Clear(); EmailGenerator(); }
                else if (selected == "09") { Console.Clear(); StringToLower("WAT GEberut Er HIER"); }
                else if (selected == "10") { Console.Clear(); TextTrim("Wat kan ik hier doen voor u"); }
                else if (selected == "11") { Console.Clear(); ReeksOperatiesMetReturn(); }
                else if (selected == "12") { Console.Clear(); BerekenStraalMetReturn(25); }
                else if (selected == "13") { Console.Clear(); BerekenOmtrekMetReturn(25); }
                else if (selected == "14") { Console.Clear(); BerekenOppervlakteMetReturn(25); }
                else if (selected == "15") { Console.Clear(); MaximumMetReturn(25, 50); }
                else if (selected == "16") { Console.Clear(); IsEvenMetReturn(25); }
                else if (selected == "17") { Console.Clear(); ToonOnEvenGetallenMetReturn(50); }
                else if (selected == "18") { Console.Clear(); Driehoeken(); }
                else if (selected == "19") { Console.Clear(); TekenRegel(5, "*"); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
        public static void ReeksOperaties()
        {
            double diameterCirkel, eersteGetal, tweedeGetal;
            int evenOfOneven;
            Console.Write("Geef de diameter van de cirkel: ");
            diameterCirkel = Convert.ToDouble(Console.ReadLine());
            BerekenStraal(diameterCirkel);
            BerekenOmtrek(diameterCirkel);
            BerekenOppervlakte(diameterCirkel);
            Console.WriteLine("Geef twee getallen");
            eersteGetal = Convert.ToDouble(Console.ReadLine());
            tweedeGetal = Convert.ToDouble(Console.ReadLine());
            Maximum(eersteGetal, tweedeGetal);
            Console.WriteLine("Geef een geheel getal:");
            evenOfOneven = Convert.ToInt32(Console.ReadLine());
            IsEven(evenOfOneven);
            ToonOnEvenGetallen(evenOfOneven);
        }
        public static void BerekenStraal(double diameter)
        {
            Console.WriteLine($"De straal van de cirkel is {(diameter / 2):F3}");
        }
        public static void BerekenOmtrek(double diameter)
        {
            Console.WriteLine($"De omtrek van de cirkel is {(diameter * Math.PI):F3}");
        }
        public static void BerekenOppervlakte(double diameter)
        {
            double straal = diameter / 2;
            Console.WriteLine($"De oppervlakte van de cirkel is {(Math.Pow(straal, 2) * Math.PI):F3}");
        }
        public static void Maximum(double eersteGetal, double tweedeGetal)
        {
            if (eersteGetal > tweedeGetal)
            {
                Console.WriteLine($"Het grootste getal van {eersteGetal} en {tweedeGetal} is {eersteGetal}");
            }
            else
            {
                Console.WriteLine($"Het grootste getal van {eersteGetal} en {tweedeGetal} is {tweedeGetal}");
            }
        }
        public static void IsEven(int getal)
        {
            if (getal % 2 == 0)
            {
                Console.WriteLine($"Getal {getal} is een even getal");
            }
            else
            {
                Console.WriteLine($"Getal {getal} is een oneven getal");
            }
        }
        public static void ToonOnEvenGetallen(int getal)
        {
            string onevenGetallen = "";
            for (int i = 1; i <= getal; i++)
            {
                if (i % 2 != 0)
                {
                    onevenGetallen += $"{i} ";
                }
            }
            Console.WriteLine($"De reeks van oneven getallen van 1 tot en met {getal}");
            Console.WriteLine(onevenGetallen);
        }
        public static void EmailGenerator()
        {
            string firstName, lastName, mailEnd;
            bool student;
            Console.Write("Geef voornaam: ");
            firstName = Console.ReadLine();
            Console.Write("Geef achternaam: ");
            lastName = Console.ReadLine();
            Console.Write("Student (false/true): ");
            student = Convert.ToBoolean(Console.ReadLine());
            firstName = StringToLower(firstName);
            lastName = StringToLower(lastName);
            lastName = TextTrim(lastName);
            Console.WriteLine(lastName);
            if (student == true)
            {
                Console.WriteLine($"{firstName}.{lastName}@student.ap.be");
            }
            else
            {
                Console.WriteLine($"{firstName}.{lastName}@ap.be");
            }
        }
        public static string StringToLower(string tekst)
        {
            string lowerText = "";
            int character;
            for (int i = 0; i <= tekst.Length - 1; i++)
            {
                character = Convert.ToInt32(tekst[i]);
                if (character >= Convert.ToInt32('A') && character <= Convert.ToInt32('Z'))
                {
                    character += 32;
                }
                lowerText += Convert.ToChar(character);
            }
            return lowerText;
        }
        public static string TextTrim(string tekst)
        {
            string trimmedText = "";
            int character;
            for (int i = 0; i <= tekst.Length - 1; i++)
            {
                character = Convert.ToInt32(tekst[i]);
                if (character != 32)
                {
                    trimmedText += Convert.ToChar(character);
                }
            }
            return trimmedText;
        }
        public static void ReeksOperatiesMetReturn()
        {
            double diameter, radius, circumference, area, firstInt, secondInt, thridInt;
            int evenOdd;
            string isEvenOdd, listEvenOdd;
            Console.Write("Geef de diameter van de cirkel: ");
            diameter = Convert.ToDouble(Console.ReadLine());
            radius = BerekenStraalMetReturn(diameter);
            Console.WriteLine($"De straal van de cirkel is {radius}");
            circumference = BerekenOmtrekMetReturn(diameter);
            Console.WriteLine($"De omtrek van de cirkel is {circumference}");
            area = BerekenOppervlakteMetReturn(diameter);
            Console.WriteLine($"De oppervlakte van de cirkel is {area}");
            Console.WriteLine("Geef twee getallen");
            firstInt = Convert.ToDouble(Console.ReadLine());
            secondInt = Convert.ToDouble(Console.ReadLine());
            thridInt = MaximumMetReturn(firstInt, secondInt);
            Console.WriteLine($"Het grootste getal van {firstInt} en {secondInt} is {thridInt}");
            Console.WriteLine("Geef een geheel getal:");
            evenOdd = Convert.ToInt32(Console.ReadLine());
            isEvenOdd = IsEvenMetReturn(evenOdd);
            Console.WriteLine(isEvenOdd);
            Console.WriteLine($"De reeks van oneven getallen van 1 tot en met {evenOdd}");
            listEvenOdd = ToonOnEvenGetallenMetReturn(evenOdd);
            Console.WriteLine(listEvenOdd);

        }
        public static double BerekenStraalMetReturn(double diameter)
        {
            return Math.Round(diameter / 2, 1);
        }
        public static double BerekenOmtrekMetReturn(double diameter)
        {
            return Math.Round(diameter * Math.PI, 1);
        }
        public static double BerekenOppervlakteMetReturn(double diameter)
        {
            return Math.Round(Math.Pow(diameter / 2, 2) * Math.PI, 1);
        }
        public static double MaximumMetReturn(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        public static string IsEvenMetReturn(int oddEven)
        {
            if (oddEven % 2 == 0)
            {
                return $"Getal {oddEven} is een even getal";
            }
            else
            {
                return $"Getal {oddEven} is een oneven getal";
            }
        }
        public static string ToonOnEvenGetallenMetReturn(int getal)
        {
            string onevenGetallen = "";
            for (int i = 1; i <= getal; i++)
            {
                if (i % 2 != 0)
                {
                    onevenGetallen += $"{i} ";
                }
            }
            return onevenGetallen;
        }
        public static void Driehoeken()
        {
            int hoogteDriehoek;
            string karakter, line;
            Console.WriteLine("Hoe hoog is de driehoek?");
            hoogteDriehoek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welk karakter gebruiken we als patroon?");
            karakter = Console.ReadLine();
            for (int i = 1; i <= hoogteDriehoek; i++)
            {
                line = TekenRegel(i, karakter);
                Console.WriteLine(line);
            }
        }
        public static string TekenRegel(int regel, string karakter)
        {
            string getekendeRegel = "";
            for (int i = 1; i <= regel; i++)
            {
                getekendeRegel += karakter;
            }
            return getekendeRegel;
        }

    }
}
