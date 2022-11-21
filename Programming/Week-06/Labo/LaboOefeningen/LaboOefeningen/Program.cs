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
                    "01| Oefening 1\n" +
                    "02| Oefening 2\n" +
                    "03| Oefening 3\n" +
                    "04| Oefening 4\n" +
                    "05| Oefening 5\n" +
                    "06| Oefening 6\n" +
                    "07| Oefening 7\n" +
                    "08| Oefening 8\n" +
                    "09| Oefening 9\n"
                    );
                Console.WriteLine("======================================================");
                selected = Console.ReadLine();
                Console.WriteLine("======================================================");
                if (selected == "01") { Console.Clear(); Arrays.ArrayTrueFalse(); flick = false; }
                else if (selected == "02") { Console.Clear(); Arrays.ArrayOefener1(); flick = false; }
                else if (selected == "03") { Console.Clear(); Arrays.Boodschappenlijst(); flick = false; }
                else if (selected == "04") { Console.Clear(); Arrays.KerstInkopen(); flick = false; }
                else if (selected == "05") { Console.Clear(); Arrays.Lotto(); flick = false; }
                else if (selected == "06") { Console.Clear(); Arrays.IntegerIndexOf(); flick = false; }
                else if (selected == "07") { Console.Clear(); Arrays.BinarySearch(); flick = false; }
                else if (selected == "08") { Console.Clear(); Arrays.BoodschappenlijstList(); flick = false; }
                else if (selected == "09") { Console.Clear(); Arrays.KerstinkopenList(); flick = false; }
                else { Console.WriteLine("Please select a correct input"); }
                Console.WriteLine("\n======================================================");
            }
            while (flick);
        }
    }
}
