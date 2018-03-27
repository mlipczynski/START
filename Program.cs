using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace START
{
    class Program
    {
        static void Main(string[] args)
        {
            int wk = WeekNumber.Get_Week_Number(DateTime.Now);
            int day = (int)DateTime.Now.DayOfWeek;
            string todayDate = DateTime.Now.ToString("d-MM-yyyy");

            Console.WriteLine(wk);
            Console.WriteLine(day);
            Console.WriteLine(todayDate);
            Console.ReadKey();
        }
    }
}
