using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal abstract class Persoon : ICSVSerializable
    {
        private uint id;
        public uint Id
        {
            get { return id; }
        }
        private static uint maxId = 1;

        private DateTime geboorteDatum;
        public DateTime GeboorteDatum
        {
            get { return geboorteDatum; }
        }
        public byte Leeftijd
        {
            get
            {
                DateTime nu = DateTime.Now;
                int aantalJaar = nu.Year - this.GeboorteDatum.Year - 1;
                if (nu.Month > this.GeboorteDatum.Month || nu.Month == this.GeboorteDatum.Month && nu.Day >= this.GeboorteDatum.Day)
                {
                    return (byte)(aantalJaar + 1);
                }

                else
                {
                    return (byte)aantalJaar;
                }
            }
        }

        private string naam;
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        private static List<Persoon> allePersonen = new List<Persoon>();
        public static ImmutableList<Persoon> AllePersonen
        {
            get { return allePersonen.ToImmutableList<Persoon>(); }
        }
        public Persoon(string naam, DateTime geboorteDatum)
        {
            this.id = maxId;
            maxId++;
            this.Naam = naam;
            this.geboorteDatum = geboorteDatum;
            allePersonen.Add(this);
        }
        public abstract double BepaalWerkbelasting();
        public abstract string GenereerNaamkaartje();

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            else if (!(obj is Persoon))
            {
                return false;
            }
            else
            {
                return ((Persoon)obj).Id == this.Id;
            }
        }

        public override int GetHashCode()
        {
            return (int)this.Id;
        }


        public override string ToString()
        {
            string tekst = "";
            tekst += "Persoon\n";
            tekst += "______\n";
            tekst += $"Naam: {this.Naam}\n";
            tekst += $"Leeftijd: {Leeftijd}";
            return tekst;
        }

        public abstract string ToCSV();

        public virtual string CSVPersoonsGegevens
        {
            get
            {
                return $"{Id};\"{Naam}\";{GeboorteDatum.ToString(new CultureInfo("nl-BE"))}";
            }

        }
    }
}
