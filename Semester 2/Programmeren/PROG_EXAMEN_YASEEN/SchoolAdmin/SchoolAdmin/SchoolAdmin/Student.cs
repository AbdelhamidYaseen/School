using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Student : Persoon
    {

        public ImmutableList<VakInschrijving> VakInschrijvingen
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<VakInschrijving>();
                foreach (var inschrijving in VakInschrijving.AlleVakInschrijvingen)
                {
                    if (this == inschrijving.Student)
                    {
                        builder.Add(inschrijving);
                    }
                }
                //return builder.ToImmutableList<VakInschrijving>();
                return builder.ToImmutable();
            }
        }

        public static ImmutableList<Student> AlleStudenten
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<Student>();
                foreach (Persoon persoon in Persoon.AllePersonen)
                {
                    if (persoon is Student)
                    {
                        builder.Add((Student)persoon);
                    }
                }
                return builder.ToImmutableList<Student>();
            }
        }

        public ImmutableList<Cursus> Cursussen
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<Cursus>();
                foreach (var inschrijving in VakInschrijvingen)
                {
                    builder.Add(inschrijving.Cursus);
                }
                return builder.ToImmutable();
            }
        }


        private Dictionary<DateTime, string> dossier = new Dictionary<DateTime, string>();
        public ImmutableDictionary<DateTime, string> Dossier
        {
            get { return dossier.ToImmutableDictionary<DateTime, string>(); }
        }

        public Student(string naam, DateTime geboorteDatum) : base(naam, geboorteDatum)
        {

        }

        public override string GenereerNaamkaartje()
        {
            return $"{this.Naam} (STUDENT)";
        }

        public override double BepaalWerkbelasting()
        {
            double totaal = 0.0;
            foreach (var inschrijving in VakInschrijvingen)
            {

                totaal += 10;
            }
            return totaal;
        }
        public void RegistreerCursusResultaat(Cursus cursus, byte? resultaat)
        {
            new VakInschrijving(this, cursus, resultaat);
        }
        //public void Kwoteer(byte cursusIndex, byte behaaldCijfer)
        //{
        //    if (behaaldCijfer < 0 || behaaldCijfer > 20 || cursusIndex >= vakInschrijvingen.Count || vakInschrijvingen[cursusIndex] is null)
        //    {
        //        Console.WriteLine("Ongeldig cijfer!");
        //    }
        //    else
        //    {
        //        this.vakInschrijvingen[cursusIndex].Resultaat = behaaldCijfer;
        //    }
        //}

        public double Gemiddelde()
        {
            double totaal = 0;
            int aantalCijfers = 0;
            foreach (VakInschrijving inschrijving in VakInschrijvingen)
            {
                if (!(inschrijving.Resultaat is null))
                {
                    totaal += (byte)inschrijving.Resultaat;
                    aantalCijfers++;
                }
            }
            return totaal / aantalCijfers;
        }



        public void ToonOverzicht()
        {
            Console.WriteLine($"{this.Naam}, {Leeftijd} jaar");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*************");
            foreach (VakInschrijving inschrijving in VakInschrijvingen)
            {
                if (inschrijving != null)
                {
                    Console.WriteLine($"{inschrijving.Cursus.Titel}:\t{inschrijving.Resultaat}");
                }
            }
            Console.WriteLine($"Gemiddelde:\t{this.Gemiddelde():F1}\n");
        }
        public static void DemonstreerStudenten()
        {
            Cursus communicatie = new Cursus("Communicatie");
            Cursus programmeren = new Cursus("Programmeren");
            Cursus webtechnologie = new Cursus("Webtechnologie", 6);
            Cursus databanken = new Cursus("Databanken", 5);

            Student student1 = new Student("Said Aziz", new DateTime(2001, 1, 3));
            student1.RegistreerCursusResultaat(communicatie, 12);
            student1.RegistreerCursusResultaat(programmeren, null);
            student1.RegistreerCursusResultaat(webtechnologie, 13);
            student1.ToonOverzicht();

            Student student2 = new Student("Mieke Vermeulen", new DateTime(2000, 2, 1));
            student2.RegistreerCursusResultaat(communicatie, 13);
            student2.RegistreerCursusResultaat(programmeren, 16);
            student2.RegistreerCursusResultaat(databanken, 14);
            student2.ToonOverzicht();
        }
        public static Student StudentUitTekstformaat(string csvWaarde)
        {
            string[] gegevens = csvWaarde.Split(";");
            int dag = Convert.ToInt32(gegevens[1]);
            int maand = Convert.ToInt32(gegevens[2]);
            int jaar = Convert.ToInt32(gegevens[3]);
            Student nieuweStudent = new Student(gegevens[0], new DateTime(jaar, maand, dag));
            for (int i = 4; i < gegevens.Length; i += 2)
            {
                int vakId = Convert.ToInt32(gegevens[i]);
                Cursus vak = Cursus.ZoekCursusOpId(vakId);
                if (!(vak is null))
                {
                    byte resultaat = Convert.ToByte(gegevens[i + 1]);
                    nieuweStudent.RegistreerCursusResultaat(vak, resultaat);
                }
            }
            return nieuweStudent;
        }
        public static void DemonstreerStudentUitTekstFormaat()
        {
            Console.WriteLine("Geef de tekstvoorstelling van 1 student in csv-formaat:");
            string csv = Console.ReadLine();
            Student student = Student.StudentUitTekstformaat(csv);
            student.ToonOverzicht();
        }

        public override string ToString()
        {
            return base.ToString() + "\nMeerbepaald, student";
        }


        public static void LeesVanafCommandLine()
        {
            Console.WriteLine("Naam van de student?");
            string naam = Console.ReadLine();
            Console.WriteLine("Geboortedatum van de student?");
            DateTime geboorteDatum = Convert.ToDateTime(Console.ReadLine());
            new Student(naam, geboorteDatum);
        }
        public static void ToonStudenten()
        {
            Console.WriteLine("In welke volgorde wil je studenten tonen?");
            Console.WriteLine("1. Stijgend alfabetisch");
            Console.WriteLine("2. Dalend alfabetisch");
            string antwoord = Console.ReadLine();
            IComparer<Student> comparer = null;
            if (antwoord == "1")
            {
                comparer = new StudentenVolgensNaamStijgendComparer();
            }
            else
            {
                comparer = new StudentenVolgensNaamDalendComparer();
            }
            ImmutableList<Student> gesorteerd = AlleStudenten.Sort(comparer);
            foreach (var item in gesorteerd)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public override string ToCSV()
        {
            string uitkomst = $"Student;{CSVPersoonsGegevens}";
            foreach (var item in Dossier)
            {
                uitkomst += $";{item.Key};{item.Value}";
            }
            return uitkomst;
        }
    }
}
