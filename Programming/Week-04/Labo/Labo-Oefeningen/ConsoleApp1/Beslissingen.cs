using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Beslissingen
    {
        public static void SchoenenVerkoper(){

            int realPrice;
            double price = 50;
            int amount;
            Console.WriteLine("Hoeveel paar schoenen wil je kopen?");
            amount = Convert.ToInt32(Console.ReadLine());
            price = price * amount;

            if (amount > 2){
                price = price - price * 0.10;
            }
            else { 
                
            }
            Console.WriteLine($"De prijs voor {amount} paar schoenen is {price} EUR ");
        }
        public static void EvenOneven() {
            int getal;

            Console.WriteLine("Geef een getal");
            getal = Convert.ToInt32(Console.ReadLine());
            if (getal / 2 == 0)
            {
                Console.WriteLine($"Het {getal} is even");

            }
            else 
            {
                Console.WriteLine($"Het {getal} is even");
            }




        }
        public static void PositiefNegatiefNul(){
            int getal;
            Console.WriteLine("Geef een getal");
            getal = Convert.ToInt32(Console.ReadLine());

            if (getal>0)
            {
                Console.WriteLine($"Het getal {getal} is positief");
            }
            else {
                if (getal<0) {
                    Console.WriteLine($"Het getal {getal} is negatief");
                }
                else {
                    Console.WriteLine("Het getal is nul");
                }
            }
        }
    }
}
