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
            string[] arr = new string[] { "Figaflor", "Formatge", "Pastanaga", "Llaminadura"};
            List<string> list = arr.ToList();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}