using System;
using System.Globalization;

namespace Making_Waves_Task
{
    /// <summary>
    /// Class handling input parameters and converting them
    /// </summary>
    public class InputHandler : IInputHandler
    {

        private string dateTime1, dateTime2;

        public InputHandler(string[] dateTimes)
        {
            CheckForArgumentsNumber(dateTimes);

            dateTime1 = dateTimes[0];
            dateTime2 = dateTimes[1];
        }

        /// <summary>
        /// Checks if number of arguments is correct
        /// </summary>
        public void CheckForArgumentsNumber(string[] dateTimes)
        {
            // validation by number of arguments
            if (dateTimes.Length != 2)
            {
                throw new ArgumentException("Incorrect number of arguments: expected arguments number: 2, given arguments number: " + dateTimes.Length);
            }
        }

        /// <summary>
        /// Converts string arguments to DateTime
        /// </summary>
        public void ConvertDatesToDateTime(out DateTime dt1, out DateTime dt2)
        {
            bool parsed1 = DateTime.TryParseExact(dateTime1, DateFormats.DayMonthYearFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out dt1);
            bool parsed2 = DateTime.TryParseExact(dateTime2, DateFormats.DayMonthYearFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out dt2);

            // validation by format of dates
            if (!parsed1 || !parsed2)
                throw new ArgumentException("Incorrect arguments: expected arguments in format dd.MM.yyyy");
        }
    }
}
