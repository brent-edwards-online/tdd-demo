using TDDTutorialClockAngle.Parser;
using System;

namespace TDDTutorialClockAngle.Calculator
{
    public class ClockAngleCalculator : IClockAngleCalculator
    {
        ITimeStringParser _parser;

        private ClockAngleCalculator() { }

        public ClockAngleCalculator(ITimeStringParser parser)
        {
            _parser = parser;
        }

        public double Calculate(string time)
        {
            var hands = _parser.Parse(time);
            double minutesAngle = (double)hands.Item2 * 6.0;
            double hoursAngle = ((30.0 * (double)hands.Item1) + (30.0 * ((double)hands.Item2 / 60.0))) % 360.0;

            if (minutesAngle > hoursAngle)
                return minutesAngle - hoursAngle;
            else
                return hoursAngle - minutesAngle;

        }
    }
}
