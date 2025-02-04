using System;
using System.Collections;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> alumnes = new Dictionary<string, int>();
            alumnes.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            alumnes.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            alumnes.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            foreach (var i in alumnes)
            {
                Console.WriteLine(i);
            }
        }
    }
}