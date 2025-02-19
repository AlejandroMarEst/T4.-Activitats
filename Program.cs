using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public delegate void Notificacio(string msg);
        public static void PrintMessage(Notificacio msg)
        {
            msg("MissatgeAnonim");
        }
        public static void Main()
        {
            PrintMessage(delegate (string msg) {
                Console.WriteLine(msg);
            });
        }
    }
}