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






    }
}
