using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace SchoolAdmin
{
    internal class VakInschrijving
    {
        private Cursus cursus;

        public Cursus Cursus
        {
            get { return cursus; }
            private set
            {
                if (value is null)
                {
                    throw new ArgumentException("Cursus mag niet ontbreken.");
                }
                cursus = value;
            }
        }

        private byte? resultaat;
        public byte? Resultaat
        {
            get
            {
                return resultaat;
            }
            set
            {
                if (value is null || !(value > 20 || value < 0))
                {
                    resultaat = value;
                }
            }
        }

        private Student student;

        public Student Student
        {
            get { return student; }
            private set
            {
                if (value is null)
                {
                    throw new ArgumentException("Student mag niet ontbreken.");
                }
                student = value;
            }
        }

        private static List<VakInschrijving> alleVakInschrijvingen = new List<VakInschrijving>();

        public static ImmutableList<VakInschrijving> AlleVakInschrijvingen
        {
            get { return alleVakInschrijvingen.ToImmutableList(); }
        }

        public VakInschrijving(Student student, Cursus cursus, byte? resultaat)
        {
            this.Cursus = cursus;
            this.Resultaat = resultaat;
            this.Student = student;
            int teller = 0;
            foreach (VakInschrijving inschrijving in AlleVakInschrijvingen)
            {
                if (inschrijving.Cursus == cursus && inschrijving.Student == student)
                {
                    throw new ArgumentException("Een student kan niet meermaals inschrijven voor hetzelfde vak.");
                }
                else if (inschrijving.Cursus == cursus && inschrijving.Resultaat is null)
                {
                    teller++;
                }
            }
            if (teller>=20 && resultaat is null)
            {
                throw new CapaciteitOverschredenException($"Er zijn al te veel studenten ingeschreven" +
                    " voor {cursus.Titel}");
            }

            alleVakInschrijvingen.Add(this);
        }
        public static void LeesVanafCommandLine()
        {
            if (Student.AlleStudenten.Count < 1 || Cursus.AlleCursussen.Count < 1)
            {
                Console.WriteLine("Er moet minstens één student en minstens één cursus in het systeem zijn.");
            }
            else
            {
                Console.WriteLine("Welke student?");
                Console.WriteLine("0. null");
                for (int i = 0; i < Student.AlleStudenten.Count; i++)
                {
                    Console.WriteLine($"{i + 1}\n{Student.AlleStudenten[i]}");
                }
                Student student;
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                if (index == -1)
                {
                    student = null;
                }
                else
                {
                    student = Student.AlleStudenten[index];
                }
                Console.WriteLine("Welke cursus?");
                Console.WriteLine("0. null");
                for (int i = 0; i < Cursus.AlleCursussen.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {Cursus.AlleCursussen[i].Titel}");
                }
                Cursus cursus;
                index = Convert.ToInt32(Console.ReadLine()) - 1;
                if (index == -1)
                {
                    cursus = null;
                }
                else
                {
                    cursus = Cursus.AlleCursussen[index];
                }
                byte? resultaat = null;
                Console.WriteLine("Wil je een resultaat toekennen?");
                if (Console.ReadLine().ToLower().Trim() == "ja")
                {
                    Console.WriteLine("Wat is het resultaat?");
                    resultaat = Convert.ToByte(Console.ReadLine());
                }
                try
                {
                    new VakInschrijving(student, cursus, resultaat);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (CapaciteitOverschredenException coe)
                {
                    Console.WriteLine(coe.Message);
                }
            }
        }
        public static void ToonInschrijvingsGegevens()
        {
            foreach (var item in VakInschrijving.AlleVakInschrijvingen)
            {
                Console.WriteLine($"{item.Student}\ningeschreven voor\n{item.Cursus.Titel}");
            }
        }

    }
}
