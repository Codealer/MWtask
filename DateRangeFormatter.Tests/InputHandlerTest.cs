using System;
using NUnit.Framework;
using Date_Range_Formatter;

namespace DateRangeFormatter.Tests
{
    [TestFixture]
    public class InputHandlerTest
    {
        InputHandler inputHandler;

        [TestCase("IncorrectArgument", "IncorrectArgument")]
        [TestCase("IncorrectArgument", "01.01.2011")]
        [TestCase("01.01.2011", "IncorrectArgument")]
        public void ConvertDatesToDateTimeIncorrectArgument(string dt1, string dt2)
        {
            string[] args = { dt1, dt2 };

            inputHandler = new InputHandler(args);

            Assert.That(() => inputHandler.ConvertDatesToDateTime(out DateTime dateTime1, out DateTime dateTime2), Throws.ArgumentException);
        }

        [TestCase("2011/01/01", "2012/02/02")]
        [TestCase("01-01-2011", "02-02-2012")]
        [TestCase("2011/01/01", "02-02-2012")]
        public void ConvertDatesToDateTimeIncorrectFormat(string dt1, string dt2)
        {
            string[] args = { dt1, dt2 };

            inputHandler = new InputHandler(args);

            Assert.That(() => inputHandler.ConvertDatesToDateTime(out DateTime dateTime1, out DateTime dateTime2), Throws.ArgumentException);
        }

        [TestCase("01.13.2011", "02.02.2012")]
        [TestCase("55.01.2011", "02.02.2012")]
        public void ConvertDatesToDateTimeIncorrectDate(string dt1, string dt2)
        {
            string[] args = { dt1, dt2 };

            inputHandler = new InputHandler(args);

            Assert.That(() => inputHandler.ConvertDatesToDateTime(out DateTime dateTime1, out DateTime dateTime2), Throws.ArgumentException);
        }

        [TestCase("2011/01/01", "2012/02/02", "2012/02/02")]
        public void CheckForArgumentsNumberIncorrectArgumentsNumber(string dt1, string dt2, string dt3)
        {
            string[] args = { dt1, dt2, dt3 };

            Assert.That(() => { inputHandler = new InputHandler(args); inputHandler.CheckForArgumentsNumber(args); }, Throws.ArgumentException);
        }
    }
}
