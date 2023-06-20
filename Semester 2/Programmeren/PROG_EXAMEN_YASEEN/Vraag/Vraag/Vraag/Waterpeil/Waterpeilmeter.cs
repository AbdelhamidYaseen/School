using System;

namespace Vraag.Waterpeil
{
    public class Waterpeilmeter
    {

        private uint id;
        public uint Id
        {
            get { return id; }
        }

        public Waterpeilmeter(uint id)
        {
            this.id = id;
        }

        public int Waterpeil()
        {
            Random randomWaterpeil = new Random();
            Random randomWelOfNietFout = new Random();
            Random randomFoutMelding = new Random();

            // Waterpeilmeter in fout
            if (randomWelOfNietFout.Next(6) > 4)
            {
                // foutmelding tussen 1 en 40
                int foutmelding = randomFoutMelding.Next(40) + 1;
                // Opgave: Vervang deze exception door een zelf gecreëerde exception waar je de id en de foutmelding meegeeft
                throw new Exception();
            }
            else
            {
                return randomWaterpeil.Next(-20, 40);
            }
        }
    }
}