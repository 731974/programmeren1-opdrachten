using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaamGeving
{
    class Name
    {
        //public fields zijn met een hoofdletter
        public string NameOfPerson
        {
            get
            {
                return _name;
            }
            private set { }
        }

        //private backing fields zijn zonder een hoofdletter
        private string _nameOfPerson;

    }
}
