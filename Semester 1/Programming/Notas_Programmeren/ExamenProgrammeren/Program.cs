using System;

namespace ExamenProgrammeren
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string selected;
            bool flick = true;
            do
            {
                Console.Clear();
                Console.WriteLine("======================================================");
                Console.WriteLine("Please select a Chapter");
                Console.WriteLine("======================================================");
                Console.WriteLine(
                    "01| Labo 1: Introductie\n" +
                    "02| Labo 2: Variabelen en datatypes\n" +
                    "03| Labo 3: Strings en hun methoden\n" +
                    "04| Labo 4: Beslissingen\n" +
                    "05| Labo 5: Loops\n" +
                    "06| Labo 6: Arrays\n" +
                    "07| Labo 7: Methoden\n" +
                    "08| Labo 8: Numerieke data\n" +
                    "09| Labo 9: Meerdimensionaal werken\n" +
                    "10| Labo 10: Gevorderde tekstverwerking\n" +
                    "11| Textcell\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01")      { Console.Clear(); Introductie.SelectionScreen(); }              //DONE
                else if (selected == "02") { Console.Clear(); VariabelenEnDatatypes.SelectionScreen(); }    //DONE
                else if (selected == "03") { Console.Clear(); StringsEnMethoden.SelectionScreen(); }        //DONE
                else if (selected == "04") { Console.Clear(); Beslissingen.SelectionScreen(); }             //DONE
                else if (selected == "05") { Console.Clear(); Loops.SelectionScreen(); }                    //DONE
                else if (selected == "06") { Console.Clear(); Arrays.SelectionScreen(); }                   //DONE
                else if (selected == "07") { Console.Clear(); Methoden.SelectionScreen(); }                 //DONE
                else if (selected == "08") { Console.Clear(); NumeriekeData.SelectionScreen(); }            //DONE
                else if (selected == "09") { Console.Clear(); MeerdimensionaalWerken.SelectionScreen(); }   //DONE
                else if (selected == "10") { Console.Clear(); GevorderdeTekstverwerking.SelectionScreen(); }//DONE
                else if (selected == "11") { Console.Clear(); TextCell.TextCellMain(); }                    //DONE
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
            }
            while (flick);
        }
       /*SELECTIONSCREEN BLUEPRINT
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
    */
    }
}