using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class StudentenVolgensNaamDalendComparer: IComparer<Student>
    {
         public int Compare(Student x, Student y)
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
                return y.Naam.CompareTo(x.Naam);
            }
        }
    }
    
}