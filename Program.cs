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
            const string InsertData = "Inserta una data en format DD,MM,YYYY";
            const string Again = "Inserta una altre data";
            const string Yes = "La segona data es més gran";
            const string No = "La primera data es més gran";
            Console.WriteLine(InsertData);
            DateTime dataUser1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(Again);
            DateTime dataUser2 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(MyUtils.CheckFutureDate(dataUser1,dataUser2)?Yes:No);
        }
    }
}