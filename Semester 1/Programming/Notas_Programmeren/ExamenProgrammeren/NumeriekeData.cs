using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammeren
{
    internal class NumeriekeData
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
                    "01| Oef 1: xxx\n" +
                    "02| Oef 2: xxx\n" +
                    "03| Oef 3: xxx\n" +
                    "04| Oef 4: xxx\n" +
                    "05| Oef 5: xxx\n" +
                    "06| Oef 6: xxx\n" +
                    "07| Oef 7: xxx\n" +
                    "08| Oef 8: xxx\n" +
                    "09| Oef 9: xxx\n" +
                    "10| Oef 10: xxx\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01") { Console.Clear(); }
                else if (selected == "02") { Console.Clear(); }
                else if (selected == "03") { Console.Clear(); }
                else if (selected == "04") { Console.Clear(); }
                else if (selected == "05") { Console.Clear(); }
                else if (selected == "06") { Console.Clear(); }
                else if (selected == "07") { Console.Clear(); }
                else if (selected == "08") { Console.Clear(); }
                else if (selected == "09") { Console.Clear(); }
                else if (selected == "10") { Console.Clear(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
        public static void Keuzemenu()
        {
            Console.WriteLine("1 - Lengte, oppervlakte, volume");
            Console.WriteLine("2 - Schaar, steen, papier");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                LengteOppervlakteVolume();
            }
            else if (answer == 2)
            {
                SchaarSteenPapier();
            }
        }

        public static void LengteOppervlakteVolume()
        {
            Console.WriteLine("Hoe lang is de zijde in meter?");
            double zijde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De lengte is: {zijde}m");
            Console.WriteLine($"De oppervlakte is: {Math.Pow(zijde, 2)}m²");
            Console.WriteLine($"Het volume is: {Math.Pow(zijde, 3)}m³");
        }

        public static void SchaarSteenPapier()
        {
            int playerScore = 0;
            int computerScore = 0;
            Random randomGenerator = new Random();
            // Dit is enkel om leesbaarheid code te verbeteren
            // Zo hoeven we niet te onthouden dat 1 voor schaar staat,...
            int SCHAAR = 1;
            int STEEN = 2;
            int PAPIER = 3;
            while (playerScore < 10 && computerScore < 10)
            {
                Console.WriteLine("Maak een keuze:");
                Console.WriteLine("1 voor schaar");
                Console.WriteLine("2 voor steen");
                Console.WriteLine("3 voor papier");
                int playerChoice = Convert.ToInt32(Console.ReadLine());
                int computerChoice = randomGenerator.Next(1, 4);
                if (computerChoice == SCHAAR)
                {
                    Console.WriteLine("De computer kiest schaar!");
                }
                else if (computerChoice == STEEN)
                {
                    Console.WriteLine("De computer kiest steen!");
                }
                else
                {
                    Console.WriteLine("De computer kiest papier!");
                }
                bool playerWins = false;
                bool computerWins = false;
                // DE LANGE MANIER
                if (playerChoice == SCHAAR)
                {
                    if (computerChoice == STEEN)
                    {
                        computerWins = true;
                    }
                    else if (computerChoice == PAPIER)
                    {
                        playerWins = true;
                    }
                }
                else if (playerChoice == STEEN)
                {
                    if (computerChoice == PAPIER)
                    {
                        computerWins = true;
                    }
                    else if (computerChoice == SCHAAR)
                    {
                        playerWins = true;
                    }
                }
                else if (playerChoice == PAPIER)
                {
                    if (computerChoice == SCHAAR)
                    {
                        computerWins = true;
                    }
                    else if (computerChoice == STEEN)
                    {
                        playerWins = true;
                    }
                }
                /* DE KORTE MANIER, iets geavanceerder
                bool playerWins = playerChoice == SCHAAR && computerChoice == PAPIER ||
                                  playerChoice == STEEN && computerChoice == SCHAAR ||
                                  playerChoice == PAPIER && computerChoice == STEEN;
                bool computerWins = !playerWins && playerChoice != computerChoice;*/
                if (playerWins)
                {
                    playerScore++;
                    Console.WriteLine("Jij wint deze ronde!");
                }
                else if (computerWins)
                {
                    computerScore++;
                    Console.WriteLine("De computer wint deze ronde!");
                }
                else
                {
                    Console.WriteLine("Niemand wint deze ronde!");
                }
                // dit kan beknopter maar we gebruiken wat in de les gezien is
                string playerWord = "punten";
                if (playerScore == 1)
                {
                    playerWord = "punt";
                }
                string computerWord = "punten";
                if (computerScore == 1)
                {
                    computerWord = "punt";
                }
                Console.WriteLine($"Jij hebt {playerScore} {playerWord}, de computer heeft {computerScore} {computerWord}.");
            }
            if (playerScore == 10)
            {
                Console.WriteLine("Jij bent gewonnen!");
            }
            else
            {
                Console.WriteLine("De computer is gewonnen!");
            }
        }

    }
}
