using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTutorialClockAngle.Parser;

namespace TDDTutorialClockAngle.Test
{
    [TestClass]
    public class TestTimeStringParser
    {
        ITimeStringParser _parser;

        [TestInitialize]
        public void Initialize()
        {
            _parser = new TimeStringParser();
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        public void MidnightShouldReturn_12_0()
        {
            var actual = _parser.Parse("12:00");
            Assert.AreEqual(12, actual.Item1);
            Assert.AreEqual(0, actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        [ExpectedException(typeof(Exception))]
        public void SeparatorShouldBeColon()
        {
            var actual = _parser.Parse("12.00");
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        [ExpectedException(typeof(Exception))]
        public void ZeroHourShouldThrowException()
        {
            var actual = _parser.Parse("0:00");
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        [ExpectedException(typeof(Exception))]
        public void ThirteenHourShouldThrowException()
        {
            var actual = _parser.Parse("13:00");
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        [ExpectedException(typeof(Exception))]
        public void SixtyMinuteShouldThrowException()
        {
            var actual = _parser.Parse("1:60");
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        public void ThreeFifteenShouldReturn_3_15()
        {
            var actual = _parser.Parse("3:15");
            Assert.AreEqual(3, actual.Item1);
            Assert.AreEqual(15, actual.Item2);
        }


        
    }
}
