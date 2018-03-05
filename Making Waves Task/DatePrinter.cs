using System;

namespace Making_Waves_Task
{
    /// <summary>
    /// Prints dates to console output
    /// </summary>
    class DatePrinter : IDatePrinter
    {
        public void PrintDates(string dt1, string dt2)
        {
            Console.WriteLine("{0} - {1}", dt1, dt2);
            Console.ReadLine();
        }
    }
}
