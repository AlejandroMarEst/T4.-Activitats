using System;
using System.Collections;
using T4._Activitats;
namespace ExercicisTema4
{
    public class Program
    {
        public static void Main()
        {
            const string valors = "Quants nums vols introduir";
            List<int> nums = new List<int>();
            int numNums;
            numNums = MyUtils.GetPositiveNum();
            for (int i = 0; i < numNums; i++)
            {
                nums.Add(MyUtils.GetPositiveNum());
            }
            nums.Sort();
            foreach (var num in nums)
            {
                if (MyUtils.CheckOddNum(num)){
                    Console.WriteLine(num);
                }
            }
        }
    }
}