using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4._Activitats
{
    public class Employee
    {
        public DateTime BirthDate { get; set; }
        public Employee(DateTime birthDate) { 
            BirthDate = birthDate;
        }
        public double AgeCalc() => Math.Round((DateTime.Now - BirthDate).TotalDays / 365, 0);
    }
}
