using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public delegate void DelegateEx(string msg);
        public static void WriteMSG(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void WriteStarryMSG(string msg)
        {
            Console.WriteLine("*" + msg + "*");
        }
        public static void Main()
        {
            const string Text = "Hola, bon dia";
            DelegateEx delegat = WriteMSG;
            delegat += WriteStarryMSG;
            delegat(Text);
        }
    }
}