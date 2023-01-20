using System;

namespace LaboOefeningen
{
    public class NumeriekeData
    {
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

        public static void SchaarSteenPapier() {
            int playerScore = 0;
            int computerScore = 0;
            Random randomGenerator = new Random();
            // Dit is enkel om leesbaarheid code te verbeteren
            // Zo hoeven we niet te onthouden dat 1 voor schaar staat,...
            int SCHAAR = 1;
            int STEEN = 2;
            int PAPIER = 3;
            while (playerScore < 10 && computerScore < 10) {
                Console.WriteLine("Maak een keuze:");
                Console.WriteLine("1 voor schaar");
                Console.WriteLine("2 voor steen");
                Console.WriteLine("3 voor papier");
                int playerChoice = Convert.ToInt32(Console.ReadLine());
                int computerChoice = randomGenerator.Next(1,4);
                if (computerChoice == SCHAAR) {
                    Console.WriteLine("De computer kiest schaar!");
                }
                else if (computerChoice == STEEN) {
                    Console.WriteLine("De computer kiest steen!");
                }
                else {
                    Console.WriteLine("De computer kiest papier!");
                }
                bool playerWins = false;
                bool computerWins = false;
                // DE LANGE MANIER
                if (playerChoice == SCHAAR) {
                    if (computerChoice == STEEN) {
                        computerWins = true;
                    }
                    else if (computerChoice == PAPIER) {
                        playerWins = true;
                    }
                }
                else if (playerChoice == STEEN) {
                    if (computerChoice == PAPIER) {
                        computerWins = true;
                    }
                    else if (computerChoice == SCHAAR) {
                        playerWins = true;
                    }
                }
                else if (playerChoice == PAPIER) {
                    if (computerChoice == SCHAAR) {
                        computerWins = true;
                    }
                    else if (computerChoice == STEEN) {
                        playerWins = true;
                    }
                }
                /* DE KORTE MANIER, iets geavanceerder
                bool playerWins = playerChoice == SCHAAR && computerChoice == PAPIER ||
                                  playerChoice == STEEN && computerChoice == SCHAAR ||
                                  playerChoice == PAPIER && computerChoice == STEEN;
                bool computerWins = !playerWins && playerChoice != computerChoice;*/
                if (playerWins) {
                    playerScore++;
                    Console.WriteLine("Jij wint deze ronde!");
                }
                else if (computerWins) {
                    computerScore++;
                    Console.WriteLine("De computer wint deze ronde!");
                }
                else {
                    Console.WriteLine("Niemand wint deze ronde!");
                }
                // dit kan beknopter maar we gebruiken wat in de les gezien is
                string playerWord = "punten";
                if (playerScore == 1) {
                    playerWord = "punt";
                }
                string computerWord = "punten";
                if (computerScore == 1) {
                    computerWord = "punt";
                }
                Console.WriteLine($"Jij hebt {playerScore} {playerWord}, de computer heeft {computerScore} {computerWord}.");
            }
            if (playerScore == 10) {
                Console.WriteLine("Jij bent gewonnen!");
            }
            else {
                Console.WriteLine("De computer is gewonnen!");
            }
        }
    }
}