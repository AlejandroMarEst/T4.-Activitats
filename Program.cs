using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(MyUtils.IsValidPhone("600123456"));  // True
            Console.WriteLine(MyUtils.IsValidPhone("600 123 456"));      // True
            Console.WriteLine(MyUtils.IsValidPhone("600 123 45"));      // False
            Console.WriteLine(MyUtils.IsValidPhone("+34 600 123 456"));      // True
        }
    }
}