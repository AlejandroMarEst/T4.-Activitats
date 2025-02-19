using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public delegate int DelegateEx(int a, int b);
        public static int AnonymousMethod(DelegateEx delegar)
        {
            return delegar(2, 4);
        }
        public static void Main()
        {
            int num = AnonymousMethod(delegate (int a, int b)
            {
                int num = 1;
                for (int i = 0; i < b; i++)
                {
                    num *= a;
                }
                return num;
            });
            Console.WriteLine(num);
        }
    }
}