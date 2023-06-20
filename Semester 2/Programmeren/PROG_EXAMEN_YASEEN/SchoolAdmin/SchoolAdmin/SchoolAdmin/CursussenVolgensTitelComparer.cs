using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class CursussenVolgensTitelComparer: IComparer<Cursus>
    {
        public int Compare( Cursus x, Cursus y)
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
                return x.Titel.CompareTo(y.Titel);
            }
        }
    }
}