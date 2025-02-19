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
            Console.WriteLine(MyUtils.IsValidEmail("usuari@gmail.com"));  // True
            Console.WriteLine(MyUtils.IsValidEmail("usuari@gmail"));      // False
        }
    }
}