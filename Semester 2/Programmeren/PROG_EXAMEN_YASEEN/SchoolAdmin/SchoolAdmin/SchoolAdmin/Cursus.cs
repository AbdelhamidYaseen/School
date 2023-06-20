using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Cursus: ICSVSerializable
    {

        public string Titel;

        private int id;
        public int Id
        {
            get { return id; }
        }

        private static int maxId = 1;

        private byte studiepunten;
        public byte Studiepunten
        {
            get { return studiepunten; }
            private set { studiepunten = value; }
        }
        private static List<Cursus> alleCursussen = new List<Cursus>();
        public static ImmutableList<Cursus> AlleCursussen
        {
            get
            {
                return alleCursussen.ToImmutableList<Cursus>();
            }
        }
        public ImmutableList<VakInschrijving> VakInschrijvingen
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<VakInschrijving>();
                foreach (var inschrijving in VakInschrijving.AlleVakInschrijvingen)
                {
                    if (inschrijving.Cursus == this)
                    {
                        builder.Add(inschrijving);
                    }
                }
                return builder.ToImmutable();
            }
        }
        public ImmutableList<Student> Studenten
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<Student>();
                foreach (var inschrijving in VakInschrijvingen)
                {
                    builder.Add(inschrijving.Student);
                }
                return builder.ToImmutable();
            }
        }

        public Cursus(string titel, byte studiepunten)
        {
            this.Titel = titel;
            this.id = Cursus.maxId;
            foreach (var bestaand in AlleCursussen)
            {
                if (bestaand.Titel == this.Titel)
                {
                    throw new DuplicateDataException("Nieuwe cursus heeft dezelfde naam als een bestaande cursus", this, bestaand);
                }
            }
            Cursus.maxId++;
            Studiepunten = studiepunten;
            Cursus.registreerCursus(this);
        }

        public Cursus(string titel) : this(titel, 3)
        {

        }

        public void ToonOverzicht()
        {
            Console.WriteLine($"{this.Titel} ({this.Id}) ({this.Studiepunten} stp)");
            foreach (var student in Studenten)
            {
                if (student != null)
                {
                    Console.WriteLine($"{student.Naam}");
                }
            }
            Console.WriteLine();
        }
        private static void registreerCursus(Cursus cursus)
        {
            alleCursussen.Add(cursus);
        }

        public static Cursus ZoekCursusOpId(int id)
        {
            foreach (var cursus in AlleCursussen)
            {
                if (id == cursus.Id)
                {
                    return cursus;
                }
            }
            return null;
        }


        public static void DemonstreerCursussen()
        {
            Cursus communicatie = new Cursus("Communicatie");
            Cursus programmeren = new Cursus("Programmeren");
            Cursus webtechnologie = new Cursus("Webtechnologie", 6);
            Cursus databanken = new Cursus("Databanken", 5);

            Student student1 = new Student("Said Aziz", new DateTime(2001, 1, 3));
            student1.RegistreerCursusResultaat(communicatie, 12);
            student1.RegistreerCursusResultaat(programmeren, null);
            student1.RegistreerCursusResultaat(webtechnologie, 13);

            Student student2 = new Student("Mieke Vermeulen", new DateTime(2000, 2, 1));
            student2.RegistreerCursusResultaat(communicatie, 13);
            student2.RegistreerCursusResultaat(programmeren, 16);
            student2.RegistreerCursusResultaat(databanken, 14);

            communicatie.ToonOverzicht();
            programmeren.ToonOverzicht();
            webtechnologie.ToonOverzicht();
            databanken.ToonOverzicht();

        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            else if (!(obj is Cursus))
            {
                return false;
            }
            else
            {
                return ((Cursus)obj).Id == this.Id;
            }
        }
        public override int GetHashCode()
        {
            return this.Id;
        }
        public static void LeesVanafCommandLine()
        {
            Console.WriteLine("Titel van de cursus?");
            string titel = Console.ReadLine();
            Console.WriteLine("Aantal studiepunten?");
            byte aantalStudiepunten = Convert.ToByte(Console.ReadLine());
            try
            {
                new Cursus(titel, aantalStudiepunten);
            }
            catch (DuplicateDataException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Id van de bestaande cursus: {((Cursus)e.Waarde2).Id}");
            }
        }
        public static void ToonCursussen()
        {
            Console.WriteLine("In welke volgorde wil je cursussen tonen?");
            Console.WriteLine("1. Stijgend alfabetisch");
            Console.WriteLine("2. Volgens studiepunten");
            string antwoord = Console.ReadLine();
            IComparer<Cursus> comparer = null;
            if (antwoord == "1")
            {
                comparer = new CursussenVolgensTitelComparer();
            }
            else
            {
                comparer = new CursussenVolgensStudiepuntenComparer();
            }
            var gesorteerd = AlleCursussen.Sort(comparer);
            foreach (var item in gesorteerd)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public override string ToString()
        {
            return $"{this.Titel} ({this.Studiepunten})";
        }





        public string ToCSV()
        {
            return $"Cursus;{this.Id};\"{this.Titel}\";{this.Studiepunten}";
        }

    }
}
