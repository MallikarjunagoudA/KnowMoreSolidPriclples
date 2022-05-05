using DependencyInversionPrinciple.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.controller
{
    public class Employee
    {
        private readonly IEmpRepo _IEmpRepo;
        public Employee(IEmpRepo IEmpRepo )
        {
            this._IEmpRepo = IEmpRepo;
        }

        public string GetEmpDetails()
        {
            var a = _IEmpRepo.GetEmpData();
            if (a.Count > 0)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
    }


}
