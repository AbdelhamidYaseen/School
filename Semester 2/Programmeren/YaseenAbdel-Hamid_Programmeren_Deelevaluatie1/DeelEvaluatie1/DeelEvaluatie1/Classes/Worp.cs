using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeelEvaluatie1
{
    internal class Worp
    {
        public enum WorpStatus{ Geldig, Ongeldig };

        public WorpStatus Status;
        public double Afstand;
        public DateTime Datum;

    }
}
