using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUitleg
{
    interface IVorm
    {
        void Teken(int x, int y);
    }

    class Cirkel : IVorm
    {
        public void Teken(int x, int y)
        {
            Console.WriteLine("Teken een cirkel op positie ({0}, {1})", x, y);
        }
    }

    class Program
    {
        static void Main()
        {
            Cirkel cirkel = new Cirkel();
            cirkel.Teken(10, 20); // Teken een cirkel op positie (10, 20)
        }
    }

}
