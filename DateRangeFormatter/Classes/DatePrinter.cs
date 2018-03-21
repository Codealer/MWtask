using System;

namespace Date_Range_Formatter
{
    /// <summary>
    /// Prints dates to console output
    /// </summary>
    class DatePrinter : IDatePrinter
    {
        public void Print(string date)
        {
            Console.WriteLine(date);
            Console.ReadLine();
        }

        public void PrintDates(string dt1, string dt2)
        {
            Print($"{dt1} - {dt2}");
        }
    }
}
