using System;

namespace LaboOefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Uit welk hoofdstuk wil je een oefening?");
                Console.WriteLine("8 - TextCell");
                Console.WriteLine("9 - TextCell met rand()");
                Console.WriteLine("10 - TextCell met kommagetallen");
                Console.WriteLine("11 - Numerieke data");
                // TODO: zelf de resterende onderwerpen aanvullen
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice == 8) {
                    TextCell.TextCellMain();
                }
                else if (choice == 9) {
                    TextCellMetRandom.TextCellMain();
                }
                else if (choice == 10) {
                    TextCellMetKomma.TextCellMain();
                }
                else if (choice == 11)
                {
                    NumeriekeData.Keuzemenu();
                }
            }
        }
    }
}
