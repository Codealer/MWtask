using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Waves_Task
{
    public static class DateFormats
    {
        private static string dayMonthYearFormat = "dd.MM.yyyy";
        private static string dayMonthFormat = "dd.MM";
        private static string dayFormat = "dd";

        public static string DayMonthYearFormat
        {
            get { return dayMonthYearFormat; }
            set { dayMonthYearFormat = value; }
        }

        public static string DayMonthFormat
        {
            get { return dayMonthFormat; }
            set { dayMonthFormat = value; }
        }

        public static string DayFormat
        {
            get { return dayFormat; }
            set { dayFormat = value; }
        }
    }
}
