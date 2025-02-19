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
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine(multiply(4, 3));
            Action<int, int> showPlus = (x, y) => Console.WriteLine(x + y);
            showPlus(1, 7);
        }
    }
}