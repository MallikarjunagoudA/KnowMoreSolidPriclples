using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMoreISP
{
    public interface InormalPrinter
    {

        public string print();
        public string scan();
   
    }

    public interface IAdvancePrinter
    {
        public string fax();
        public string duplex();

        
    }
}
