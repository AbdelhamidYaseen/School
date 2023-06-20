using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal abstract class Personeel : Persoon
    {
        private byte ancienniteit;
        public byte Ancienniteit
        {
            get { return ancienniteit; }
            set { this.ancienniteit = Math.Min((byte)50, value); }
        }
        private Dictionary<string, byte> taken = new Dictionary<string, byte>();
        public ImmutableDictionary<string, byte> Taken
        {
            get { return taken.ToImmutableDictionary<string, byte>(); }
        }

        public static ImmutableList<Personeel> AllePersoneel
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<Personeel>();
                foreach (Persoon persoon in Persoon.AllePersonen)
                {
                    if(persoon is Personeel)
                    {
                        builder.Add((Personeel)persoon);
                    }
                }
                return builder.ToImmutableList<Personeel>();
            }
        }
        public Personeel(string naam, DateTime geboortedatum, Dictionary<string, byte> taken) : base(naam, geboortedatum)
        {
            if (!(taken is null))
            {
                foreach (var item in taken)  //niet this.taken=taken; want dan hebben ze allebei hetzelfde geheugenadres en dan kan taken this.taken nog aanpassen
                {
                    this.taken.Add(item.Key, item.Value);
                }
            }
        }

        public abstract uint BerekenSalaris();

        public override string CSVPersoonsGegevens
        {
            get
            {
                string uitkomst = base.CSVPersoonsGegevens;
                foreach (var item in Taken)
                {
                    uitkomst += $";\"{item.Key}\";{item.Value}";
                }
                return uitkomst;
            }
        }
    }
}
