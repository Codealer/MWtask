﻿using System;

namespace Making_Waves_Task
{
    public interface IDateRangeSetter
    {
        string DateTime1
        { get; set; }

        string DateTime2
        { get; set; }

        string SetDatesOrder(DateTime dt1, DateTime dt2);
        string SetDateRange(DateTime dt1, DateTime dt2);
    }
}
