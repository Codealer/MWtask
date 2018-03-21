namespace Date_Range_Formatter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDateRangeSetter dateRangeSetter = new DateRangeSetter();
            IApplication dateApplication = new DateApplication(dateRangeSetter);
            dateApplication.StartApplication(args);
        }
    }
}