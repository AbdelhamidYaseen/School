using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vraag.Recepten;

namespace Vraag
{
    interface IRecept
    {
        string Naam();
        uint Kooktijd();
        uint AantalPersonen();
        Moeilijkheidsgraad Niveau();
    }
    interface IReceptWarm : IRecept
    {
        void Opwarmen(int temp);
    }
    interface IReceptKoud : IRecept
    {
        void Afkoelen(int temp);
    }
    internal abstract class Recept : IRecept
    {

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string naam;
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        private uint kooktijd;
        public uint Kooktijd
        {
            get { return kooktijd; }
            set { kooktijd = value; }
        }
        private uint aantalPersonen;

        public uint AantalPersonen
        {
            get { return aantalPersonen; }
            set { aantalPersonen = value; }
        }
        private Moeilijkheidsgraad niveau;

        public Moeilijkheidsgraad Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        public Recept(int id, string naam, uint kooktijd, uint aantalpersonen, Moeilijkheidsgraad niveau)
        {
            this.id = id;
            this.naam = naam;
            this.kooktijd = kooktijd;
            this.aantalPersonen = aantalpersonen;
            this.niveau = niveau;
        }
        public static ImmutableList<Recept> SelecteerRecepten(List<Recept>recepten, Moeilijkheidsgraad moeilijkheidsgraad, List<Recept> gefilterdeLijst) 
        {
            var builder = ImmutableList.CreateBuilder<Recept>();

            foreach (var recept in recepten) 
            {
                if (recept.Niveau == moeilijkheidsgraad) 
                {
                    builder.Add(recept);
                }
            }
            return builder.ToImmutable();
        }

        string IRecept.Naam()
        {
            throw new NotImplementedException();
        }

        uint IRecept.Kooktijd()
        {
            throw new NotImplementedException();
        }

        uint IRecept.AantalPersonen()
        {
            throw new NotImplementedException();
        }

        Moeilijkheidsgraad IRecept.Niveau()
        {
            throw new NotImplementedException();
        }
    }

}
