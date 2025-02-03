using System;
using System.Collections;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(Console.ReadLine());
            arrayList.Add(Console.ReadLine());
            arrayList.Add(Console.ReadLine());
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}