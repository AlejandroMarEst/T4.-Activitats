using System;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public static void Main()
        {
            Parella<string, int> parella1 = new Parella<string, int>("Miau", 4);
            parella1.ShowValues();
            Parella<double, bool> parella2 = new Parella<double, bool>(0.0, true);
            parella2.ShowValues();
        }
    }
}