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
            const string Password1 = "Hola1234!";
            const string Password2 = "hola1234";
            Console.WriteLine(MyUtils.ValidatePassword(Password1));
            Console.WriteLine(MyUtils.ValidatePassword(Password2));
        }
    }
}