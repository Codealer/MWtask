using System;

namespace Making_Waves_Task
{
    public interface IDateRangeSetter
    {
        void SetDatesOrder(DateTime dt1, DateTime dt2);
        void SetDateRange(DateTime dt1, DateTime dt2);
    }
}
