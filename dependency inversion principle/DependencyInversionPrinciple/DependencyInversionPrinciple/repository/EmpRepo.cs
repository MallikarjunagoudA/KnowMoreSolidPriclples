using DependencyInversionPrinciple.interfaces;
using DependencyInversionPrinciple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.repository
{
    public class EmpRepo :IEmpRepo
    {

        public List<EmpDetails> GetEmpData()
        {
            List<EmpDetails> emp = new List<EmpDetails>();
            //emp[{ address = "sfd", empName = "dsf", empid = 4 }];

            return emp;

        }

    }
}
