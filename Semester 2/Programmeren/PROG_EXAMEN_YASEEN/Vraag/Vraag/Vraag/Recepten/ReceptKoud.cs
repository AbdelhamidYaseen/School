using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag.Recepten
{
    internal class ReceptKoud : Recept, IReceptKoud
    {
        public ReceptKoud(int id, string naam, uint kooktijd, uint aantalpersonen, Moeilijkheidsgraad niveau) : base(id, naam, kooktijd, aantalpersonen, niveau)
        {
        }

        public void Afkoelen(int temp)
        {
            Console.WriteLine($"Koude maaltijd van <{Naam}> aan <{temp}> graden");
        }

    }
}
