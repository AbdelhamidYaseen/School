using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permanente_evaluatie_3
{
    internal class Evaluatie3
    {
        public static string StringToLower(string tekst)
        {
            string output = "";
            foreach (char character in tekst)
            {
                if (character >= 'A' && character <= 'Z')
                {
                    output = output + Convert.ToChar(character - 'A' + 'a');
                }
                else
                {
                    output = output + character;
                }
            }
            return output;
        }
        
        //OMZETTEN NAAR EEN ARRAY EN ELKE " " CHARACTER ER UIT HALEN
        /*
        public static void RemoveWhiteSpace(string input) {
            char[] inputChars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputChars[i] = input.
            }
        }
        */
        public static void EmailadresGenerator()
        {
            string voornaam;
            string achternaam;
            bool isStudent;
            Console.WriteLine("Wat is de voornaam van de persoon?");
            voornaam = Console.ReadLine();
            Console.WriteLine("Wat is de achternaam van de persoon?");
            achternaam = Console.ReadLine();
            Console.WriteLine("Is de persoon een student? (true)/(false)");
            isStudent = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(isStudent);


            if (isStudent)
            {
                Console.WriteLine($"email: {StringToLower(voornaam.Trim())}.{StringToLower(achternaam.Trim())}@student.ap.be");
            }
            else 
            {
                Console.WriteLine($"email: {StringToLower(voornaam.Trim())}.{StringToLower(achternaam.Trim())}@ap.be");
            }
        }
    }
}

