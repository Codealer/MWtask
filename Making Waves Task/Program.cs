namespace Making_Waves_Task
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