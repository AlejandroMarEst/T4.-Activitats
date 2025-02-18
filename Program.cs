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
            List<int> list = new List<int> { 10,258,564,31,5484,84,864,4,64,64 };
            int sum = list.Sum();
            Console.WriteLine(sum);
        }
    }
}