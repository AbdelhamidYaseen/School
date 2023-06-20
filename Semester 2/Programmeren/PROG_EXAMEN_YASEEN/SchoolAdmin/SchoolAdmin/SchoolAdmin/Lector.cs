using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Lector : Personeel
    {

        private Dictionary<Cursus, double> cursussen=new Dictionary<Cursus, double>();

        public static ImmutableList<Lector> AlleLectoren
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<Lector>();
                foreach (Persoon pers in Persoon.AllePersonen)
                {
                    if (pers is Lector)
                    {
                        builder.Add((Lector)pers);
                    }
                }
                return builder.ToImmutableList<Lector>();
            }
        }

        public Lector(string naam, DateTime geboortedatum, Dictionary<string, byte> taken) : base(naam, geboortedatum, taken)
        {
          
        }
        public override double BepaalWerkbelasting()
        {
            double totaal = 0;
            foreach (var item in cursussen)
            {
                totaal += item.Value;
            }
            return totaal;
        }
        public override uint BerekenSalaris()
        {
            // per 4 jaar 120 euro extra bovenop basisloon 2200 (ancienniteit is max 40 jaar)
            // maar tewerkstelling moet ook in rekening gebracht (max 40u)
            double basis = 2200 + (Ancienniteit / 4 * 120);
            double breuk = BepaalWerkbelasting() / 40;
            return (uint)(basis * breuk);
        }
        public override string GenereerNaamkaartje()
        {
            string infoLector = this.Naam;
            infoLector += "\nLector voor:";
            foreach (Cursus cursus in cursussen.Keys)
            {
                infoLector += "\n" + cursus.Titel;
            }
            return infoLector;
        }
        public static void DemonstreerLectoren()
        {
            var taken = new Dictionary<string, byte>();
            var economie = new Cursus("Economie");
            var statistiek = new Cursus("Statistiek");
            var analytischeMeetkunde = new Cursus("Analytische meetkunde");
            var anna = new Lector("Anna Bolzano", new DateTime(1975, 6, 12), taken);
            anna.cursussen.Add(economie, 3);
            anna.cursussen.Add(statistiek, 3);
            anna.cursussen.Add(analytischeMeetkunde, 4);
            anna.Ancienniteit = 9;
            foreach (var personeel in Personeel.AllePersoneel)
            {
                Console.WriteLine(personeel.GenereerNaamkaartje());
            }
            foreach (var personeel in Lector.AlleLectoren)
            {
                Console.WriteLine(personeel.GenereerNaamkaartje());
            }
            Console.WriteLine(anna.BerekenSalaris());
            Console.WriteLine(anna.BepaalWerkbelasting());
        }

 
        public override string ToString()
        {
            return base.ToString() + "\nMeerbepaald, lector";
        }
        public override string ToCSV()
        {
            string uitkomst = $"Lector;{CSVPersoonsGegevens}";
            foreach (var item in cursussen)
            {
                uitkomst += $";{item.Key.Id};{item.Value}";
            }
            return uitkomst;
        }

    }

}
