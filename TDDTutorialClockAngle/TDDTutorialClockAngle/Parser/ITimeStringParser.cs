using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorialClockAngle.Parser
{
    public interface ITimeStringParser
    {
        Tuple<Byte, Byte> Parse(string time);
    }
}
