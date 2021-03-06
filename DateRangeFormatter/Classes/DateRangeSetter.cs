﻿using System;

namespace Date_Range_Formatter
{
    /// <summary>
    /// Provides dates in chronological order and format
    /// </summary>
    public class DateRangeSetter : IDateRangeSetter
    {
        public string DateTime1
        {
            get { return dateTime1; }
            set { dateTime1 = value; }
        }

        public string DateTime2
        {
            get { return dateTime2; }
            set { dateTime2 = value; }
        }

        private string dateTime1, dateTime2;

        /// <summary>
        /// Provides dates in chronological order
        /// </summary>
        public string SetDatesOrder(DateTime dt1, DateTime dt2)
        {
            if (dt1 <= dt2)
            {
                return SetDateRange(dt1, dt2);
            }
            else
            {
                return SetDateRange(dt2, dt1);
            }
        }

        /// <summary>
        /// Provides dates in specified format
        /// </summary>
        public string SetDateRange(DateTime dt1, DateTime dt2)
        {

            if (dt1.Year == dt2.Year && dt1.Month == dt2.Month)
            {
                DateTime1 = dt1.ToString(DateFormats.DayFormat);
            }
            else if (dt1.Year == dt2.Year && dt1.Month != dt2.Month)
            {
                DateTime1 = dt1.ToString(DateFormats.DayMonthFormat);
            }
            else
            {
                DateTime1 = dt1.ToString(DateFormats.DayMonthYearFormat);
            }

            DateTime2 = dt2.ToString(DateFormats.DayMonthYearFormat);

            return ($"{DateTime1} - {DateTime2}");
        }
    }
}
