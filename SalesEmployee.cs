using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4._Activitats
{
    public class SalesEmployee : Employee
    {
        public float Commission { get; set; }
        public SalesEmployee(int code, string name, string lastName, float monthlySalary, int payments, DateTime hireDate, DateTime birthDate, float commission) : base(code, name, lastName, monthlySalary, payments, hireDate, birthDate)
        {
            Commission = commission;
        }
    }
}
