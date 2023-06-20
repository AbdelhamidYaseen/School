using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class StudieProgramma
    {
        private string naam;
        public string Naam
        {
            get { return naam; }
        }
        private Dictionary<Cursus,byte> cursussen = new Dictionary<Cursus, byte>();
        public  ImmutableDictionary<Cursus,byte> Cursussen
        {
            get
            {
                return cursussen.ToImmutableDictionary<Cursus,byte>();
            }
        }

        public StudieProgramma(string naam)
        {
            this.naam = naam;
        }
        public void ToonOverzicht()
        {
            Console.WriteLine($"Programma: {Naam}\n");
            foreach (Cursus cursus in Cursussen.Keys)
            {
                if (!(cursus is null))
                {
                    cursus.ToonOverzicht();
                }
            }
        }
        public static void DemonstreerStudieProgramma()
        {
            Cursus communicatie = new Cursus("Communicatie");
            Cursus programmeren = new Cursus("Programmeren");
            Cursus databanken = new Cursus("Databanken", 5);
            Cursus scripting = new Cursus("Scripting");
            Dictionary<Cursus,byte> cursussen1 = new Dictionary<Cursus,byte>{ { communicatie, 1 }, { programmeren, 1 }, { databanken, 1 } };
            Dictionary<Cursus, byte> cursussen2 = new Dictionary<Cursus, byte> { { communicatie, 2 }, { scripting, 1 }, { databanken, 1 } };
            StudieProgramma programmerenProgramma = new StudieProgramma("Programmeren");
            StudieProgramma snbProgramma = new StudieProgramma("Systeem- en netwerkbeheer");
            programmerenProgramma.cursussen = cursussen1;
            snbProgramma.cursussen = cursussen2;
            snbProgramma.cursussen.Remove(databanken);
            programmerenProgramma.ToonOverzicht();
            snbProgramma.ToonOverzicht();
        }

    }
}
