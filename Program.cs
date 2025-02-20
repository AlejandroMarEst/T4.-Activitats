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
            string path = "notes.txt";
            string notes = "Alejandro Martin: 9\nSergi Albalat: 3\nIsa Severiche: 10\nCai Huaei: 7\nEmma Rodriguez: 8";
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(notes);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}