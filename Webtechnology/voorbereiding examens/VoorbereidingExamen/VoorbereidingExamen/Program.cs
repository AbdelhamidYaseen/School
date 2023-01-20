using System;

namespace VoorbereidingExamen
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
                "01| Christmastree\n" +
                "02| ArmstrongChecker\n" +
                "03| xxx\n" +
                "04| xxx\n" +
                "05| xxx\n" +
                "06| xxx\n" +
                "07| xxx\n" +
                "08| xxx\n" +
                "09| xxx\n" +
                "10| xxx\n" +
                "11| xxx");
            Console.WriteLine("======================================================");
            selected = Console.ReadLine();
            Console.WriteLine("======================================================");
            if (selected == "01")
            { Oefeningen.Christmastree(); }
            else if (selected == "02")
            { Oefeningen.ArmstrongChecker(); }
            else if (selected == "03")
            {  }
            else if (selected == "04")
            {  }
            else if (selected == "05")
            {  }
            else if (selected == "06")
            {  }
            else if (selected == "07")
            {  }
            else if (selected == "08")
            {  }
            else if (selected == "09")
            {  }
            else if (selected == "10")
            {  }
            else if (selected == "11")
            {  }
            else if (selected == "12")
            { }
            else if (selected == "13")
            { }
            else if (selected == "14")
            { }
            else if (selected == "15")
            { }
        }
    }
}