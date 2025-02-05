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
            ArrayList arrayList = new ArrayList() { "Maria", "Joan", "Anna", 42, true };
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Remove(42);
            arrayList.Remove(true);
            arrayList.Insert(2, "Pere");
            Console.WriteLine();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.ToArray();
        }
    }
}