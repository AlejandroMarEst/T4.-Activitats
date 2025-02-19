using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static bool IsValidEmail(string mail) => Regex.IsMatch(mail, @"(?i)^[A-Z1-9].*@[A-Z].*\.com$");
        public static bool IsValidPhone(string phone)
        {
            if (Regex.IsMatch(phone, @"(?i)^[6-7][0-9]{8}$")) { return true; }
            else if (Regex.IsMatch(phone, @"(?i)^[6-7][0-9]{2} [0-9]{3} [0-9]{3}$")) { return true; }
            else if (Regex.IsMatch(phone, @"(?i)^\+34 [6-7][0-9]{2} [0-9]{3} [0-9]{3}$")) { return true; }
            else { return false; }
        }
        public static List<int> ExtractNumbers(string text) {
            List<int> numbers = new List<int>();
            MatchCollection matches = Regex.Matches(text, "\\d+");
            foreach (Match match in matches)
            {
                numbers.Add(int.Parse(match.Value));
            }
            return numbers;
        }
        public static bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{7,}$");
        }
    }
}
