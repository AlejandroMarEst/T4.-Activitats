using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public static void Main()
        {
            const string Parells = "Llista Parells";
            const string Positius = "Llista Positius";
            const string Bigger = "Llista Mayor de 20 i el quadrat";
            const string Frequencia = "Llista Frequencia";
            const string FrequenciaChar = "Llista Frequencia Characters";
            const string Freq = "{0}: {1}";
            const string Char = "Isaac and his mother lived alone in a small house on a hill. Isaac kept to himself - drawing pictures and playing with his toys as his mom watched Christian broadcasts on the television.";
            const string WeekDays = "Days of the week:";
            List<int> llista1 = new List<int> { 10, -32, 10, -424, 3, 3, -29, 11, 87, 90 };
            List<int> llistaParells = llista1.Where(x => x % 2 == 0).ToList();
            List<int> llistaPositius = llista1.Where(x => x >= 0).ToList();
            List<int> llistaBigger = llista1.Where(x => x > 20).ToList();
            Console.WriteLine(Parells);
            llistaParells.ForEach(num => Console.Write(num + ", "));
            Console.WriteLine("\n\n" + Positius);
            llistaPositius.ForEach(num => Console.Write(num + ", "));
            Console.WriteLine("\n\n" + Bigger);
            llistaBigger.ForEach(num => Console.Write(num + ": " + num * num + ", "));
            Console.WriteLine("\n\n" + Frequencia);
            foreach (int item in llista1.Distinct())
            {
                Console.WriteLine(Freq, item, llista1.FindAll(x => x == item).Count);
            }
            Console.WriteLine("\n" + FrequenciaChar);
            foreach (char character in Char.Distinct())
            {
                Console.WriteLine(Freq, character, Regex.Count(Char, $"[{character}]"));
            }
            Console.WriteLine("\n" + WeekDays);


        }
    }
}