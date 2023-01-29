using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class VariabelenEnDatatypes
    {
        public static void Optellen() {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Wat is het eerste getal?");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine("\nDe som is " + sum + ".");
        }
        public static void VerbruikWagen() {
            Console.Write("Geef het aantal liter in de tank voor de rit: ");
            double litreBefore;
            litreBefore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het aantal liter in de tank na de rit: ");
            double litreAfter;
            litreAfter = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef de kilometerstand van je auto voor de rit: ");
            double kmStandBefore;
            kmStandBefore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef de kilometerstand van je auto na de rit: ");
            double kmStandAfter;
            kmStandAfter = Convert.ToDouble(Console.ReadLine());
            double totalUsage = (100*(litreBefore - litreAfter)/(kmStandAfter - kmStandBefore));
            Console.Write("Het verbruik van de auto is: " + totalUsage);
        }
        public static void BeetjeWiskunde() {
            int firstNumber = (-1+4*6);
            int secondNumber = (35+5) *7;
            int thirdNumber = 14+(-4)*6/11;
            int fourthNumber = 2 + 15 / 6 * 1 - 7 * 2;
            Console.WriteLine(firstNumber + "\n" + secondNumber + "\n" + thirdNumber + "\n" + fourthNumber);
        }
        public static void Gemiddelde() {
            float firstNumber;
            float secondNumber;
            float thirdNumber;
            float fourthNumber;
            float fifthNumber;
            Console.WriteLine("First number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third number: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fourth number: ");
            fourthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fifth number: ");
            fifthNumber = Convert.ToInt32(Console.ReadLine());
            float gemiddelde = (firstNumber+secondNumber+thirdNumber+fourthNumber+fifthNumber)/5;
            Console.WriteLine("Gemiddelde is: " + gemiddelde);
        }
        public static void Maaltafels() {
            Console.WriteLine("Dit zijn de vermenigvuldigen van het getal 411");
            for (int currentMultiplier = 0; currentMultiplier <= 10; currentMultiplier++)
            {
                int table = 511;
                int currentAmount = (table * currentMultiplier);
                Console.WriteLine(currentMultiplier + " * " + table +" is " + currentAmount);
                Console.WriteLine("\n\n\n"+"-PRESS ENTER TO CONTINUE-");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static void Ruimte() {
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

            Console.WriteLine("Op Mercurius voel je je alsof je " + (weight * gravMercurius) + "kg weegt.");
            Console.WriteLine("Op Venus voel je je alsof je " + (weight * gravVenus) + "kg weegt.");
            Console.WriteLine("Op Earth voel je je alsof je " + (weight * gravEarth) + "kg weegt.");
            Console.WriteLine("Op Mars voel je je alsof je " + (weight * gravMars) + "kg weegt.");
            Console.WriteLine("Op Jupiter voel je je alsof je " + (weight * gravJupiter) + "kg weegt.");
            Console.WriteLine("Op Saturnus voel je je alsof je " + (weight * gravSaturnus) + "kg weegt.");
            Console.WriteLine("Op Uranus voel je je alsof je " + (weight * gravUranus) + "kg weegt.");
            Console.WriteLine("Op Neptune voel je je alsof je " + (weight * gravNeptune) + "kg weegt.");
            Console.WriteLine("Op Pluto voel je je alsof je " + (weight * gravPluto) + "kg weegt.");
        }
    }

}
