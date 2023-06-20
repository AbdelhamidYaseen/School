using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUitleg
{

        using System;

// Definieer een basisclass genaamd "Dier"
class Dier
    {
        public string Naam { get; set; }
        public float Gewicht { get; set; }

        // Een methode genaamd "MaakGeluid" die kan worden gebruikt door elk dier
        public virtual void MaakGeluid()
        {
            Console.WriteLine("Het dier maakt een geluid.");
        }
    }

    // Definieer een afgeleide class genaamd "Leeuw" die de class "Dier" uitbreidt
    class Leeuw : Dier
    {
        // Overschrijf de methode "MaakGeluid" specifiek voor een leeuw
        public override void MaakGeluid()
        {
            Console.WriteLine("De leeuw brult.");
        }
    }

    // Definieer een afgeleide class genaamd "Tijger" die de class "Dier" uitbreidt
    class Tijger : Dier
    {
        // Overschrijf de methode "MaakGeluid" specifiek voor een tijger
        public override void MaakGeluid()
        {
            Console.WriteLine("De tijger gromt.");
        }
    }

    // Hoofdprogramma
    class Program
    {
        static void Main()
        {
            // Maak een instantie van de class "Dier"
            Dier dier = new Dier();

            // Maak een instantie van de class "Leeuw"
            Leeuw leeuw = new Leeuw();

            // Maak een instantie van de class "Tijger"
            Tijger tijger = new Tijger();

            // Roep de methode "MaakGeluid" aan voor elk dier
            dier.MaakGeluid();   // Het dier maakt een geluid.
            leeuw.MaakGeluid();  // De leeuw brult.
            tijger.MaakGeluid(); // De tijger gromt.
        }
    }

}

