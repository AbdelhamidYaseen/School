using System;

namespace Labo_Oefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selected;
            Console.WriteLine("======================================================");
            Console.WriteLine("Please select an exercise");
            Console.WriteLine("======================================================");
            Console.WriteLine(
                "01| CountDown\n" +
                "02| Wachtwoord\n" +
                "03| Gemiddelde\n" +
                "04| Feestje\n" +
                "05| AantalDigits\n" +
                "06| VanMin100Tot100\n" +
                "07| EenTafel\n" +
                "08| Veelvouden6En8\n" +
                "09| Priemchecker\n" +
                "10| PriemGenerator\n" +
                "11| FibonacciReeks");
            Console.WriteLine("======================================================");
            selected = Console.ReadLine();
            Console.WriteLine("======================================================");
            if (selected == "01")
            { Loops.CountDown(); }
            else if (selected == "02")
            { Loops.Wachtwoord(); }
            else if (selected == "03")
            { Loops.Gemiddelde(); }
            else if (selected == "04")
            { Loops.Feestje(); }
            else if (selected == "05")
            { Loops.AantalDigits(); }
            else if (selected == "06")
            { Loops.VanMin100Tot100(); }
            else if (selected == "07")
            { Loops.EenTafel(); }
            else if (selected == "08")
            { Loops.Veelvouden6En8(); }
            else if (selected == "09")
            { Loops.Priemchecker(); }
            else if (selected == "10")
            { Loops.PriemGenerator(); }
            else if (selected == "11") {
                Loops.FibonacciReeks();
            }
        }
    }
}
