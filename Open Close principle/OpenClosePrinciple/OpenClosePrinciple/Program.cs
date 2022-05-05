using System;

namespace OpenClosePrinciple
{

    public abstract  class Employee
    {
        public void ageCalculate(DateTime DOB)
        {
            //calculate age
        }

        public void empFullName(string fn,string mn, string ln)
        {
            var fullName = fn + mn + ln;
        }

        public abstract string Bonus(string salary);
    }

    public class tempEmp : Employee
    {
        public override string Bonus(string salary)
        {
            return Convert.ToString(Convert.ToInt32(salary) * 10);
        }
    }

    public class PermanenetEmp : Employee
    {
        public override string Bonus(string salary)
        {
            return Convert.ToString(Convert.ToInt32(salary) * 15);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
