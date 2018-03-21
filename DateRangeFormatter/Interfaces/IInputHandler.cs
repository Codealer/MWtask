using System;

namespace Date_Range_Formatter
{
    public interface IInputHandler
    {
        void ConvertDatesToDateTime(out DateTime dt1, out DateTime dt2);
    }
}
