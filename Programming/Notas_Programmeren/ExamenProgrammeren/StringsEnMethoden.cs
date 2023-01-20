using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammeren
{
    internal class StringsEnMethoden
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
                    "01| Oef 1: VariabelenEnHoofdletters\n" +
                    "02| Oef 2: MaaltafelsStringInterpolatie\n" +
                    "03| Oef 3: RuimteStringInterpolatie\n" +
                    "04| Oef 4: BerekenBtw\n" +
                    "05| Oef 5: Leetspeak\n" +
                    "06| Oef 6: Lotto\n" +
                    "07| Oef 7: SomVanCijfers\n" +
                    "08| Oef 8: NaamUitMail\n" +
                    "09| Oef 9: EersteLetterEnAchternaam\n" +
                    "10| Oef 10: ToegangsCode\n" +
                    "11| Oef 11: Instructies\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")      { Console.Clear(); VariabelenEnHoofdletters(); }
                else if (selected == "02") { Console.Clear(); MaaltafelsStringInterpolatie(); }
                else if (selected == "03") { Console.Clear(); RuimteStringInterpolatie(); }
                else if (selected == "04") { Console.Clear(); BerekenBtw(); }
                else if (selected == "05") { Console.Clear(); Leetspeak(); }
                else if (selected == "06") { Console.Clear(); Lotto(); }
                else if (selected == "07") { Console.Clear(); SomVanCijfers(); }
                else if (selected == "08") { Console.Clear(); NaamUitMail(); }
                else if (selected == "09") { Console.Clear(); EersteLetterEnAchternaam(); }
                else if (selected == "10") { Console.Clear(); ToegangsCode(); }
                else if (selected == "11") { Console.Clear(); Instructies(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
        public static void VariabelenEnHoofdletters() 
        {
            Console.WriteLine("Welke tekst moet ik omzetten?");
            string sentence = Console.ReadLine();
            Console.WriteLine($"{sentence.ToUpper()}");
        }
        public static void MaaltafelsStringInterpolatie()
        {
            int getal = 411;
            int maal = 0;
            int resultaat;

            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
            maal = maal + 1;
            resultaat = maal * getal;
            Console.WriteLine($"{maal} * {getal} is {resultaat}");
            Console.ReadLine();
            Console.Clear();
        }

        public static void RuimteStringInterpolatie()
        {
            double persoonGewicht, mercuriusGewicht, venusGewicht, aardeGewicht, marsGewicht, jupiterGewicht, saturnusGewicht, uranusGewicht, neptunusGewicht, plutoGewicht;
            mercuriusGewicht = 0.38;
            venusGewicht = 0.91;
            aardeGewicht = 1.00;
            marsGewicht = 0.38;
            jupiterGewicht = 2.34;
            saturnusGewicht = 1.06;
            uranusGewicht = 0.92;
            neptunusGewicht = 1.19;
            plutoGewicht = 0.06;
            Console.Write("Wat is je gewicht? ");
            persoonGewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Op Mercurius voel je je alsof je {persoonGewicht * mercuriusGewicht} kg weegt.");
            Console.WriteLine($"Op Venus voel je je alsof je {persoonGewicht * venusGewicht} kg weegt.");
            Console.WriteLine($"Op Aarde voel je je alsof je {persoonGewicht * aardeGewicht} kg weegt.");
            Console.WriteLine($"Op Mars voel je je alsof je {persoonGewicht * marsGewicht} kg weegt.");
            Console.WriteLine($"Op Jupiter voel je je alsof je {persoonGewicht * jupiterGewicht} kg weegt.");
            Console.WriteLine($"Op Saturnus voel je je alsof je {persoonGewicht * saturnusGewicht} kg weegt.");
            Console.WriteLine($"Op Uranus voel je je alsof je {persoonGewicht * uranusGewicht} kg weegt.");
            Console.WriteLine($"Op Neptunus voel je je alsof je {persoonGewicht * neptunusGewicht} kg weegt.");
            Console.WriteLine($"Op Pluto voel je je alsof je {persoonGewicht * plutoGewicht} kg weegt.");
        }

        public static void BerekenBtw() 
        {
            Console.Write("Geef het bedrag in: ");
            int bedrag = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef BTW percentage in: ");
            int percentage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Het bedrag {bedrag} met {percentage}% btw bedraagt {bedrag + (bedrag/100)*percentage}");
        }

        public static void Leetspeak() 
        {
            Console.WriteLine("Geef je tekst in");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence.Replace('a','@'));
        }

        public static void Instructies() 
        {
            Console.WriteLine("Wat is je naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Wat is de naam van de cursus?");
            string cursus = Console.ReadLine();
            Console.WriteLine($"Maak een map als volgt: /home/{naam.Substring(0,3).ToUpper()}/{cursus}");
        }
        public static void Lotto() 
        {
            Console.WriteLine("Wat zijn je cijfers (tussen 01 en 45)");
            string cijfers = Console.ReadLine();
            Console.WriteLine($"Je cijfers zijn:\n{cijfers.Substring(0,2)}|{cijfers.Substring(3,2)}|{6,2}\n{9,2}|{12,2}|{15,2}");
        }
        public static void SomVanCijfers() 
        {
            Console.WriteLine("Gelieve een getal in te voeren dat bestaat uit exact 5 cijfers");
            string cijfer = Console.ReadLine();
            int getal0, getal1, getal2, getal3, getal4;
            getal0 = Convert.ToInt32(cijfer.Substring(0, 1));
            getal1 = Convert.ToInt32(cijfer.Substring(1, 1));
            getal2 = Convert.ToInt32(cijfer.Substring(2, 1));
            getal3 = Convert.ToInt32(cijfer.Substring(3, 1));
            getal4 = Convert.ToInt32(cijfer.Substring(4, 1));

            Console.WriteLine($"De som is {getal0 + getal1 + getal2 + getal3 + getal4}");
        }
        public static void NaamUitMail() 
        {
            string email;
            int plaatsApenstaartje;
            Console.WriteLine("Geef je e-mailadres:");
            Console.Write("> ");
            email = Console.ReadLine();
            plaatsApenstaartje = email.IndexOf("@");
            Console.WriteLine($"Je naam uit je e-mail is: {email.Substring(0, plaatsApenstaartje).ToUpper()}");

        }
        public static void EersteLetterEnAchternaam() 
        {
            string naam;

            Console.WriteLine("Geef je naam:");
            Console.Write("> ");
            naam = Console.ReadLine();
            Console.WriteLine($"De eerste letter van je naam is: {naam.Substring(0, 1)}.");
            Console.WriteLine($"Je achternaam is: {naam.Substring(naam.IndexOf(" ") + 1)}");

        }
        public static void ToegangsCode() 
        {
            string naam, geboortejaar, postcode;
            int eersteCijferPostcode;
            Console.Write("Geef je naam: ");
            naam = Console.ReadLine();
            Console.Write("Geef je geboortejaar: ");
            geboortejaar = Console.ReadLine();
            Console.Write("Geef je postcode: ");
            postcode = Console.ReadLine();
            eersteCijferPostcode = Convert.ToInt32(postcode.Substring(0, 1));
            Console.WriteLine($"Je toegangscode is {naam.Substring(naam.Length - 2, 1)}{naam.Substring(naam.Length - 1, 1).ToUpper()}{geboortejaar.Substring(geboortejaar.Length - 1, 1)}{eersteCijferPostcode * eersteCijferPostcode}");

        }
    }
}
