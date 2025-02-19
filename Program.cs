using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public delegate int DelegateEx19(int num1, int num2);
        public static int Multiplicar(int num1, int num2) => num1 * num2;
        public static int Dividir(int num1, int num2) => num1 / num2;
        public static void Main()
        {
            DelegateEx19 delegat = Multiplicar;
            Console.WriteLine(delegat(20, 2));
            delegat = Dividir;
            Console.WriteLine(delegat(20, 2));
        }
    }
}