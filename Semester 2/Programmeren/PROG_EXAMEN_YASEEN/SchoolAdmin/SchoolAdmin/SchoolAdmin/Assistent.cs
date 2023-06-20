using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Assistent : Personeel
    {
        public Assistent(string naam, DateTime geboortedatum, Dictionary<string, byte> taken) : base(naam, geboortedatum, taken)
        {

        }



        private Dictionary<Lector, byte> alletaken = new Dictionary<Lector, byte>();
        private DateTime dateTime;
        private (string Naam, int) value;

        public ImmutableDictionary<Lector, byte> AlleTaken
        {
            get
            {
                return alletaken.ToImmutableDictionary<Lector, byte>();
            }
        }
        public override double BepaalWerkbelasting()
        {
            double totaal = 0.0;
            foreach (var taak in AlleTaken)
            {

                totaal += taak.Value;
            }
            return totaal;
        }
        public override string GenereerNaamkaartje() 
        {
            return $"{this.Naam} assistent van\n{this.Lectoren}\n=========================\nDe taken van de assistent:\n{this.AlleTaken}\nSalaris van de assistent: {this.BerekenSalaris()}";
        }
        public override uint BerekenSalaris() {
            double basis = 2500;
            double breuk = BepaalWerkbelasting() / 40;
            return (uint)(basis * breuk);
        }
        public ImmutableList<Lector> Lectoren { get; set; }

        public override string ToCSV()
        {
            return $"Assistent;\n {this.CSVPersoonsGegevens} ";
        }
        public void DemonstreerAssistent() 
        {
            Lector lector1 = new Lector("Emmett Brown", new DateTime(1914, 1, 13), ("labo programmeren" ,8));
            Lector lector2 = new Lector("Jeremias Gobelijn", new DateTime(1942, 1, 25), ("begeleiden stagiairs", 8));
            Assistent assistent1 = new Assistent("“Marty McFly", new DateTime(1968, 1, 12), (lector1.Naam, 5));

        }
    }
}
