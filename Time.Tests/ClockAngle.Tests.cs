using Microsoft.VisualStudio.TestTools.UnitTesting;
using Time;

namespace Time.Tests
{
    [TestClass]
    public class ClockAngleTest
    {
        [TestMethod]
        public void WhatClockAngle_One_True()
        {
            ClockAngle testClockAngle = new ClockAngle();
            Assert.AreEqual(30, testClockAngle.WhatClockAngle(0100));
        }

        [TestMethod]
        public void WhatClockAngle_Two_True()
        {
            ClockAngle testClockAngle = new ClockAngle();
            Assert.AreEqual(60, testClockAngle.WhatClockAngle(0200));
        }

        [TestMethod]
        public void WhatClockAngle_OneThirty_True()
        {
            ClockAngle testClockAngle = new ClockAngle();
            Assert.AreEqual(45, testClockAngle.WhatClockAngle(130));
        }
    }
}