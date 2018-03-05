using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Waves_Task
{
    public interface IInputHandler
    {
        void ConvertDatesToDateTime(out DateTime dt1, out DateTime dt2);
    }
}
