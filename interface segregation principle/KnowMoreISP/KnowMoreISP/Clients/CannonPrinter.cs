using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* note 
 * here the Cannon printer supports few and remain the fuctionalites which interface extented need tp handle explicitly.
 * if i add the new function in interface of microprint then its not support that and we need to handle it explicitly.
 * So its better go for ISP. iterface segregation principle.
 */


namespace KnowMoreISP.Clients
{
    internal class CannonPrinter : IprintTask
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
