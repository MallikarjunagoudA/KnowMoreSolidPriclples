using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMoreISP
{
    internal interface IprintTask
    {
        public string print();
        public string scan();
        public string fax();
        public string duplex();

    }
}
