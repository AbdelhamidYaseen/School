using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin
{
   
   internal class StudentenVolgensNaamStijgendComparer : IComparer<Student>
    {
        public int Compare( Student x,  Student y)
        {
            if (x is null)
            {
                return -1;
            }
            else if (y is null)
            {
                return 1;
            }
            else
            {
                return x.Naam.CompareTo(y.Naam);
            }
        }
    }
}