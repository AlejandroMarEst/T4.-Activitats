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
            const string DiaAvui = "Today it's: {0}";
            DateTime date = DateTime.Now;
            DayOfWeek diaActual = date.DayOfWeek;
            Console.WriteLine(DiaAvui, diaActual);
            
        }
    }
}