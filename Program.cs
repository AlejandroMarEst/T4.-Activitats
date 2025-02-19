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
            const string Text = "He tret un 10 al examen num 5 del Modul 6";
            List<int> lista = new List<int>();
            lista = MyUtils.ExtractNumbers(Text);
            foreach(int num in lista)
            {
                Console.WriteLine(num);
            }
        }
    }
}