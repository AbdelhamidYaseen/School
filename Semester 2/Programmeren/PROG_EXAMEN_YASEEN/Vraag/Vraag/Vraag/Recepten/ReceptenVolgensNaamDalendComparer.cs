using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag
{
    internal class ReceptenVolgensNaamDalendComparer : IComparer<Recept>
    {
        public int Compare(Recept x, Recept y)
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
                return x.Id.CompareTo(y.Id);
            }
        }
    }
}
}
