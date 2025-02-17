using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4._Activitats
{
    public class Employee
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string ReverseName { get; set; }
        public double Age { get; set; }
        public float MonthlySalary { get; set; }
        public int Payments { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDate { get; set; }
        public Employee(int code, string name, string lastName, float monthlySalary, int payments, DateTime hireDate, DateTime birthDate) {
            Code = code;
            Name = name;
            LastName = lastName;
            FullName = name + " " + lastName;
            ReverseName = lastName + " " + name;
            Age = AgeCalc(birthDate);
            MonthlySalary = monthlySalary;
            Payments = payments;
            HireDate = hireDate;
            BirthDate = birthDate;
        }
        public Employee(int code, string name, string lastName, DateTime birthDate)
        {
            Code = code;
            Name = name;
            LastName = lastName;
            FullName = name + " " + lastName;
            ReverseName = lastName + " " + name;
            Age = AgeCalc(birthDate);
            MonthlySalary = 1800;
            Payments = 14;
            BirthDate = birthDate;
        }
        public string ReturnFullName() => FullName;
        public string ReturnReverseName() => ReverseName;
        public double AgeCalc(DateTime birthDate) => Math.Round((DateTime.Now - birthDate).TotalDays / 365, 0);
        public double AgeCalc() => Math.Round((DateTime.Now - BirthDate).TotalDays / 365, 0);
        public double TimeWorkingCalc() => Math.Round((DateTime.Now - HireDate).TotalDays, 0);
        public double YearlyWage() => MonthlySalary * 12;
        public string ToString(){
            return $"Full Name: {FullName}, Code: {Code}, Age: {Age}, Monthly Salary: {MonthlySalary}, Payments: {Payments}, Hire Date: {HireDate}, Birth Date: {BirthDate}";
        }
    }
}
