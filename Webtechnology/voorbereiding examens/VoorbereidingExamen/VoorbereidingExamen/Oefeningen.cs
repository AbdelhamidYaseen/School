using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbereidingExamen
{
    internal class Oefeningen
    {
        public static void Christmastree() {
            int rows;
            Console.WriteLine("What is the amount of rows your christmas tree is made out of?");
            string character = "*";
            rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < rows-i; j++)
                {
                    Console.Write(character);
                }
            }
        }
        public static void ArmstrongChecker() {
            string input;
            input = Console.ReadLine();
            int[] inputNumbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputNumbers[i] = Convert.ToInt32(input[i].ToString());
            }
            double inputCheck = 0;
            for (int i = 0; i < input.Length; i++)
            {
                inputCheck += Math.Pow(inputNumbers[i], input.Length);
            }
            if (inputCheck == Convert.ToInt32(input))
            {
                Console.WriteLine($"{input} is een Armstrong nummer");
            }
            else 
            {
                Console.WriteLine($"{input} is niet een Armstrong nummer");
            }
        }
    }
}
