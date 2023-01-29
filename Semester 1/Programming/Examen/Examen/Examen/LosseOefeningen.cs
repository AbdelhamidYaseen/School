using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen
{
    internal class LosseOefeningen
    {
        //TODO (SpamFilter) PRINT TO OUTPUT NIET CORRECT DEZE ZIT IN DE VERKEERDE METHODE
        public static void SpamFilter() 
        {
            List<String> items = new List<String>();
            string bericht;
            int counter = 0;
            do
            {
                Console.WriteLine("Geef het volgende bericht.");
                bericht = Console.ReadLine();
                items.Add(bericht);
                counter++;
            } while (bericht != "");
            Console.WriteLine("Deze berichten zijn oke: ");
            ExcludeSpam(items);
        }
        //DONE (IsSpam)
        public static bool IsSpam(string input) 
        {
            if (input.Contains("NFT") || input.Contains("lottery") == true)
            {
                //geeft true terug als het spam is
                return true;
            }
            else 
            {
                //geeft false terug als het geen spam is
                return false;
            }
        }
        //DONE (ExcludeSpam)
        public static List<String> ExcludeSpam(List<String> messages) 
        {
            List<String> items = new List<String>();
            for (int i = 0; i < messages.Count; i++)
            {
                if (IsSpam(messages[i]) == false)
                {
                    items.Add(messages[i]);
                }
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
            return items;
        }


        //TODO (VERTALER) autmatisatie
        public static string Getallencode(string input) 
        {
            string alfabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] lines = File.ReadAllLines(input);
            //int[] codes = new int[lines.Length];
            //DIT MOET NOG AUTOMATIC ATLIJD OPDELEN BIJ DE '!' GEBRUIK INDEX EN SUBSTRING OM DE LEGE ARRAY BIJ TE VULLEN
            //DIT WAS AANGEMAAKT OF DE REST VAN DE CODE WERKT
            int[] codes = { 10, 5, 0, 15, 16, 12, 15, 19, 19, 9, 14, 7, 0, 26, 9, 5, 20, 0, 5, 18, 0, 7, 15, 5, 4, 0, 21, 9, 20 };
            string msgDecoded = "";
            //TODO SUBSTRING CREATOR
            
            //DONE TRANSLATOR
            for (int i = 0; i < codes.Length; i++)
            {
                msgDecoded += alfabet[codes[i]];

            }
            return msgDecoded;
        }
        //DONE (MAIN BESTAND)
        public static void OntcijferBestand() 
        {
            Console.WriteLine("Waar staat het bestand dat je wil omzetten?");
            string location = Console.ReadLine();
            Console.WriteLine(Getallencode(location));
        }
        /*C:\Users\Yaseen Abdel-Hamid\Desktop\gecodeerd.txt*/
    }
}
