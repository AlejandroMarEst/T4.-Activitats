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
            List<int> list = new List<int> { 10, 20, 849489, 87, 455, 512, 100 };
            list = list.Where(x => x < 500).ToList();
            foreach (int item in list) {
                Console.WriteLine(item);
            }
        }
    }
}