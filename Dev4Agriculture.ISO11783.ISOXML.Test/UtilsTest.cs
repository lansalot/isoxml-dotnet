﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev4Agriculture.ISO11783.ISOXML.Test
{
    [TestClass]
    public class UtilsTest
    {
        [TestMethod]
        public void DatesFromTLGAreCalculatedCorrectly()
        {
            var date = DateUtilities.GetDateTimeFromTimeLogInfos(0, 0);
            Assert.AreEqual(date.Year, 1980);
            Assert.AreEqual(date.Minute, 0);
            Assert.AreEqual(date.Hour, 0);
            Assert.AreEqual(date.Month, 1);



            date = DateUtilities.GetDateTimeFromTimeLogInfos(14611, 63020000);
            Assert.AreEqual(date.Year, 2020);
            Assert.AreEqual(date.Month, 1);
            Assert.AreEqual(date.Day, 2);
            Assert.AreEqual(date.Hour, 17);
            Assert.AreEqual(date.Minute, 30);
            Assert.AreEqual(date.Second, 20);
        }


    }
}
