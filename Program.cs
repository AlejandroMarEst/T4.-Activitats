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
            List<int> list = new List<int>(10) { 10,258,563,31,5484,87,864,5,64,63 };
            list = list.Where(x => x % 2 == 0).ToList();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}