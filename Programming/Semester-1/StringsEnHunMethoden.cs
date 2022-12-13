using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class StringsEnHunMethoden
    {
        public static void VariabelenEnHoofdletters()
        {
            string omTeZetten;
            Console.WriteLine("Welke tekst moet ik omzetten?");
            Console.Write("> ");
            omTeZetten = Console.ReadLine();
            Console.WriteLine(omTeZetten.ToUpper());
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
            double bedrag, btwPercentage, bedragNaBtw;
            Console.Write("Geef het bedrag in: ");
            bedrag = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het BTW percentage in: ");
            btwPercentage = Convert.ToDouble(Console.ReadLine());
            bedragNaBtw = bedrag / 100 * (btwPercentage + 100);
            Console.WriteLine($"Het bedrag {bedrag} met {btwPercentage}% btw bedraagt {bedragNaBtw}");
        }

        public static void LeetSpeak()
        {
            string tekst;

            Console.WriteLine("Geef je tekst in");
            Console.Write("> ");
            tekst = Console.ReadLine();
            Console.WriteLine(tekst.Replace("a", "@").Replace(" ", ""));
        }

        public static void SomVanCijfers()
        {
            string cijferString;
            int getal0, getal1, getal2, getal3, getal4;

            Console.WriteLine("Gelieve een getal in testc voeren dat bestaat uit exact 5 decimale cijfers.");
            Console.Write("> ");
            cijferString = Console.ReadLine();
            getal0 = Convert.ToInt32(cijferString.Substring(0, 1));
            getal1 = Convert.ToInt32(cijferString.Substring(1, 1));
            getal2 = Convert.ToInt32(cijferString.Substring(2, 1));
            getal3 = Convert.ToInt32(cijferString.Substring(3, 1));
            getal4 = Convert.ToInt32(cijferString.Substring(4, 1));

            Console.WriteLine($"De som is {getal0 + getal1 + getal2 + getal3 + getal4}.");
        }

        public static void Lotto()
        {
            string lottoCijfers;
            string c0, c1, c2, c3, c4, c5;
            Console.WriteLine("Wat zijn je cijfers (tussen 01 en 45)?");
            Console.Write("> ");
            lottoCijfers = Console.ReadLine();
            c0 = lottoCijfers.Substring(0, 2);
            c1 = lottoCijfers.Substring(3, 2);
            c2 = lottoCijfers.Substring(6, 2);
            c3 = lottoCijfers.Substring(9, 2);
            c4 = lottoCijfers.Substring(12, 2);
            c5 = lottoCijfers.Substring(15, 2);

            Console.WriteLine("Je cijfers zijn:");
            Console.WriteLine($"{c0}|{c1}|{c2}");
            Console.WriteLine($"{c3}|{c4}|{c5}");
        }

        public static void Instructies()
        {
            string naam, cursus;

            Console.WriteLine("Wat is je naam?");
            Console.Write("> ");
            naam = Console.ReadLine();
            Console.WriteLine("Wat is de naam van de cursus?");
            Console.Write("> ");
            cursus = Console.ReadLine();

            Console.WriteLine($"Maak een map als volgt: /home/{naam.Substring(0,3).ToUpper()}/{cursus}");
        }

        public static void NaamUitEmail()
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
            Console.WriteLine($"De eerste letter van je naam is: {naam.Substring(0,1)}.");
            Console.WriteLine($"Je achternaam is: {naam.Substring(naam.IndexOf(" ")+1)}");
        }

        public static void Toegangscode()
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
            Console.WriteLine($"Je toegangscode is {naam.Substring(naam.Length -2, 1)}{naam.Substring(naam.Length-1, 1).ToUpper()}{geboortejaar.Substring(geboortejaar.Length-1, 1)}{eersteCijferPostcode*eersteCijferPostcode}");
        }

        public static void Keuzemenu()
        {
            int oefening;
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - Variabelen en hoofdletters");
            Console.WriteLine("2 - Maaltafels string interpolatie");
            Console.WriteLine("3 - Ruimte string interpolatie");
            Console.WriteLine("4 - Bereken BTW");
            Console.WriteLine("5 - Leet Speak");
            Console.WriteLine("6 - Som van cijfers");
            Console.WriteLine("7 - Lotto");
            Console.WriteLine("8 - Instructies");
            Console.WriteLine("9 - Naam uit e-mail");
            Console.WriteLine("10 - Eerste letter en achternaam");
            Console.WriteLine("11 - Toegangscode");
            oefening = Convert.ToInt32(Console.ReadLine());

            if (oefening > 11)
            {
                Console.WriteLine("Ongeldige keuze");
                Console.Clear();
                Console.WriteLine("Welke oefening kies je?");
                Console.WriteLine("1 - Variabelen en hoofdletters");
                Console.WriteLine("2 - Maaltafels string interpolatie");
                Console.WriteLine("3 - Ruimte string interpolatie");
                Console.WriteLine("4 - Bereken BTW");
                Console.WriteLine("5 - Leet Speak");
                Console.WriteLine("6 - Som van cijfers");
                Console.WriteLine("7 - Lotto");
                Console.WriteLine("8 - Instructies");
                Console.WriteLine("9 - Naam uit e-mail");
                Console.WriteLine("10 - Eerste letter en achternaam");
                Console.WriteLine("11 - Toegangscode");
                oefening = Convert.ToInt32(Console.ReadLine());
            }
            if (oefening == 1)
            {
                Console.Clear();
                StringsEnHunMethoden.VariabelenEnHoofdletters();
            }
            if (oefening == 2)
            {
                Console.Clear();
                StringsEnHunMethoden.MaaltafelsStringInterpolatie();
            }
            if (oefening == 3)
            {
                Console.Clear();
                StringsEnHunMethoden.RuimteStringInterpolatie();
            }
            if (oefening == 4)
            {
                Console.Clear();
                StringsEnHunMethoden.BerekenBtw();
            }
            if (oefening == 5)
            {
                Console.Clear();
                StringsEnHunMethoden.LeetSpeak();
            }
            if (oefening == 6)
            {
                Console.Clear();
                StringsEnHunMethoden.SomVanCijfers();
            }
            if (oefening == 7)
            {
                Console.Clear();
                StringsEnHunMethoden.Lotto();
            }
            if (oefening == 8)
            {
                Console.Clear();
                StringsEnHunMethoden.Instructies();
            }
            if (oefening == 9)
            {
                Console.Clear();
                StringsEnHunMethoden.NaamUitEmail();
            }
            if (oefening == 10)
            {
                Console.Clear();
                StringsEnHunMethoden.EersteLetterEnAchternaam();
            }
            if (oefening == 11)
            {
                Console.Clear();
                StringsEnHunMethoden.Toegangscode();
            }
        }
    }
}
