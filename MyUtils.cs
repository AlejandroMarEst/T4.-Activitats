using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4._Activitats
{
    public class MyUtils
    {
        public static int GetPositiveNum()
        {
            const string ErrorMessage = "El valor ha de ser un nombre positiu.";
            if (!int.TryParse(Console.ReadLine(), out int value) || value <= 0)
            {
                throw new FormatException(ErrorMessage);
            }
            return value;
        }
        /// <summary>
        /// Gets a number and checks if its ODD
        /// </summary>
        /// <param name="num">Number to be checked</param>
        /// <returns>True if its odd, false if its even</returns>
        public static bool CheckEvenNum(int num) => num % 2 == 0;
        public static bool CheckFutureDate(DateTime date1, DateTime date2) => date1 < date2;
    }
}
