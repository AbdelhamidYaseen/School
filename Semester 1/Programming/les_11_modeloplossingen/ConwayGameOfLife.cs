using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class ConwayGameOfLife
    {
        public enum CellStatus { Levend, Dood }
        public static void ConwayGameOfLifeMain()
        {
            Console.WriteLine("Hoe groot is je bord (l = b)?");
            int aantalCellenBasis = Convert.ToInt32(Console.ReadLine());
            CellStatus[,] conwayGameOfLifeBord = new CellStatus[aantalCellenBasis, aantalCellenBasis];
            Console.WriteLine("Hoeveel generaties wil je laten zien?");
            int aantalGeneraties = Convert.ToInt32(Console.ReadLine());

            Initialiseer(conwayGameOfLifeBord);
            Show(conwayGameOfLifeBord);

            for (int i = 2; i <= aantalGeneraties; i++)
            {
                Thread.Sleep(2000);
                conwayGameOfLifeBord = VolgendeGeneratie(conwayGameOfLifeBord);
                Show(conwayGameOfLifeBord);
            }                
        }
        public static void Initialiseer(CellStatus[,] inArray)
        {
            Random random = new Random();
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    inArray[i, j] = (CellStatus)random.Next(2);
                }
            }
        }
        public static CellStatus[,] VolgendeGeneratie(CellStatus[,] inArray)
        {
            CellStatus[,] newConwayGameOfLifeBord = new CellStatus[inArray.GetLength(0), inArray.GetLength(1)];

           // Any live cell with fewer than two live neighbours dies, as if by underpopulation.
            // Any live cell with two or three live neighbours lives on to the next generation.
            // Any live cell with more than three live neighbours dies, as if by overpopulation.
            // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    int aantalBuren = AantalBuren(inArray, i, j);
                    if (inArray[i, j] == CellStatus.Levend)
                    {
                        if (aantalBuren < 2)
                        {
                            newConwayGameOfLifeBord[i, j] = CellStatus.Dood;
                        }
                        else if (aantalBuren == 2 || aantalBuren == 3)
                        {
                            newConwayGameOfLifeBord[i, j] = CellStatus.Levend;
                        }
                        else
                        {
                            newConwayGameOfLifeBord[i, j] = CellStatus.Dood;
                        }
                    }
                    else
                    {
                        if (aantalBuren == 3)
                        {
                            newConwayGameOfLifeBord[i, j] = CellStatus.Levend;
                        }
                        else
                        {
                            newConwayGameOfLifeBord[i, j] = CellStatus.Dood;
                        }
                    }
                }
            }
            return newConwayGameOfLifeBord;
        }
        public static int AantalBuren(CellStatus[,] inArray, int xcoord, int ycoord)
        {
            int aantalBuren = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (!((xcoord + i < 0 || xcoord + i >= inArray.GetLength(0)) || (ycoord + j < 0 || ycoord + j >= inArray.GetLength(1)) || (i == 0 || j == 0)))
                    { 
                        if (inArray[xcoord + i, ycoord + j] == CellStatus.Levend)
                        {
                            aantalBuren++;
                        }
                    }
                }
            }
            return aantalBuren;
        }

        public static void Show(CellStatus[,] inArray)
        {
            Console.Clear();
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    if (inArray[i, j] == CellStatus.Levend)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}