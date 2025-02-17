using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public static void Main()
        {
            const string InsertBirthDate = "Insert ur birthdate: ";
            DateTime userDate;
            Console.WriteLine(InsertBirthDate);
            userDate = Convert.ToDateTime(Console.ReadLine());
            Employee employee = new Employee(userDate);
            Console.WriteLine(employee.AgeCalc());            
        }
    }
}