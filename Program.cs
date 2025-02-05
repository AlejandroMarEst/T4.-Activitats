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
            List<int> llistaNums = new List<int>() { 5, 10, 15, 20, 25 };
            llistaNums.Add(30);
            llistaNums.Insert(1, 7);
            llistaNums.Remove(15);
            llistaNums = llistaNums.OrderDescending().ToList();
            llistaNums = llistaNums.Where(item => item % 2 == 0).ToList();
            llistaNums.ForEach(item => Console.WriteLine(item));
        }
    }
}