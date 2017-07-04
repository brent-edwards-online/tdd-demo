using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTutorialClockAngle.Calculator;
using TDDTutorialClockAngle.Parser;
using NSubstitute;

namespace TDDTutorialClockAngle.Test
{
    [TestClass]
    public class TestClockAngleCalculator
    {
        [TestMethod]
        [TestCategory("Test Clock Angle Calculator")]
        public void MidnightReturns0()
        {
            var parser = Substitute.For<ITimeStringParser>();
            parser.Parse(Arg.Any<string>()).Returns(new Tuple<byte, byte>(12,0));

            var calculator = new ClockAngleCalculator(new TimeStringParser());
            var actual = calculator.Calculate("12:00");
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        [TestCategory("Test Clock Angle Calculator")]
        public void SixTwentyReturns70()
        {
            var parser = Substitute.For<ITimeStringParser>();
            parser.Parse(Arg.Any<string>()).Returns(new Tuple<byte, byte>(6, 20));

            var calculator = new ClockAngleCalculator(new TimeStringParser());
            var actual = calculator.Calculate("6:20");
            Assert.AreEqual(70, actual);
        }

        [TestMethod]
        [TestCategory("Test Clock Angle Calculator")]
        public void NineFortyReturns50()
        {
            var parser = Substitute.For<ITimeStringParser>();
            parser.Parse(Arg.Any<string>()).Returns(new Tuple<byte, byte>(9, 40));

            var calculator = new ClockAngleCalculator(new TimeStringParser());
            var actual = calculator.Calculate("9:40");
            Assert.AreEqual(50, actual);
        }
    }
}
