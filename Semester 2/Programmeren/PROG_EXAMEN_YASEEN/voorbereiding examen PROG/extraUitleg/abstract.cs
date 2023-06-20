using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUitleg
{
    using System;

    // Definieer een abstracte class genaamd "Vorm"
    abstract class Vorm
    {
        public string Kleur { get; set; }

        // Een abstracte methode genaamd "Teken" die moet worden geïmplementeerd in afgeleide classes
        public abstract void Teken();
    }

    // Definieer een afgeleide class genaamd "Cirkel" die de class "Vorm" uitbreidt
    class Cirkel : Vorm
    {
        public override void Teken()
        {
            Console.WriteLine("Teken een cirkel met kleur: " + Kleur);
        }
    }

    // Definieer een afgeleide class genaamd "Vierkant" die de class "Vorm" uitbreidt
    class Vierkant : Vorm
    {
        public override void Teken()
        {
            Console.WriteLine("Teken een vierkant met kleur: " + Kleur);
        }
    }

    // Hoofdprogramma
    class Program
    {
        static void Main()
        {
            // Maak een instantie van de class "Cirkel"
            Cirkel cirkel = new Cirkel();
            cirkel.Kleur = "rood";
            cirkel.Teken();  // Teken een cirkel met kleur: rood

            // Maak een instantie van de class "Vierkant"
            Vierkant vierkant = new Vierkant();
            vierkant.Kleur = "blauw";
            vierkant.Teken(); // Teken een vierkant met kleur: blauw
        }
    }

}
