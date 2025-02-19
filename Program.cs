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
            Func<int, int, int> lambda = (x, y) => x - y;
            Console.WriteLine(lambda(10, 5));
            Console.WriteLine(lambda(25, 12));
        }
    }
}