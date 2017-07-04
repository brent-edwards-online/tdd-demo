using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDDTutorialClockAngle.Parser
{
    public class TimeStringParser : ITimeStringParser
    {
        readonly Regex REGEX = new Regex("^(1[0-2]|[1-9]):[0-5][0-9]$");
        public Tuple<Byte, Byte> Parse(string time)
        {
            if (!REGEX.IsMatch(time)) throw new Exception("Invalid input string");   
            var fields = time.Split(':');
            var result = new Tuple<Byte, Byte>(Convert.ToByte(fields[0]), Convert.ToByte(fields[1]));
            return result;
        }
    }
}
