using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_Oefeningen
{
    internal class StringsEnHunMethoden
    {
        public static void VariabelenEnHoofdletters() {
            String sentence;
            Console.WriteLine("Welke tekst moet ik omzetten?");
            sentence = Console.ReadLine();
            Console.WriteLine(sentence.ToUpper());
        }
        public static void MaaltafelStringInterpolatie() {
            Console.WriteLine("Dit zijn de vermenigvuldigen van het getal 411");
            for (int currentMultiplier = 0; currentMultiplier <= 10; currentMultiplier++)
            {
                int table = 511;
                int currentAmount = (table * currentMultiplier);
                Console.WriteLine($"{currentMultiplier} * {table} is {currentAmount}");
                Console.WriteLine($"\n\n\n-PRESS ENTER TO CONTINUE-");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static void RuimteStringInterpolatie() {
            double gravMercurius = 0.38;
            double gravVenus = 0.91;
            double gravEarth = 1.00;
            double gravMars = 0.38;
            double gravJupiter = 2.34;
            double gravSaturnus = 1.06;
            double gravUranus = 0.92;
            double gravNeptune = 1.19;
            double gravPluto = 0.06;

            double weight;


            Console.WriteLine("Hoeveel weeg jij op aarde?");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Op Mercurius voel je je alsof je  {(weight * gravMercurius)} kg weegt.");
            Console.WriteLine($"Op Venus voel je je alsof je  {(weight * gravVenus)} kg weegt.");
            Console.WriteLine($"Op Earth voel je je alsof je  {(weight * gravEarth)} kg weegt.");
            Console.WriteLine($"Op Mars voel je je alsof je {(weight * gravMars)} kg weegt.");
            Console.WriteLine($"Op Jupiter voel je je alsof je {(weight * gravJupiter)} kg weegt.");
            Console.WriteLine($"Op Saturnus voel je je alsof je {(weight * gravSaturnus)} kg weegt.");
            Console.WriteLine($"Op Uranus voel je je alsof je {(weight * gravUranus)} kg weegt.");
            Console.WriteLine($"Op Neptune voel je je alsof je {(weight * gravNeptune)} kg weegt.");
            Console.WriteLine($"Op Pluto voel je je alsof je {(weight * gravPluto)} kg weegt.");
        }
        public static void BerekenBtw() {
            double bedrag;
            double btw;
            Console.Write("Geef het bedrag in: ");
            bedrag = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef BTW percentage in: ");
            btw = Convert.ToInt32(Console.ReadLine());
            double totaal = (bedrag / 100) * btw + bedrag;
            Console.WriteLine($"Het bedrag {bedrag} met {btw}% btw bedraagt {totaal}");
        
        }
        public static void LeetSpeak() {
            string text;
            Console.WriteLine("Geef je tekst in");
            text = Console.ReadLine();
            Console.WriteLine(text.Replace("a","@"));
        }
        public static void Instructies() {
            string name;
            string cursus;
            Console.WriteLine("Wat is je naam?");
            name = Console.ReadLine();
            string nameShort = name.Substring(0,3).ToUpper();
            Console.WriteLine("Wat is de naam van de cursus?");
            cursus = Console.ReadLine();
            Console.WriteLine($"Maak een map als volgt: /home/{nameShort}/{cursus}");
        }
        public static void Lotto() {
            string number;

            Console.WriteLine("Wat zijn je cijfers (tussen 01 en 45?");
            number = Console.ReadLine();

            Console.WriteLine($"Je cijfers zijn: \n{number.Substring(0,2)}|{number.Substring(3,2)}|{number.Substring(6,2)}\n{number.Substring(9,2)}|{number.Substring(12,2)}|{number.Substring(15,2)}");
        }
        public static void SomVanCijfers() {
            string getal;
            Console.WriteLine("Gelieve een getal in te voeren dat bestaat uit exact 5 decimale cijfers");
            getal = Console.ReadLine();
            int getal0 = Convert.ToInt32(getal.Substring(0, 1));
            int getal1 = Convert.ToInt32(getal.Substring(1, 1));
            int getal2 = Convert.ToInt32(getal.Substring(2, 1));
            int getal3 = Convert.ToInt32(getal.Substring(3, 1));
            int getal4 = Convert.ToInt32(getal.Substring(4, 1));

            int uitkomst = getal0+getal1+getal2+getal3+getal4;
            Console.WriteLine($"De som is {uitkomst}.");

        
        }
        public static void NaamUitMail() {
            Console.WriteLine("Geef je e-mailadres: ");
            string email;
            email = Console.ReadLine();

            Console.WriteLine($"Je naam uit je e-mail is: {email.Substring(0,email.IndexOf("@")).ToUpper()}");

        }
        public static void EersteLetterEnAchernaam() {
            string name;
            Console.WriteLine("Geef je naam: ");
            name = Console.ReadLine();
            Console.WriteLine($"De eerste letter van je naam is: {name.Substring(0,1).ToUpper()}");
            Console.WriteLine($"Je achternaam is: {name.Substring(name.IndexOf(" "))}");
        }
        public static void Toegangscode() {
            string name;
            Console.Write("Geef je naam: ");
            name = Console.ReadLine();
            int birthyear;
            Console.Write("Geef je geboortejaar: ");
            birthyear = Convert.ToInt32(Console.ReadLine());
            int code;
            Console.Write("Geef je postcode: ");
            code = Convert.ToInt32(Console.ReadLine());

            string codeMultiplied = Convert.ToString(code * code);
            string yearConvert = Convert.ToString(birthyear);

            Console.WriteLine($"Je toegangscode is: {name.Substring(name.Length-2,1).ToLower()}{name.Substring(name.Length-1,1).ToUpper()}{yearConvert.Substring(yearConvert.Length-1,1)}{codeMultiplied.Substring(0,1)}");
        }
    
    }
}
