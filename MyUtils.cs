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
    }
}
