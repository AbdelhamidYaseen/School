using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class DuplicateDataException : ApplicationException
    {
        private object waarde1;
        public object Waarde1
        {
            get { return waarde1; }
             set { waarde1 = value; }
        }

        private object waarde2;
        public object Waarde2
        {
            get { return waarde2; }
             set { waarde2 = value; }
        }

        public DuplicateDataException(string message, object o1, object o2) : base(message)
        {
            this.Waarde1 = o1;
            this.Waarde2 = o2;
        }
    }
}
