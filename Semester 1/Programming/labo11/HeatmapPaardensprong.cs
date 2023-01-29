using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class HeatmapPaardensprong
    {
        public static void HeatmapPaardensprongMain()
        {
            int[,] schaakBord = new int[8, 8];
            
            Console.WriteLine("Hoeveel keer wil je je paard laten springen?");
            int aantalSprongen = Convert.ToInt32(Console.ReadLine());
            // positie: A1 links vanonder = (0,0) in oze schaakBord array, H8 rechts vanboven = (8,8) in onze schaakBord array 
            Console.WriteLine("Wat is de initiele positie van het paard (A1..H8)");
            string positie = Console.ReadLine(); 
            for (int i = 0; i < aantalSprongen; i++)
            {
                positie = Spring(schaakBord, positie);
            }
            Console.WriteLine("De heatmap ziet er als volgt uit:");
            for (int i = 7; i >= 0; i--)        // de rijen van ons schaakbord (1 is onder) 
            {
                for (int j = 0; j < 8; j++)     // de kolommen van ons schaakbord
                {
                    Console.Write($"{schaakBord[i, j]:D3} ");
                }
                Console.WriteLine();
            }           



        }
        public static string Spring(int[,] schaakBord, string inPositie)
        {
            int positieY = (char)inPositie[0] - 'A';                        // De kolommen in onze schakkbord array
            int positieX = Convert.ToInt32(inPositie.Substring(1, 1)) - 1;  // De rijen in onze schaakbord array
            int nieuwePositieX = 0;
            int nieuwePositieY = 0;
            Random random = new Random();

            // 8 mogelijke keuzes
            bool geldigeSprong = false;
            while (!geldigeSprong)
            {
                int keuzeSprong = random.Next(8);
                // 2 naar links, 1 naar boven
                if (keuzeSprong == 0)
                {
                    nieuwePositieY = positieY - 2;
                    nieuwePositieX = positieX + 1;
                }  
                // 1 naar links, 2 naar boven
                if (keuzeSprong == 1)
                {
                    nieuwePositieY = positieY - 1;
                    nieuwePositieX = positieX + 2;
                }  
                // 1 naar rechts, 2 naar boven
                if (keuzeSprong == 2)
                {
                    nieuwePositieY = positieY + 1;
                    nieuwePositieX = positieX + 2;
                }  
                // 2 naar rechts, 1 naar boven
                if (keuzeSprong == 3)
                {
                    nieuwePositieY = positieY + 2;
                    nieuwePositieX = positieX + 1;
                }  
                // 2 naar rechts, 1 naar onder
                if (keuzeSprong == 4)
                {
                    nieuwePositieY = positieY + 2;
                    nieuwePositieX = positieX - 1;
                }  
                // 1 naar rechts, 2 naar onder
                if (keuzeSprong == 5)
                {
                    nieuwePositieY = positieY + 1;
                    nieuwePositieX = positieX - 2;
                }  
                // 1 naar links, 2 naar onder
                if (keuzeSprong == 6)
                {
                    nieuwePositieY = positieY - 1;
                    nieuwePositieX = positieX - 2;
                }  
                // 2 naar links, 1 naar onder
                if (keuzeSprong == 7)
                {
                    nieuwePositieY = positieY - 2;
                    nieuwePositieX = positieX - 1;
                }  
                if ((0 <= nieuwePositieX && nieuwePositieX < 8) &&
                    (0 <= nieuwePositieY && nieuwePositieY < 8))
                {
                    geldigeSprong = true;
                }
            }
            schaakBord[nieuwePositieX, nieuwePositieY]++;
            return $"{(char)(nieuwePositieY + (int)'A')}{nieuwePositieX + 1}"; 
        }
    }
}