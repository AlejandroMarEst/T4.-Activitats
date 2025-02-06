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
            const string Existeix = "Aquest nom existeix al diccionari";
            const string NoExisteix = "Aquest nom no existeix al diccionari";
            const string Edat = "L'edat de {0} es {1}";
            string nameUser;
            bool exists;
            Dictionary<string, int> dictionaryNameAge = new Dictionary<string, int>();
            dictionaryNameAge.Add("Marc", 21);
            dictionaryNameAge.Add("Laura", 19);
            dictionaryNameAge.Add("Pau", 22);
            foreach (var item in dictionaryNameAge)
            {
                Console.WriteLine(item);
            }
            nameUser = Console.ReadLine();
            exists = dictionaryNameAge.ContainsKey(nameUser);
            Console.WriteLine(exists ? Existeix : NoExisteix);
            if (exists)
            {
                Console.WriteLine(Edat, nameUser, dictionaryNameAge[nameUser]);
            }
            dictionaryNameAge.Remove("Laura");
            foreach(var item in dictionaryNameAge)
            {
                Console.WriteLine(item);
            }
        }
    }
}