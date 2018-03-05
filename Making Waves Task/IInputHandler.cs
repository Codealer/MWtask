using System;

namespace Making_Waves_Task
{
    public interface IInputHandler
    {
        void ConvertDatesToDateTime(out DateTime dt1, out DateTime dt2);
    }
}
