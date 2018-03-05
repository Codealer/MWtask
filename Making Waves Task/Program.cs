using System;

namespace Making_Waves_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHandler inputHandler;
            DateRangeSetter dateRangeSetter = new DateRangeSetter();

            try
            {
                inputHandler = new InputHandler(args);
                inputHandler.ConvertDatesToDateTime(out DateTime dt1, out DateTime dt2);
                dateRangeSetter.SetDatesOrder(dt1, dt2);
            }
            catch (Exception ex)
            {
                // shows message from exception and information about expected input arguments
                Console.WriteLine(ex.Message);
                Console.WriteLine("Incorrect arguments, please enter two dates, expected format: dd.MM.yyyy, example: program.exe 01.01.2017 05.01.2017");
                Console.ReadLine();
                return;
            }

            DatePrinter datePrinter = new DatePrinter();
            datePrinter.PrintDates(dateRangeSetter.DateTime1, dateRangeSetter.DateTime2);
        }
    }
}