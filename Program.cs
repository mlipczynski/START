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
            ExcelFile HourSheet = new ExcelFile();
            HourSheet.ExcelFilePath = @"C:\Users\Michal\Documents\GodzinyPracy.xlsx";
            HourSheet.Rownumber = 5;

            int wk = WeekNumber.Get_Week_Number(DateTime.Now);
            int day = (int)DateTime.Now.DayOfWeek;
            string todayDate = DateTime.Now.ToString("d-MM-yyyy");


            //probny zapis do pliku
            HourSheet.openExcel();
            HourSheet.checkWeekNumber(todayDate, wk);
            HourSheet.closeExcel();

            Console.WriteLine(wk);
            Console.WriteLine(day);
            Console.WriteLine(todayDate);
            Console.ReadKey();
        }
    }
}
