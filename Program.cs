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
        public static int Sumar(int num1, int num2) => num1 + num2;
        public static int Multiplicar(int num1, int num2) => num1 * num2;
        public static int Dividir(int num1, int num2) => num1 / num2;
        public static int ExecutarOperacio(int num1, int num2, DelegateEx19 delegat) => delegat(num1, num2);
        public static void Main()
        {
            const int num1 = 20;
            const int num2 = 2;
            Console.WriteLine(ExecutarOperacio(num1, num2, Multiplicar));
            Console.WriteLine(ExecutarOperacio(num1, num2, Dividir));
            Console.WriteLine(ExecutarOperacio(num1, num2, Sumar));

        }
    }
}