using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* note 
 * here the hp printer have all the fuctionalites which interface extented
 * if i add the new function in interface of microprint then its not support that and we need to handle it explicitly.
 * 
 */

namespace KnowMoreISP.Clients
{
    internal class HPPrinter : IprintTask
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
