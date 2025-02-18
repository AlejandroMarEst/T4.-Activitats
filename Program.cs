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
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            dictionary.Add("Manu", 800.00);
            dictionary.Add("Gabi", 800.00);
            dictionary.Add("Paul", 1000.00);
            foreach (var item in dictionary) { 
                Console.WriteLine(item.Key + ", " + item.Value);
            }
        }
    }
}