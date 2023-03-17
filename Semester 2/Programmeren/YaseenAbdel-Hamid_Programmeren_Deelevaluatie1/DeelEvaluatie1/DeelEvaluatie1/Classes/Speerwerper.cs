using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeelEvaluatie1.Worp;

namespace DeelEvaluatie1.Classes
{
    internal class SpeerWerper
    {
        public string naam;
        public DateTime geboorteDatum;
        public int ranking;
        public string id;
        public Worp persoonlijkRecord;
        private Worp[] worpen = new Worp[3];
        public SpeerWerper(string naam, DateTime geboorteDatum, int ranking, Worp persoonlijkRecord)
        {

            Naam = naam;
            Geboortedatum = geboorteDatum;
            Ranking = ranking;
            PersoonlijkRecord = persoonlijkRecord;
            
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        
        public DateTime Geboortedatum 
        {
            get { return geboorteDatum; }
            set { geboorteDatum = value; }
        }
        public int Ranking
        {
            get 
            { 
                return this.ranking; 
            }
            set 
            {
                if (Ranking > 10)
                {
                    Console.WriteLine("Enkel de beste 10 speerwerpers mogen deelnemen");
                }
                else if (ranking < 10) 
                {
                    Console.WriteLine($"Welkom bij onze wedstrijd je hebt {Id} Id");
                }
            }
        }
        public string Id 
        {
            get 
            {
                id = "01";
                return $"JUMPER0{id}";
            }
            private set 
            {
                id =value;
            }
        }
        public Worp PersoonlijkRecord
        {
            get { return persoonlijkRecord; }
            private set { persoonlijkRecord = value; }
        }





        public string RegistrerenWorp(Worp worp) 
        {
            if (worpen.Length < 3)
            {
                for (int i = 0; i < worpen.Length; i++)
                {
                    if (worpen[i].Afstand>PersoonlijkRecord.Afstand) 
                    {
                        return $"Proficiat met je nieuwe record van {worpen[i].Afstand} meter";
                    }
                }
            }
            else 
            {
                return "Een worp teveel";
            }

            return "Worp Geregistreerd";
        }
        public void TonenInfo() 
        {
            Console.WriteLine($"Werper {Naam} heeft ranking {Ranking}, Id {Id} en een persoonlijk record van {PersoonlijkRecord}");
            for (int i = 0; i < worpen.Length; i++)
            {
                //Console.WriteLine($"Worp {worpen[i+1]} is {worpen[i].Status} en heeft een afstand van {worpen[i].Afstand} meter");
            }
        }
        public static void DemonstreerSpeerWerper() 
        {
            Worp persoonlijkRecord = new Worp();
            persoonlijkRecord.Status = WorpStatus.Geldig;
            persoonlijkRecord.Afstand = 30.4;
            persoonlijkRecord.Datum = new DateTime(2023, 3, 3);
            SpeerWerper speerWerper1 = new SpeerWerper("Jan Van den Poel",
            new DateTime(1962, 09, 28), 10000, persoonlijkRecord);
            persoonlijkRecord.Afstand = 80.4;
            SpeerWerper speerWerper2 = new SpeerWerper("Junior Van den Poel",
            new DateTime(2002, 09, 28), 5, persoonlijkRecord);
            speerWerper2.TonenInfo();
            Worp worp1 = new Worp();
            worp1.Status = WorpStatus.Geldig;
            worp1.Afstand = 79.4;
            worp1.Datum = DateTime.Now;
            Console.WriteLine(speerWerper2.RegistrerenWorp(worp1));
            Worp worp2 = new Worp();
            worp2.Status = WorpStatus.Ongeldig;
            worp2.Afstand = 82.4;
            worp2.Datum = DateTime.Now;
            Console.WriteLine(speerWerper2.RegistrerenWorp(worp2));
            Worp worp3 = new Worp();
            worp3.Status = WorpStatus.Geldig;
            worp3.Afstand = 81.4;
            worp3.Datum = DateTime.Now;
            Console.WriteLine(speerWerper2.RegistrerenWorp(worp3));
            Worp worp4 = new Worp();
            worp4.Status = WorpStatus.Geldig;
            worp4.Afstand = 83.4;
            worp4.Datum = DateTime.Now;
            Console.WriteLine(speerWerper2.RegistrerenWorp(worp4));
            speerWerper2.TonenInfo();

        }
    }
}
