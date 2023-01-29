using System;

namespace LaboOefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selected;
            bool flick = true;
            do
            {
                Console.WriteLine("======================================================");
                Console.WriteLine("Please select an exercise");
                Console.WriteLine("======================================================");
                Console.WriteLine(
                    "01| ArrayTrueFalse\n" +
                    "02| ArrayOefener1\n" +
                    "03| Boodschappenlijst\n" +
                    "04| Kerstinkopen\n" +
                    "05| Lotto\n" +
                    "06| IntegerIndexOf\n" +
                    "07| BinarySearch\n" +
                    "08| BoodschappenlijstList\n" +
                    "09| KerstinkopenList\n" +
                    "10| Galgje\n" +
                    "99| END-PROGRAM"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01") { Console.Clear(); Arrays.ArrayTrueFalse(); }
                else if (selected == "02") { Console.Clear(); Arrays.ArrayOefener1(); }
                else if (selected == "03") { Console.Clear(); Arrays.Boodschappenlijst(); }
                else if (selected == "04") { Console.Clear(); Arrays.Kerstinkopen(); }
                else if (selected == "05") { Console.Clear(); Arrays.Lotto(); }
                else if (selected == "06") { Console.Clear(); Arrays.IntegerIndexOf(); }
                else if (selected == "07") { Console.Clear(); Arrays.BinarySearch(); }
                else if (selected == "08") { Console.Clear(); Arrays.BoodschappenlijstList(); }
                else if (selected == "09") { Console.Clear(); Arrays.KerstinkopenList(); }
                else if (selected == "10") { Console.Clear(); Arrays.Galgje(); }
                else if (selected == "99") { Console.Clear(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
                Console.WriteLine("\n======================================================");
            }
            while (flick);
        }
    }
}
