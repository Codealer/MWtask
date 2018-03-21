using System;
using NUnit.Framework;
using Date_Range_Formatter;

namespace DateRangeFormatter.Tests
{
    [TestFixture]
    public class DateRangeSetterTest
    {
        DateRangeSetter dateRangeSetter = new DateRangeSetter();


        private static object[] OrderedDates =
        {
                new object[] { new DateTime(1011, 1, 1), new DateTime(2011, 2, 2), "01.01.1011 - 02.02.2011" },
                new object[] { new DateTime(1011, 2, 2), new DateTime(2012, 2, 2), "02.02.1011 - 02.02.2012" },
                new object[] { new DateTime(2011, 1, 1), new DateTime(2012, 2, 2), "01.01.2011 - 02.02.2012" },
                new object[] { new DateTime(2011, 2, 2), new DateTime(2012, 1, 1), "02.02.2011 - 01.01.2012" },
                new object[] { new DateTime(2011, 1, 2), new DateTime(2012, 1, 1), "02.01.2011 - 01.01.2012" },
                new object[] { new DateTime(2011, 1, 1), new DateTime(2011, 2, 2), "01.01 - 02.02.2011" },
                new object[] { new DateTime(2011, 1, 1), new DateTime(2011, 1, 2), "01 - 02.01.2011" },
                new object[] { new DateTime(2011, 1, 1), new DateTime(2011, 1, 1), "01 - 01.01.2011" }
        };

        [TestCaseSource(nameof(OrderedDates))]
        public void SetDatesOrderOrderedDates(DateTime dt1, DateTime dt2, string expected)
        {
            Assert.AreEqual(expected, dateRangeSetter.SetDatesOrder(dt1, dt2));
        }

        private static object[] UnorderedDates =
        {
                new object[] { new DateTime(2012, 2, 2), new DateTime(2011, 2, 2), "02.02.2011 - 02.02.2012" },
                new object[] { new DateTime(2012, 2, 2), new DateTime(2011, 1, 1), "01.01.2011 - 02.02.2012" },
                new object[] { new DateTime(2012, 2, 2), new DateTime(2012, 1, 1), "01.01 - 02.02.2012" },
                new object[] { new DateTime(2012, 2, 2), new DateTime(2012, 2, 1), "01 - 02.02.2012" }
        };

        [TestCaseSource(nameof(UnorderedDates))]
        public void SetDatesOrderUnorderedDates(DateTime dt2, DateTime dt1, string expected)
        {
            Assert.AreEqual(expected, dateRangeSetter.SetDatesOrder(dt2, dt1));
        }
    }
}
