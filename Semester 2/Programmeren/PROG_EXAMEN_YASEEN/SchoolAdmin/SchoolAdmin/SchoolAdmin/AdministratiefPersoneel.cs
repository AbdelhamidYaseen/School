using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class AdministratiefPersoneel : Personeel
    {
        public static ImmutableList<AdministratiefPersoneel> AlleAdministratiefPersoneel
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<AdministratiefPersoneel>();
                foreach (Persoon pers in Persoon.AllePersonen)
                {
                    if (pers is AdministratiefPersoneel)
                    {
                        builder.Add((AdministratiefPersoneel)pers);
                    }
                }
                return builder.ToImmutableList<AdministratiefPersoneel>();
            }
        }

        public AdministratiefPersoneel(string naam, DateTime geboortedatum, Dictionary<string, byte> taken) : base(naam, geboortedatum, taken)
        {
        
        }
        public override double BepaalWerkbelasting()
        {
            double totaal = 0;
            foreach (var taak in Taken)
            {
                totaal += taak.Value;
            }
            return totaal;
        }
        public override uint BerekenSalaris()
        {
            double basis = 2000 + (Ancienniteit / 3 * 75);
            double breuk = BepaalWerkbelasting() / 40;
            return (uint)(basis * breuk);

        }
        public override string GenereerNaamkaartje()
        {
            return $"{this.Naam} (ADMINISTRATIE)";
        }
        public static void DemonstreerAdministratiefPersoneel()
        {
            var taken = new Dictionary<string, byte>();
            taken.Add("roostering", 10);
            taken.Add("correspondentie", 10);
            taken.Add("animatie", 10);
            AdministratiefPersoneel ahmed = new AdministratiefPersoneel("Ahmed Azzaoui", new DateTime(1988, 2, 4), taken);
            ahmed.Ancienniteit = 4;
            foreach (var personeel in AlleAdministratiefPersoneel)
            {
                Console.WriteLine(personeel.GenereerNaamkaartje());
            }
            foreach (var personeel in AllePersoneel)
            {
                Console.WriteLine(personeel.GenereerNaamkaartje());
            }
            Console.WriteLine(ahmed.BerekenSalaris());
            Console.WriteLine(ahmed.BepaalWerkbelasting());
        }

        public override string ToString()
        {
            return base.ToString() + "\nMeerbepaald, administratief personeel";
        }

        public override string ToCSV()
        {
            return $"AdministratiefPersoneel;{CSVPersoonsGegevens}";
        }

    }

}

