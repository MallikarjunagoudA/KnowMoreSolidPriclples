using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this how we can handle easily with the ISP.

namespace KnowMoreISP.Clients
{
    internal class AdvancedPrinter : IprintTask, IAdvancePrinter
    {
        public string duplex()
        {
            throw new NotImplementedException();
        }

        public string fax()
        {
            throw new NotImplementedException();
        }

        public string print()
        {
            throw new NotImplementedException();
        }

        public string scan()
        {
            throw new NotImplementedException();
        }
    }
}
