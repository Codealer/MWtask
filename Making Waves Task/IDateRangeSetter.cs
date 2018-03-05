using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Waves_Task
{
    public interface IDateRangeSetter
    {
        void SetDatesOrder(DateTime dt1, DateTime dt2);
        void SetDateRange(DateTime dt1, DateTime dt2);
    }
}
