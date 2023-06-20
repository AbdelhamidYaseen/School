using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vraag.Recepten;

namespace Vraag
{
    internal class ReceptWarm : Recept, IReceptWarm
    {
        public ReceptWarm(int id, string naam, uint kooktijd, uint aantalpersonen, Moeilijkheidsgraad niveau) : base(id, naam, kooktijd, aantalpersonen, niveau)
        {
        }

        public void Opwarmen(int temp) 
        {
            Console.WriteLine($"Warme maaltijd van <{this.Naam}> aan <{temp}> graden");
        }
    }
}
