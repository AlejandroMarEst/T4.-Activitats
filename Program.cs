using System;
using System.Collections;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public static void Main()
        {
            const string valors = "Quants noms vols introduir";
            List<string> noms = new List<string>();
            int numNoms;
            numNoms = MyUtils.GetPositiveNum();
            for (int i = 0; i < numNoms; i++)
            {
                noms.Add(Console.ReadLine());
            }
            noms.Sort();
            foreach (var nom in noms)
            {
                Console.WriteLine(nom);
            }
        }
    }
}